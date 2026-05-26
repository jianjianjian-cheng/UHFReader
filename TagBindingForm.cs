using System;
using System.Linq;
using System.Windows.Forms;
using ReaderB;
using UHFReader.BLL;
using UHFReader.Models;
using UHFReader.Common;

namespace UHFReader
{
  public partial class TagBindingForm : Form
  {
    private RfidTagBll _tagBll = new RfidTagBll();
    private MedicineBll _medicineBll = new MedicineBll();
    private bool _isScanning = false;
    private string _lastEpc = "";
    private System.Data.DataTable _scanTagsTable = new System.Data.DataTable();
    private System.Collections.Generic.Dictionary<string, DateTime> _scannedTags = new System.Collections.Generic.Dictionary<string, DateTime>();

    public TagBindingForm()
    {
      InitializeComponent();
    }

    private void TagBindingForm_Load(object sender, EventArgs e)
    {
      InitializeScanTable();
      LoadMedicines();
      LoadTags();
    }

    private void InitializeScanTable()
    {
      if (_scanTagsTable.Columns.Count == 0)
      {
        _scanTagsTable.Columns.Add("EPC", typeof(string));
        _scanTagsTable.Columns.Add("扫描时间", typeof(DateTime));
      }
      dgvScanTags.DataSource = _scanTagsTable;
    }

    private void TagBindingForm_VisibleChanged(object sender, EventArgs e)
    {
      if (this.Visible)
      {
        LoadMedicines();
        LoadTags();
      }
      else
      {
        StopScanning();
      }
    }

    private void LoadMedicines()
    {
      var medicines = _medicineBll.GetAllMedicines();
      cmbMedicine.DataSource = medicines;
      cmbMedicine.DisplayMember = "Name";
      cmbMedicine.ValueMember = "Id";
    }

    private void LoadTags()
    {
      dgvTags.DataSource = _tagBll.GetAllTags();
      SetColumnNames();
    }

    private void SetColumnNames()
    {
      if (dgvTags.Columns["Id"] != null) dgvTags.Columns["Id"].HeaderText = "编号";
      if (dgvTags.Columns["Epc"] != null) dgvTags.Columns["Epc"].HeaderText = "电子标签号";
      if (dgvTags.Columns["Tid"] != null) dgvTags.Columns["Tid"].HeaderText = "标签TID";
      if (dgvTags.Columns["MedicineId"] != null) dgvTags.Columns["MedicineId"].HeaderText = "药品ID";
      if (dgvTags.Columns["Status"] != null) dgvTags.Columns["Status"].HeaderText = "状态";
      if (dgvTags.Columns["BindTime"] != null) dgvTags.Columns["BindTime"].HeaderText = "绑定时间";
      if (dgvTags.Columns["CreateTime"] != null) dgvTags.Columns["CreateTime"].HeaderText = "创建时间";
    }

    private void btnScan_Click(object sender, EventArgs e)
    {
      if (_isScanning)
      {
        StopScanning();
      }
      else
      {
        StartScanning();
      }
    }

    private void StartScanning()
    {
      if (!RfidHelper.IsConnected)
      {
        int port = 0;
        byte comAdr = 0xff;
        byte baud = 5;
        int portHandle = 0;

        int openResult = StaticClassReaderB.AutoOpenComPort(ref port, ref comAdr, baud, ref portHandle);

        if (openResult == 0)
        {
          if (Form1.Instance != null)
          {
            Form1.Instance.SetPortStatus(true, portHandle, comAdr);
          }
          lblPortStatus.Text = $"端口状态: 已连接 (COM{port})";
          lblPortStatus.ForeColor = System.Drawing.Color.LightGreen;
          MessageBox.Show("端口已自动打开！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          MessageBox.Show("请先连接RFID读写器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          lblPortStatus.Text = "端口状态: 未连接";
          lblPortStatus.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
          return;
        }
      }

      _isScanning = true;
      btnScan.Text = "⏹ 停止扫描";
      btnScan.BackColor = System.Drawing.Color.FromArgb(230, 100, 80);
      lblScanStatus.Text = "状态: 扫描中...";
      lblScanStatus.ForeColor = System.Drawing.Color.LightGreen;
      scanTimer.Start();
    }

    private void StopScanning()
    {
      _isScanning = false;
      btnScan.Text = "📡 扫描标签";
      btnScan.BackColor = System.Drawing.Color.FromArgb(70, 180, 100);
      lblScanStatus.Text = "状态: 已停止";
      lblScanStatus.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      scanTimer.Stop();
    }

    private void scanTimer_Tick(object sender, EventArgs e)
    {
      if (!_isScanning) return;

      try
      {
        var epc = RfidHelper.InventorySingleTag();
        if (!string.IsNullOrEmpty(epc) && epc != _lastEpc)
        {
          _lastEpc = epc;
          txtEpc.Text = epc;
          lblScanStatus.Text = $"检测到标签: {epc}";
          lblScanStatus.ForeColor = System.Drawing.Color.LightGreen;

          AddScannedTag(epc);

          var tag = _tagBll.GetTagByEpc(epc);
          if (tag != null && tag.MedicineId.HasValue)
          {
            cmbMedicine.SelectedValue = tag.MedicineId.Value;
            lblScanStatus.Text = $"标签已绑定: {epc}";
            lblScanStatus.ForeColor = System.Drawing.Color.FromArgb(70, 130, 200);
          }
          else
          {
            lblScanStatus.Text = $"新标签: {epc}";
            lblScanStatus.ForeColor = System.Drawing.Color.LightGreen;
          }
        }
      }
      catch (Exception)
      {
        lblScanStatus.Text = "扫描出错";
        lblScanStatus.ForeColor = System.Drawing.Color.LightSalmon;
      }
    }

    private void AddScannedTag(string epc)
    {
      try
      {
        if (_scannedTags.ContainsKey(epc))
        {
          _scannedTags[epc] = DateTime.Now;
          foreach (System.Data.DataRow row in _scanTagsTable.Rows)
          {
            if (row["EPC"].ToString() == epc)
            {
              row["扫描时间"] = DateTime.Now;
              break;
            }
          }
        }
        else
        {
          _scannedTags.Add(epc, DateTime.Now);
          _scanTagsTable.Rows.Add(epc, DateTime.Now);

          if (_scanTagsTable.Rows.Count > 10)
          {
            _scanTagsTable.Rows.RemoveAt(0);
            _scannedTags.Remove(_scannedTags.Keys.First());
          }
        }

        if (dgvScanTags.Columns["扫描时间"] != null)
        {
          dgvScanTags.Sort(dgvScanTags.Columns["扫描时间"], System.ComponentModel.ListSortDirection.Descending);
        }
      }
      catch { }
    }

    private void btnBind_Click(object sender, EventArgs e)
    {
      string epc = txtEpc.Text.Trim();
      if (string.IsNullOrEmpty(epc))
      {
        MessageBox.Show("请输入或扫描EPC！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (cmbMedicine.SelectedValue == null)
      {
        MessageBox.Show("请选择药品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      int medicineId = Convert.ToInt32(cmbMedicine.SelectedValue);
      string tid = txtTid.Text.Trim();

      if (_tagBll.BindTagToMedicine(epc, medicineId, tid))
      {
        MessageBox.Show("绑定成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtEpc.Clear();
        txtTid.Clear();
        _lastEpc = "";
        LoadTags();
      }
      else
      {
        MessageBox.Show("绑定失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      LoadTags();
      LoadMedicines();
      txtEpc.Clear();
      txtTid.Clear();
      _lastEpc = "";
    }

    private void btnOpenPort_Click(object sender, EventArgs e)
    {
      btnOpenPort.Enabled = false;

      try
      {
        if (Form1.Instance != null && Form1.IsConnected)
        {
          MessageBox.Show("端口已打开！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          lblPortStatus.Text = "端口状态: 已连接";
          lblPortStatus.ForeColor = System.Drawing.Color.LightGreen;
          btnOpenPort.Enabled = true;
          return;
        }

        int port = 0;
        int openResult = 30;
        byte comAdr = 0xff;
        byte baud = 5;
        int portHandle = 0;

        openResult = StaticClassReaderB.AutoOpenComPort(ref port, ref comAdr, baud, ref portHandle);

        if (openResult == 0)
        {
          MessageBox.Show("端口打开成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          lblPortStatus.Text = $"端口状态: 已连接 (COM{port})";
          lblPortStatus.ForeColor = System.Drawing.Color.LightGreen;

          if (Form1.Instance != null)
          {
            Form1.Instance.SetPortStatus(true, portHandle, comAdr);
          }
        }
        else
        {
          MessageBox.Show("端口打开失败，请检查设备连接！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
          lblPortStatus.Text = "端口状态: 未连接";
          lblPortStatus.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("打开端口时发生错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        lblPortStatus.Text = "端口状态: 连接错误";
        lblPortStatus.ForeColor = System.Drawing.Color.LightSalmon;
      }
      finally
      {
        btnOpenPort.Enabled = true;
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      StopScanning();
      this.Hide();
    }
  }
}