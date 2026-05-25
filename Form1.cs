using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using ReaderB;

namespace UHFReader
{
  public partial class Form1 : Form
  {
    private bool fAppClosed; //在测试模式下响应关闭应用程序
    private byte fComAdr = 0xff; //当前操作的ComAdr 
    private byte fBaud;
    private int PortHandle;
    private int fCmdRet = 30; //所有执行指令的返回值
    private int fOpenComIndex; //打开的串口索引号
    private bool ComOpen = false;
    private double fdminfre;
    private double fdmaxfre;
    private bool fIsInventoryScan;
    private string fInventory_EPC_List; //存贮询查列表（如果读取的数据没有变化，则不进行刷新）

    private byte Maskadr;
    private byte MaskLen;
    private byte MaskFlag;
    private byte[] fPassWord = new byte[4];
    private int ferrorcode;

    public static Form1 Instance { get; private set; }
    public static bool IsConnected => Instance?.ComOpen == true;
    public static int SharedPortHandle => Instance?.PortHandle ?? -1;
    public static byte SharedComAdr => Instance?.fComAdr ?? 0xff;

    public Form1()
    {
      InitializeComponent();
      Instance = this;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      fOpenComIndex = -1;
      fComAdr = 0;
      fBaud = 5;
      comboBox_baud.SelectedIndex = 3;
      fAppClosed = false;
      button1.Enabled = false;
      button2.Enabled = false;
      button3.Enabled = false;
      fIsInventoryScan = false;
      InitComList();
      InitReaderList();
    }
    private void ClearLastInfo()
    {
      comboBox_AlreadyOpenPort.Refresh();
      RefreshStatus();
      textBox_Type.Text = "";
      textBox_Version.Text = "";
      ISO180006B.Checked = false;
      EPCC1G2.Checked = false;
      textBox_ComAdr.Text = "";
      textBox_PowerDbm.Text = "";
      textBox_ScanTime.Text = "";
      textBox_MinFre.Text = "";
      textBox_MaxFre.Text = "";
    }
    private void InitComList()
    {
      int i = 0;
      comboBox_COM.Items.Clear();
      comboBox_COM.Items.Add(" AUTO");
      for (i = 1; i < 13; i++)
        comboBox_COM.Items.Add(" COM" + Convert.ToString(i));
      comboBox_COM.SelectedIndex = 0;
      RefreshStatus();
    }
    private void InitReaderList()
    {
      int i = 0;
      // ComboBox_PowerDbm.SelectedIndex = 0;
      comboBox_NewBaud.SelectedIndex = 3;
      for (i = 0; i < 63; i++)
      {
        comboBox_NewMinFre.Items.Add(Convert.ToString(902.6 + i * 0.4) + " MHz");
        comboBox_NewMaxFre.Items.Add(Convert.ToString(902.6 + i * 0.4) + " MHz");
      }
      comboBox_NewMaxFre.SelectedIndex = 62;
      comboBox_NewMinFre.SelectedIndex = 0;
      for (i = 0x03; i <= 0xff; i++)
        comboBox_NewScanTime.Items.Add(Convert.ToString(i) + "*100ms");
      comboBox_NewScanTime.SelectedIndex = 7;

      i = 40;
      while (i <= 300)
      {
        ComboBox_IntervalTime.Items.Add(Convert.ToString(i) + "ms");
        i = i + 10;
      }

      ComboBox_IntervalTime.SelectedIndex = 1;
      /*
      for (i = 0; i < 7; i++)
          ComboBox_BlockNum.Items.Add(Convert.ToString(i * 2) + " 和 " + Convert.ToString(i * 2 + 1));
      ComboBox_BlockNum.SelectedIndex = 0;
      i = 40;
      while (i <= 300)
      {
          ComboBox_IntervalTime_6B.Items.Add(Convert.ToString(i) + "ms");
          i = i + 10;
      } 
       */
      //ComboBox_IntervalTime_6B.SelectedIndex = 1;

      comboBox_NewPowerDbm.SelectedIndex = 13;
    }
    private void RefreshStatus()
    {
      if (!(comboBox_AlreadyOpenPort.Items.Count != 0))
        //StatusBar1.Panels[1].Text = "通讯关闭";
        statusStrip1.Items[0].Text = "通讯关闭";
      else
        //StatusBar1.Panels[1].Text = " COM" + Convert.ToString(PortHandle);
        statusStrip1.Items[1].Text = " COM" + Convert.ToString(PortHandle);
      statusStrip1.Items[0].Text = "";
      statusStrip1.Items[2].Text = "";
    }
    private void GetReaderInfo()
    {
      byte[] TrType = new byte[2];
      byte[] VersionInfo = new byte[2];
      byte ReaderType = 0;
      byte ScanTime = 0;
      byte dmaxfre = 0;
      byte dminfre = 0;
      byte powerdBm = 0;
      byte FreBand = 0;
      textBox_Version.Text = "";
      textBox_ComAdr.Text = "";
      textBox_ScanTime.Text = "";
      textBox_Type.Text = "";
      ISO180006B.Checked = false;
      EPCC1G2.Checked = false;
      textBox_PowerDbm.Text = "";
      textBox_MinFre.Text = "";
      textBox_MaxFre.Text = "";
      fCmdRet = StaticClassReaderB.GetReaderInformation(ref fComAdr, VersionInfo, ref ReaderType, TrType, ref dmaxfre, ref dminfre, ref powerdBm, ref ScanTime, PortHandle);
      if (fCmdRet == 0)
      {
        textBox_Version.Text = Convert.ToString(VersionInfo[0], 10).PadLeft(2, '0') + "." + Convert.ToString(VersionInfo[1], 10).PadLeft(2, '0');
        if (powerdBm > 13)
          comboBox_NewPowerDbm.SelectedIndex = 13;
        else
          comboBox_NewPowerDbm.SelectedIndex = powerdBm;
        textBox_ComAdr.Text = Convert.ToString(fComAdr, 16).PadLeft(2, '0');
        textBox_NewComAdr.Text = Convert.ToString(fComAdr, 16).PadLeft(2, '0');
        textBox_ScanTime.Text = Convert.ToString(ScanTime, 10).PadLeft(2, '0') + "*100ms";
        comboBox_NewScanTime.SelectedIndex = ScanTime - 3;
        textBox_PowerDbm.Text = Convert.ToString(powerdBm, 10).PadLeft(2, '0');

        FreBand = Convert.ToByte(((dmaxfre & 0xc0) >> 4) | (dminfre >> 6));
        switch (FreBand)
        {
          case 0:
            {
              radioButton_Band1.Checked = true;
              fdminfre = 902.6 + (dminfre & 0x3F) * 0.4;
              fdmaxfre = 902.6 + (dmaxfre & 0x3F) * 0.4;
            }
            break;
          case 1:
            {
              radioButton_Band2.Checked = true;
              fdminfre = 920.125 + (dminfre & 0x3F) * 0.25;
              fdmaxfre = 920.125 + (dmaxfre & 0x3F) * 0.25;
            }
            break;
          case 2:
            {
              radioButton_Band3.Checked = true;
              fdminfre = 902.75 + (dminfre & 0x3F) * 0.5;
              fdmaxfre = 902.75 + (dmaxfre & 0x3F) * 0.5;
            }
            break;
          case 3:
            {
              radioButton_Band4.Checked = true;
              fdminfre = 917.1 + (dminfre & 0x3F) * 0.2;
              fdmaxfre = 917.1 + (dmaxfre & 0x3F) * 0.2;
            }
            break;
          case 4:
            {
              radioButton_Band5.Checked = true;
              fdminfre = 865.1 + (dminfre & 0x3F) * 0.2;
              fdmaxfre = 865.1 + (dmaxfre & 0x3F) * 0.2;
            }
            break;
        }
        textBox_MinFre.Text = Convert.ToString(fdminfre) + "MHz";
        textBox_MaxFre.Text = Convert.ToString(fdmaxfre) + "MHz";
        if (fdmaxfre != fdminfre)
          CheckBox_SameFre.Checked = false;
        comboBox_NewMinFre.SelectedIndex = dminfre & 0x3F;
        comboBox_NewMaxFre.SelectedIndex = dmaxfre & 0x3F;
        if (ReaderType == 0x08)
          textBox_Type.Text = "UHFReader09";
        if ((TrType[0] & 0x02) == 0x02) //第二个字节低第四位代表支持的协议“ISO/IEC 15693”
        {
          ISO180006B.Checked = true;
          EPCC1G2.Checked = true;
        }
        else
        {
          ISO180006B.Checked = false;
          EPCC1G2.Checked = false;
        }
      }
      // AddCmdLog("GetReaderInformation", "获取读写器信息", fCmdRet);
    }
    private async void button_OpenPort_Click(object sender, EventArgs e)
    {
      button_OpenPort.Enabled = false;
      int port = 0;
      int openresult = 30;
      string temp;
      byte comAdr = Convert.ToByte(textBox_ComAddr.Text == "" ? "FF" : textBox_ComAddr.Text, 16);
      byte baud = Convert.ToByte(comboBox_baud.SelectedIndex);
      if (baud > 2) baud = Convert.ToByte(baud + 2);

      try
      {
        if (comboBox_COM.SelectedIndex == 0)
        {
          openresult = await Task.Run(() =>
          {
            return StaticClassReaderB.AutoOpenComPort(ref port, ref comAdr, baud, ref PortHandle);
          });

          fOpenComIndex = PortHandle;
          fComAdr = comAdr;

          if (openresult == 0)
          {
            ComOpen = true;
            comboBox_baud.SelectedIndex = baud > 3 ? Convert.ToInt32(baud - 2) : Convert.ToInt32(baud);
            GetReaderInfo();

            if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
            {
              MessageBox.Show("串口通讯错误", "信息提示");
              StaticClassReaderB.CloseSpecComPort(PortHandle);
              ComOpen = false;
            }
          }
        }
        else
        {
          temp = comboBox_COM.SelectedItem.ToString().Trim();
          port = Convert.ToInt32(temp.Substring(3));

          openresult = await Task.Run(() =>
          {
            for (int i = 6; i >= 0; i--)
            {
              byte tryBaud = Convert.ToByte(i);
              if (tryBaud == 3) continue;
              int result = StaticClassReaderB.OpenComPort(port, ref comAdr, tryBaud, ref PortHandle);
              if (result == 0x35) return result;
              if (result == 0)
              {
                fBaud = tryBaud;
                return result;
              }
            }
            return 30;
          });

          fOpenComIndex = PortHandle;
          fComAdr = comAdr;

          if (openresult == 0x35)
          {
            MessageBox.Show("串口已打开", "信息提示");
            return;
          }

          if (openresult == 0)
          {
            ComOpen = true;
            GetReaderInfo();
            comboBox_baud.SelectedIndex = fBaud > 3 ? Convert.ToInt32(fBaud - 2) : Convert.ToInt32(fBaud);

            if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
            {
              ComOpen = false;
              MessageBox.Show("串口通讯错误", "信息提示");
              StaticClassReaderB.CloseSpecComPort(PortHandle);
              return;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("操作失败: " + ex.Message, "错误");
      }
      finally
      {
        UpdatePortStatus(openresult);
        button_OpenPort.Enabled = true;
      }
    }

    private void UpdatePortStatus(int openresult)
    {
      if (openresult == 0 && fOpenComIndex != -1)
      {
        comboBox_AlreadyOpenPort.Items.Add("COM" + Convert.ToString(fOpenComIndex));
        comboBox_AlreadyOpenPort.SelectedIndex = comboBox_AlreadyOpenPort.Items.Count - 1;
        button1.Enabled = true;
        button2.Enabled = true;
        button3.Enabled = true;
        ComOpen = true;
      }
      else if (openresult == 0x35)
      {
        MessageBox.Show("串口已打开", "信息提示");
      }
      else if (openresult == 0x30 || fOpenComIndex == -1)
      {
        MessageBox.Show("串口通讯错误", "信息提示");
      }

      if (comboBox_AlreadyOpenPort.Items.Count != 0 && fOpenComIndex != -1 && openresult == 0)
      {
        fComAdr = Convert.ToByte(textBox_ComAdr.Text == "" ? "FF" : textBox_ComAdr.Text, 16);
        string temp = comboBox_AlreadyOpenPort.SelectedItem.ToString();
        PortHandle = Convert.ToInt32(temp.Substring(3));
      }
      RefreshStatus();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      GetReaderInfo();
    }



    private void radioButton_Band1_CheckedChanged(object sender, EventArgs e)
    {
      int i;
      comboBox_NewMaxFre.Items.Clear();
      comboBox_NewMinFre.Items.Clear();
      for (i = 0; i < 63; i++)
      {
        comboBox_NewMinFre.Items.Add(Convert.ToString(902.6 + i * 0.4) + " MHz");
        comboBox_NewMaxFre.Items.Add(Convert.ToString(902.6 + i * 0.4) + " MHz");
      }
      comboBox_NewMaxFre.SelectedIndex = 62;
      comboBox_NewMinFre.SelectedIndex = 0;
    }

    private void radioButton_Band2_CheckedChanged(object sender, EventArgs e)
    {
      int i;
      comboBox_NewMaxFre.Items.Clear();
      comboBox_NewMinFre.Items.Clear();
      for (i = 0; i < 20; i++)
      {
        comboBox_NewMinFre.Items.Add(Convert.ToString(920.125 + i * 0.25) + " MHz");
        comboBox_NewMaxFre.Items.Add(Convert.ToString(920.125 + i * 0.25) + " MHz");
      }
      comboBox_NewMaxFre.SelectedIndex = 19;
      comboBox_NewMinFre.SelectedIndex = 0;
    }

    private void radioButton_Band3_CheckedChanged(object sender, EventArgs e)
    {
      int i;
      comboBox_NewMaxFre.Items.Clear();
      comboBox_NewMinFre.Items.Clear();
      for (i = 0; i < 50; i++)
      {
        comboBox_NewMinFre.Items.Add(Convert.ToString(902.75 + i * 0.5) + " MHz");
        comboBox_NewMaxFre.Items.Add(Convert.ToString(902.75 + i * 0.5) + " MHz");
      }
      comboBox_NewMaxFre.SelectedIndex = 49;
      comboBox_NewMinFre.SelectedIndex = 0;
    }

    private void radioButton_Band4_CheckedChanged(object sender, EventArgs e)
    {
      int i;
      comboBox_NewMaxFre.Items.Clear();
      comboBox_NewMinFre.Items.Clear();
      for (i = 0; i < 32; i++)
      {
        comboBox_NewMinFre.Items.Add(Convert.ToString(917.1 + i * 0.2) + " MHz");
        comboBox_NewMaxFre.Items.Add(Convert.ToString(917.1 + i * 0.2) + " MHz");
      }
      comboBox_NewMaxFre.SelectedIndex = 31;
      comboBox_NewMinFre.SelectedIndex = 0;
    }

    private void radioButton_Band5_CheckedChanged(object sender, EventArgs e)
    {
      int i;
      comboBox_NewMaxFre.Items.Clear();
      comboBox_NewMinFre.Items.Clear();
      for (i = 0; i < 15; i++)
      {
        comboBox_NewMinFre.Items.Add(Convert.ToString(865.1 + i * 0.2) + " MHz");
        comboBox_NewMaxFre.Items.Add(Convert.ToString(865.1 + i * 0.2) + " MHz");
      }
      comboBox_NewMaxFre.SelectedIndex = 14;
      comboBox_NewMinFre.SelectedIndex = 0;
    }
    private string GetReturnCodeDesc(int cmdRet)
    {
      switch (cmdRet)
      {
        case 0x00:
          return "操作成功";
        case 0x01:
          return "询查时间结束前返回";
        case 0x02:
          return "指定的询查时间溢出";
        case 0x03:
          return "本条消息之后，还有消息";
        case 0x04:
          return "读写模块存储空间已满";
        case 0x05:
          return "访问密码错误";
        case 0x09:
          return "销毁密码错误";
        case 0x0a:
          return "销毁密码不能为全0";
        case 0x0b:
          return "电子标签不支持该命令";
        case 0x0c:
          return "对该命令，访问密码不能为全0";
        case 0x0d:
          return "电子标签已经被设置了读保护，不能再次设置";
        case 0x0e:
          return "电子标签没有被设置读保护，不需要解锁";
        case 0x10:
          return "有字节空间被锁定，写入失败";
        case 0x11:
          return "不能锁定";
        case 0x12:
          return "已经锁定，不能再次锁定";
        case 0x13:
          return "参数保存失败,但设置的值在读写模块断电前有效";
        case 0x14:
          return "无法调整";
        case 0x15:
          return "询查时间结束前返回";
        case 0x16:
          return "指定的询查时间溢出";
        case 0x17:
          return "本条消息之后，还有消息";
        case 0x18:
          return "读写模块存储空间已满";
        case 0x19:
          return "电子不支持该命令或者访问密码不能为0";
        case 0xFA:
          return "有电子标签，但通信不畅，无法操作";
        case 0xFB:
          return "无电子标签可操作";
        case 0xFC:
          return "电子标签返回错误代码";
        case 0xFD:
          return "命令长度错误";
        case 0xFE:
          return "不合法的命令";
        case 0xFF:
          return "参数错误";
        case 0x30:
          return "通讯错误";
        case 0x31:
          return "CRC校验错误";
        case 0x32:
          return "返回数据长度有错误";
        case 0x33:
          return "通讯繁忙，设备正在执行其他指令";
        case 0x34:
          return "繁忙，指令正在执行";
        case 0x35:
          return "端口已打开";
        case 0x36:
          return "端口已关闭";
        case 0x37:
          return "无效句柄";
        case 0x38:
          return "无效端口";
        case 0xEE:
          return "返回指令错误";
        default:
          return "";
      }
    }
    private string GetErrorCodeDesc(int cmdRet)
    {
      switch (cmdRet)
      {
        case 0x00:
          return "其它错误";
        case 0x03:
          return "存储器超限或不被支持的PC值";
        case 0x04:
          return "存储器锁定";
        case 0x0b:
          return "电源不足";
        case 0x0f:
          return "非特定错误";
        default:
          return "";
      }
    }

    private byte[] HexStringToByteArray(string s)
    {
      s = s.Replace(" ", "");
      byte[] buffer = new byte[s.Length / 2];
      for (int i = 0; i < s.Length; i += 2)
        buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
      return buffer;
    }

    private string ByteArrayToHexString(byte[] data)
    {
      StringBuilder sb = new StringBuilder(data.Length * 3);
      foreach (byte b in data)
        sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
      return sb.ToString().ToUpper();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      byte aNewComAdr, powerDbm, dminfre, dmaxfre, scantime, band = 0;
      string returninfo = "";
      string returninfoDlg = "";
      string setinfo;
      if (radioButton_Band1.Checked)
        band = 0;
      if (radioButton_Band2.Checked)
        band = 1;
      if (radioButton_Band3.Checked)
        band = 2;
      if (radioButton_Band4.Checked)
        band = 3;
      if (radioButton_Band5.Checked)
        band = 4;
      if (textBox_NewComAdr.Text == "")
        return;
      //progressBar1.Visible = true;
      //progressBar1.Minimum = 0;
      dminfre = Convert.ToByte(((band & 3) << 6) | (comboBox_NewMinFre.SelectedIndex & 0x3F));
      dmaxfre = Convert.ToByte(((band & 0x0c) << 4) | (comboBox_NewMaxFre.SelectedIndex & 0x3F));
      aNewComAdr = Convert.ToByte(textBox_NewComAdr.Text);
      powerDbm = Convert.ToByte(comboBox_NewPowerDbm.SelectedIndex);
      fBaud = Convert.ToByte(comboBox_NewBaud.SelectedIndex);
      if (fBaud > 2)
        fBaud = Convert.ToByte(fBaud + 2);
      scantime = Convert.ToByte(comboBox_NewScanTime.SelectedIndex + 3);
      setinfo = "写";
      //progressBar1.Value = 10;
      fCmdRet = StaticClassReaderB.WriteComAdr(ref fComAdr, ref aNewComAdr, PortHandle);
      if (fCmdRet == 0x13)
        fComAdr = aNewComAdr;
      if (fCmdRet == 0)
      {
        fComAdr = aNewComAdr;
        returninfo = returninfo + setinfo + "读写器地址成功";
      }
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + setinfo + "读写器地址返回指令错误";
      else
      {
        returninfo = returninfo + setinfo + "读写器地址失败";
        returninfoDlg = returninfoDlg + setinfo + "读写器地址失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }
      //progressBar1.Value = 25;
      fCmdRet = StaticClassReaderB.SetPowerDbm(ref fComAdr, powerDbm, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",功率成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",功率返回指令错误";
      else
      {
        returninfo = returninfo + ",功率失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "功率失败指令返回=0x"
             + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      // progressBar1.Value = 40;
      fCmdRet = StaticClassReaderB.Writedfre(ref fComAdr, ref dmaxfre, ref dminfre, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",频率成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",频率返回指令错误";
      else
      {
        returninfo = returninfo + ",频率失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "频率失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }
      //progressBar1.Value = 55;
      fCmdRet = StaticClassReaderB.Writebaud(ref fComAdr, ref fBaud, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",波特率成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",波特率返回指令错误";
      else
      {
        returninfo = returninfo + ",波特率失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "波特率失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      // progressBar1.Value = 70;
      fCmdRet = StaticClassReaderB.WriteScanTime(ref fComAdr, ref scantime, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",询查时间成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",询查时间返回指令错误";
      else
      {
        returninfo = returninfo + ",询查时间失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "询查时间失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      //progressBar1.Value = 100;

      GetReaderInfo();
      //progressBar1.Visible = false;
      statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString() + returninfo;
      if (returninfoDlg != "")
        MessageBox.Show(returninfoDlg, "提示");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      byte aNewComAdr, powerDbm, dminfre, dmaxfre, scantime;
      string returninfo = "";
      string returninfoDlg = "";
      string setinfo;

      dminfre = 0;
      dmaxfre = 62;
      aNewComAdr = 0x00;
      powerDbm = 13;
      fBaud = 5;
      scantime = 10;
      setinfo = " 恢复 ";
      comboBox_NewBaud.SelectedIndex = 3;

      fCmdRet = StaticClassReaderB.WriteComAdr(ref fComAdr, ref aNewComAdr, PortHandle);
      if (fCmdRet == 0x13)
        fComAdr = aNewComAdr;
      if (fCmdRet == 0)
      {
        fComAdr = aNewComAdr;
        returninfo = returninfo + setinfo + "读写器地址成功";
      }
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + setinfo + "读写器地址返回指令错误";
      else
      {
        returninfo = returninfo + setinfo + "读写器地址失败";
        returninfoDlg = returninfoDlg + setinfo + "读写器地址失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      fCmdRet = StaticClassReaderB.SetPowerDbm(ref fComAdr, powerDbm, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",功率成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",功率返回指令错误";
      else
      {
        returninfo = returninfo + ",功率失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "功率失败指令返回=0x"
             + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      fCmdRet = StaticClassReaderB.Writedfre(ref fComAdr, ref dmaxfre, ref dminfre, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",频率成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",频率返回指令错误";
      else
      {
        returninfo = returninfo + ",频率失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "频率失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      fCmdRet = StaticClassReaderB.Writebaud(ref fComAdr, ref fBaud, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",波特率成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",波特率返回指令错误";
      else
      {
        returninfo = returninfo + ",波特率失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "波特率失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      fCmdRet = StaticClassReaderB.WriteScanTime(ref fComAdr, ref scantime, PortHandle);
      if (fCmdRet == 0)
        returninfo = returninfo + ",询查时间成功";
      else if (fCmdRet == 0xEE)
        returninfo = returninfo + ",询查时间返回指令错误";
      else
      {
        returninfo = returninfo + ",询查时间失败";
        returninfoDlg = returninfoDlg + " " + setinfo + "询查时间失败指令返回=0x"
         + Convert.ToString(fCmdRet) + "(" + GetReturnCodeDesc(fCmdRet) + ")";
      }

      GetReaderInfo();
      statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString() + returninfo;
      if (returninfoDlg != "")
        MessageBox.Show(returninfoDlg, "提示");
    }

    public void ChangeSubItem(ListViewItem ListItem, int subItemIndex, string ItemText)
    {
      if (subItemIndex == 1)
      {
        if (ItemText == "")
        {
          ListItem.SubItems[subItemIndex].Text = ItemText;
          if (ListItem.SubItems[subItemIndex + 2].Text == "")
          {
            ListItem.SubItems[subItemIndex + 2].Text = "1";
          }
          else
          {
            ListItem.SubItems[subItemIndex + 2].Text = Convert.ToString(Convert.ToInt32(ListItem.SubItems[subItemIndex + 2].Text) + 1);
          }
        }
        else
            if (ListItem.SubItems[subItemIndex].Text != ItemText)
        {
          ListItem.SubItems[subItemIndex].Text = ItemText;
          ListItem.SubItems[subItemIndex + 2].Text = "1";
        }
        else
        {
          ListItem.SubItems[subItemIndex + 2].Text = Convert.ToString(Convert.ToInt32(ListItem.SubItems[subItemIndex + 2].Text) + 1);
          if ((Convert.ToUInt32(ListItem.SubItems[subItemIndex + 2].Text) > 9999))
            ListItem.SubItems[subItemIndex + 2].Text = "1";
        }

      }
      if (subItemIndex == 2)
      {
        if (ListItem.SubItems[subItemIndex].Text != ItemText)
        {
          ListItem.SubItems[subItemIndex].Text = ItemText;
        }
      }

    }
    private void Inventory()
    {
      int i;
      int CardNum = 0;
      int Totallen = 0;
      int EPClen, m;
      byte[] EPC = new byte[5000];
      int CardIndex;
      string temps;
      string s, sEPC;
      bool isonlistview;
      fIsInventoryScan = true;
      ListViewItem aListItem = new ListViewItem();
      byte AdrTID = 0;
      byte LenTID = 0;
      byte TIDFlag = 0;

      bool checkBoxTidChecked = false;
      string textBox4Text = "";
      string textBox5Text = "";

      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          checkBoxTidChecked = CheckBox_TID.Checked;
          textBox4Text = textBox4.Text;
          textBox5Text = textBox5.Text;
        }));
      }
      else
      {
        checkBoxTidChecked = CheckBox_TID.Checked;
        textBox4Text = textBox4.Text;
        textBox5Text = textBox5.Text;
      }

      if (checkBoxTidChecked)
      {
        AdrTID = Convert.ToByte(textBox4Text, 16);
        LenTID = Convert.ToByte(textBox5Text, 16);
        TIDFlag = 1;
      }
      else
      {
        AdrTID = 0;
        LenTID = 0;
        TIDFlag = 0;
      }

      fCmdRet = StaticClassReaderB.Inventory_G2(ref fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, PortHandle);

      if ((fCmdRet == 1) | (fCmdRet == 2) | (fCmdRet == 3) | (fCmdRet == 4) | (fCmdRet == 0xFB))
      {
        byte[] daw = new byte[Totallen];
        Array.Copy(EPC, daw, Totallen);
        temps = ByteArrayToHexString(daw);
        fInventory_EPC_List = temps;
        m = 0;

        if (CardNum == 0)
        {
          fIsInventoryScan = false;
          return;
        }

        List<string> epcList = new List<string>();
        for (CardIndex = 0; CardIndex < CardNum; CardIndex++)
        {
          EPClen = daw[m];
          sEPC = temps.Substring(m * 2 + 2, EPClen * 2);
          m = m + EPClen + 1;
          if (sEPC.Length != EPClen * 2)
            return;
          epcList.Add(sEPC);
        }

        UpdateUIWithEPCs(epcList, checkBoxTidChecked);
      }

      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          if (!checkBoxTidChecked && comboBox_EPC2.Items.Count != 0)
          {
            comboBox_EPC2.SelectedIndex = 0;
          }
        }));
      }
      else
      {
        if (!checkBoxTidChecked && comboBox_EPC2.Items.Count != 0)
        {
          comboBox_EPC2.SelectedIndex = 0;
        }
      }

      fIsInventoryScan = false;
      if (fAppClosed)
      {
        if (this.InvokeRequired)
        {
          this.Invoke(new Action(() => Close()));
        }
        else
        {
          Close();
        }
      }
    }

    private void UpdateUIWithEPCs(List<string> epcList, bool checkBoxTidChecked)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() => UpdateUIWithEPCs(epcList, checkBoxTidChecked)));
        return;
      }

      foreach (string sEPC in epcList)
      {
        bool isonlistview = false;
        ListViewItem aListItem = null;

        for (int i = 0; i < listView1_EPC.Items.Count; i++)
        {
          if (sEPC == listView1_EPC.Items[i].SubItems[1].Text)
          {
            aListItem = listView1_EPC.Items[i];
            ChangeSubItem(aListItem, 1, sEPC);
            isonlistview = true;
            break;
          }
        }

        if (!isonlistview)
        {
          aListItem = listView1_EPC.Items.Add((listView1_EPC.Items.Count + 1).ToString());
          aListItem.SubItems.Add("");
          aListItem.SubItems.Add("");
          aListItem.SubItems.Add("");
          ChangeSubItem(aListItem, 1, sEPC);
          string s = (sEPC.Length / 2).ToString().PadLeft(2, '0');
          ChangeSubItem(aListItem, 2, s);

          if (!checkBoxTidChecked)
          {
            if (comboBox_EPC2.Items.IndexOf(sEPC) == -1)
            {
              comboBox_EPC2.Items.Add(sEPC);
            }
          }
        }
      }
    }
    private async void Timer_Test__Tick(object sender, EventArgs e)
    {
      if (fIsInventoryScan)
        return;
      await Task.Run(() => Inventory());
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (CheckBox_TID.Checked)
      {
        if ((textBox4.Text.Length) != 2 || ((textBox5.Text.Length) != 2))
        {
          statusStrip1.Items[0].Text = "TID询查参数错误！";
          return;
        }
      }
      Timer_Test_.Enabled = !Timer_Test_.Enabled;
      if (!Timer_Test_.Enabled)
      {
        textBox4.Enabled = true;
        textBox5.Enabled = true;
        CheckBox_TID.Enabled = true;
        if (listView1_EPC.Items.Count != 0)
        {
          /*
          DestroyCode.Enabled = false;
          AccessCode.Enabled = false;
          NoProect.Enabled = false;
          Proect.Enabled = false;
          Always.Enabled = false;
          AlwaysNot.Enabled = false;
          NoProect2.Enabled = true;
          Proect2.Enabled = true;
          Always2.Enabled = true;
          AlwaysNot2.Enabled = true;
          P_Reserve.Enabled = true;
          P_EPC.Enabled = true;
          P_TID.Enabled = true;
          P_User.Enabled = true;
          Button_DestroyCard.Enabled = true;
          Button_SetReadProtect_G2.Enabled = true;
          Button_SetEASAlarm_G2.Enabled = true;
          Alarm_G2.Enabled = true;
          NoAlarm_G2.Enabled = true;
          Button_LockUserBlock_G2.Enabled = true;
          Button_WriteEPC_G2.Enabled = true;
          Button_SetMultiReadProtect_G2.Enabled = true;
          Button_RemoveReadProtect_G2.Enabled = true;
          Button_CheckReadProtected_G2.Enabled = true;
          button4.Enabled = true;
          SpeedButton_Read_G2.Enabled = true;
          Button_SetProtectState.Enabled = true;
          Button_DataWrite.Enabled = true;
          BlockWrite.Enabled = true;
          Button_BlockErase.Enabled = true;
          checkBox1.Enabled = true;
          */
        }
        if (listView1_EPC.Items.Count == 0)
        {
          /*
          DestroyCode.Enabled = false;
          AccessCode.Enabled = false;
          NoProect.Enabled = false;
          Proect.Enabled = false;
          Always.Enabled = false;
          AlwaysNot.Enabled = false;
          NoProect2.Enabled = false;
          Proect2.Enabled = false;
          Always2.Enabled = false;
          AlwaysNot2.Enabled = false;
          P_Reserve.Enabled = false;
          P_EPC.Enabled = false;
          P_TID.Enabled = false;
          P_User.Enabled = false;
          Button_DestroyCard.Enabled = false;
          Button_SetReadProtect_G2.Enabled = false;
          Button_SetEASAlarm_G2.Enabled = false;
          Alarm_G2.Enabled = false;
          NoAlarm_G2.Enabled = false;
          Button_LockUserBlock_G2.Enabled = false;
          SpeedButton_Read_G2.Enabled = false;
          Button_DataWrite.Enabled = false;
          BlockWrite.Enabled = false;
          Button_BlockErase.Enabled = false;
          Button_WriteEPC_G2.Enabled = true;
          Button_SetMultiReadProtect_G2.Enabled = true;
          Button_RemoveReadProtect_G2.Enabled = true;
          Button_CheckReadProtected_G2.Enabled = true;
          button4.Enabled = true;
          Button_SetProtectState.Enabled = false;
          checkBox1.Enabled = false;
          */

        }
        //AddCmdLog("Inventory", "退出询查", 0);
        button4.Text = "查询标签";
      }
      else
      {
        textBox4.Enabled = false;
        textBox5.Enabled = false;
        CheckBox_TID.Enabled = false;
        /*
        DestroyCode.Enabled = false;
        AccessCode.Enabled = false;
        NoProect.Enabled = false;
        Proect.Enabled = false;
        Always.Enabled = false;
        AlwaysNot.Enabled = false;
        NoProect2.Enabled = false;
        Proect2.Enabled = false;
        Always2.Enabled = false;
        AlwaysNot2.Enabled = false;
        P_Reserve.Enabled = false;
        P_EPC.Enabled = false;
        P_TID.Enabled = false;
        P_User.Enabled = false;
        Button_WriteEPC_G2.Enabled = false;
        Button_SetMultiReadProtect_G2.Enabled = false;
        Button_RemoveReadProtect_G2.Enabled = false;
        Button_CheckReadProtected_G2.Enabled = false;
        button4.Enabled = false;

        Button_DestroyCard.Enabled = false;
        Button_SetReadProtect_G2.Enabled = false;
        Button_SetEASAlarm_G2.Enabled = false;
        Alarm_G2.Enabled = false;
        NoAlarm_G2.Enabled = false;
        Button_LockUserBlock_G2.Enabled = false;
        SpeedButton_Read_G2.Enabled = false;
        Button_DataWrite.Enabled = false;
        BlockWrite.Enabled = false;
        Button_BlockErase.Enabled = false;
        Button_SetProtectState.Enabled = false;
        */
        listView1_EPC.Items.Clear();
        /*
        ComboBox_EPC1.Items.Clear();
        ComboBox_EPC2.Items.Clear();
        ComboBox_EPC3.Items.Clear();
        ComboBox_EPC4.Items.Clear();
        ComboBox_EPC5.Items.Clear();
        ComboBox_EPC6.Items.Clear();
         */
        button4.Text = "停止";
        //checkBox1.Enabled = false;
      }
    }

    private void Timer_G2_Read_Tick(object sender, EventArgs e)
    {
      if (fIsInventoryScan)
        return;
      fIsInventoryScan = true;
      byte WordPtr, ENum;
      byte Num = 0;
      byte Mem = 0;
      byte EPClength = 0;
      string str;
      byte[] CardData = new byte[320];
      if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == ""))
      {
        fIsInventoryScan = false;
        return;
      }
      if (checkBox1.Checked)
        MaskFlag = 1;
      else
        MaskFlag = 0;
      Maskadr = Convert.ToByte(maskadr_textbox.Text, 16);
      MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
      if (textBox1.Text == "")
      {
        fIsInventoryScan = false;
        return;
      }
      if (comboBox_EPC2.Items.Count == 0)
      {
        fIsInventoryScan = false;
        return;
      }
      if (comboBox_EPC2.SelectedItem == null)
      {
        fIsInventoryScan = false;
        return;
      }
      str = comboBox_EPC2.SelectedItem.ToString();
      ENum = Convert.ToByte(str.Length / 4);
      EPClength = Convert.ToByte(str.Length / 2);
      byte[] EPC = new byte[ENum];
      EPC = HexStringToByteArray(str);
      if (C_Reserve.Checked)
        Mem = 0;
      if (C_EPC.Checked)
        Mem = 1;
      if (C_TID.Checked)
        Mem = 2;
      if (C_User.Checked)
        Mem = 3;
      if (Edit_AccessCode2.Text == "")
      {
        fIsInventoryScan = false;
        return;
      }
      if (Edit_WordPtr.Text == "")
      {
        fIsInventoryScan = false;
        return;
      }
      WordPtr = Convert.ToByte(Edit_WordPtr.Text, 16);
      Num = Convert.ToByte(textBox1.Text);
      if (Edit_AccessCode2.Text.Length != 8)
      {
        fIsInventoryScan = false;
        return;
      }
      fPassWord = HexStringToByteArray(Edit_AccessCode2.Text);
      fCmdRet = StaticClassReaderB.ReadCard_G2(ref fComAdr, EPC, Mem, WordPtr, Num, fPassWord, Maskadr, MaskLen, MaskFlag, CardData, EPClength, ref ferrorcode, PortHandle);
      if (fCmdRet == 0)
      {
        byte[] daw = new byte[Num * 2];
        Array.Copy(CardData, daw, Num * 2);
        listBox1.Items.Add(ByteArrayToHexString(daw));
        listBox1.SelectedIndex = listBox1.Items.Count - 1;
        //AddCmdLog("ReadData", "读", fCmdRet);
      }
      if (ferrorcode != -1)
      {
        statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString() +
        " '读' 返回错误=0x" + Convert.ToString(ferrorcode, 2) +
        "(" + GetErrorCodeDesc(ferrorcode) + ")";
        ferrorcode = -1;
      }
      fIsInventoryScan = false;
      if (fAppClosed)
        Close();
    }

    private void Button_DataWrite_Click(object sender, EventArgs e)
    {
      byte WordPtr, ENum;
      byte Num = 0;
      byte Mem = 0;
      byte WNum = 0;
      byte EPClength = 0;
      byte Writedatalen = 0;
      int WrittenDataNum = 0;
      string s2, str;
      byte[] CardData = new byte[320];
      byte[] writedata = new byte[230];
      if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == ""))
      {
        return;
      }
      if (checkBox1.Checked)
        MaskFlag = 1;
      else
        MaskFlag = 0;
      Maskadr = Convert.ToByte(maskadr_textbox.Text, 16);
      MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
      if (comboBox_EPC2.Items.Count == 0)
        return;
      if (comboBox_EPC2.SelectedItem == null)
        return;
      str = comboBox_EPC2.SelectedItem.ToString();
      ENum = Convert.ToByte(str.Length / 4);
      EPClength = Convert.ToByte(ENum * 2);
      byte[] EPC = new byte[ENum];
      EPC = HexStringToByteArray(str);
      if (C_Reserve.Checked)
        Mem = 0;
      if (C_EPC.Checked)
        Mem = 1;
      if (C_TID.Checked)
        Mem = 2;
      if (C_User.Checked)
        Mem = 3;
      if (Edit_WordPtr.Text == "")
      {
        MessageBox.Show("起始地址为空", "信息提示");
        return;
      }
      if (textBox1.Text == "")
      {
        MessageBox.Show("读/块擦除长度", "信息提示");
        return;
      }
      //if (Convert.ToInt32(Edit_WordPtr.Text) + Convert.ToInt32(textBox1.Text) > 120)
      //return;
      if (Edit_AccessCode2.Text == "")
      {
        return;
      }
      WordPtr = Convert.ToByte(Edit_WordPtr.Text, 16);
      Num = Convert.ToByte(textBox1.Text);
      if (Edit_AccessCode2.Text.Length != 8)
      {
        return;
      }
      fPassWord = HexStringToByteArray(Edit_AccessCode2.Text);
      if (Edit_WriteData.Text == "")
        return;
      s2 = Edit_WriteData.Text;
      if (s2.Length % 4 != 0)
      {
        MessageBox.Show("以字为单位输入.", "写");
        return;
      }
      WNum = Convert.ToByte(s2.Length / 4);
      byte[] Writedata = new byte[WNum * 2];
      Writedata = HexStringToByteArray(s2);
      Writedatalen = Convert.ToByte(WNum * 2);
      if ((checkBox_pc.Checked) && (C_EPC.Checked))
      {
        WordPtr = 1;
        Writedatalen = Convert.ToByte(Edit_WriteData.Text.Length / 2 + 2);
        Writedata = HexStringToByteArray(textBox_pc.Text + Edit_WriteData.Text);
      }
      fCmdRet = StaticClassReaderB.WriteCard_G2(ref fComAdr, EPC, Mem, WordPtr, Writedatalen, Writedata, fPassWord, Maskadr, MaskLen, MaskFlag, WrittenDataNum, EPClength, ref ferrorcode, PortHandle);
      //AddCmdLog("Write data", "写", fCmdRet);
      if (fCmdRet == 0)
      {
        statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString() + "‘写EPC”指令返回=0x00" +
          "(写EPC成功)";
      }
    }

    private void button_ClosePort_Click(object sender, EventArgs e)
    {
      int port;
      string temp;
      ClearLastInfo();
      try
      {
        if (comboBox_AlreadyOpenPort.SelectedIndex < 0)
        {
          MessageBox.Show("请选择要关闭的端口", "信息提示");
        }
        else
        {
          temp = comboBox_AlreadyOpenPort.SelectedItem.ToString();
          port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
          fCmdRet = StaticClassReaderB.CloseSpecComPort(port);
          if (fCmdRet == 0)
          {
            comboBox_AlreadyOpenPort.Items.RemoveAt(0);
            if (comboBox_AlreadyOpenPort.Items.Count != 0)
            {
              temp = comboBox_AlreadyOpenPort.SelectedItem.ToString();
              port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
              StaticClassReaderB.CloseSpecComPort(port);
              fComAdr = 0xFF;
              StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref PortHandle);
              fOpenComIndex = PortHandle;
              RefreshStatus();
              GetReaderInfo(); //自动执行读取写卡器信息
            }
          }
          else
            MessageBox.Show("串口通讯错误", "信息提示");
        }
      }
      finally
      {

      }
      if (comboBox_AlreadyOpenPort.Items.Count != 0)
        comboBox_AlreadyOpenPort.SelectedIndex = 0;
      else
      {
        fOpenComIndex = -1;
        comboBox_AlreadyOpenPort.Items.Clear();
        comboBox_AlreadyOpenPort.Refresh();
        RefreshStatus();
        button3.Enabled = false;
        button1.Enabled = false;
        button2.Enabled = false;
        ComOpen = false;
      }
    }

    private void SpeedButton_Read_G2_Click(object sender, EventArgs e)
    {
      if (Edit_WordPtr.Text == "")
      {
        MessageBox.Show("起始地址为空", "信息提示");
        return;
      }
      if (textBox1.Text == "")
      {
        MessageBox.Show("读/块擦除长度", "信息提示");
        return;
      }
      if (Edit_AccessCode2.Text == "")
      {
        MessageBox.Show("密码为空", "信息提示");
        return;
      }
      if (Convert.ToInt32(Edit_WordPtr.Text, 16) + Convert.ToInt32(textBox1.Text) > 120)
        return;
      Timer_G2_Read.Enabled = !Timer_G2_Read.Enabled;
      if (Timer_G2_Read.Enabled)
      {
        button4.Enabled = false;
        Button_DataWrite.Enabled = false;
        BlockWrite.Enabled = false;
        Button_BlockErase.Enabled = false;
        SpeedButton_Read_G2.Text = "停止";
      }
      else
      {
        if (listView1_EPC.Items.Count != 0)
        {
          button4.Enabled = true;
          Button_DataWrite.Enabled = true;
          BlockWrite.Enabled = true;
          Button_BlockErase.Enabled = true;
        }
        if (listView1_EPC.Items.Count == 0)
        {
          button2.Enabled = true;
          Button_DataWrite.Enabled = false;
          BlockWrite.Enabled = false;
          Button_BlockErase.Enabled = false;
          button4.Enabled = true;

        }
        SpeedButton_Read_G2.Text = "读";
      }
    }

    private void BlockWrite_Click(object sender, EventArgs e)
    {
      byte WordPtr, ENum;
      byte Num = 0;
      byte Mem = 0;
      byte WNum = 0;
      byte EPClength = 0;
      byte Writedatalen = 0;
      int WrittenDataNum = 0;
      string s2, str;
      byte[] CardData = new byte[320];
      byte[] writedata = new byte[230];
      if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == ""))
      {
        fIsInventoryScan = false;
        return;
      }
      if (checkBox1.Checked)
        MaskFlag = 1;
      else
        MaskFlag = 0;
      Maskadr = Convert.ToByte(maskadr_textbox.Text, 16);
      MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
      if (comboBox_EPC2.Items.Count == 0)
        return;
      if (comboBox_EPC2.SelectedItem == null)
        return;
      str = comboBox_EPC2.SelectedItem.ToString();
      if (str == "")
        return;
      ENum = Convert.ToByte(str.Length / 4);
      EPClength = Convert.ToByte(ENum * 2);
      byte[] EPC = new byte[ENum];
      EPC = HexStringToByteArray(str);
      if (C_Reserve.Checked)
        Mem = 0;
      if (C_EPC.Checked)
        Mem = 1;
      if (C_TID.Checked)
        Mem = 2;
      if (C_User.Checked)
        Mem = 3;
      if (Edit_WordPtr.Text == "")
      {
        MessageBox.Show("起始地址为空", "信息提示");
        return;
      }
      if (textBox1.Text == "")
      {
        MessageBox.Show("读/块擦除长度", "信息提示");
        return;
      }
      if (Convert.ToInt32(Edit_WordPtr.Text) + Convert.ToInt32(textBox1.Text) > 120)
        return;
      if (Edit_AccessCode2.Text == "")
      {
        return;
      }
      WordPtr = Convert.ToByte(Edit_WordPtr.Text, 16);
      Num = Convert.ToByte(textBox1.Text);
      if (Edit_AccessCode2.Text.Length != 8)
      {
        return;
      }
      fPassWord = HexStringToByteArray(Edit_AccessCode2.Text);
      if (Edit_WriteData.Text == "")
        return;
      s2 = Edit_WriteData.Text;
      if (s2.Length % 4 != 0)
      {
        MessageBox.Show("以字为单位输入.", "块写");
        return;
      }
      WNum = Convert.ToByte(s2.Length / 4);
      byte[] Writedata = new byte[WNum * 2];
      Writedata = HexStringToByteArray(s2);
      Writedatalen = Convert.ToByte(WNum * 2);
      if ((checkBox_pc.Checked) && (C_EPC.Checked))
      {
        WordPtr = 1;
        Writedatalen = Convert.ToByte(Edit_WriteData.Text.Length / 2 + 2);
        Writedata = HexStringToByteArray(textBox_pc.Text + Edit_WriteData.Text);
      }
      fCmdRet = StaticClassReaderB.WriteBlock_G2(ref fComAdr, EPC, Mem, WordPtr, Writedatalen, Writedata, fPassWord, Maskadr, MaskLen, MaskFlag, WrittenDataNum, EPClength, ref ferrorcode, PortHandle);
      //AddCmdLog("Write Block", "块写", fCmdRet, ferrorcode);
      if (fCmdRet == 0)
      {
        statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString() + "'块写'命令 返回=0x00" +
              "(块写成功)";
      }
    }

    private void Button_BlockErase_Click(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {

    }
  }
}
