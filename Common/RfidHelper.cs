using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ReaderB;

namespace UHFReader.Common
{
  public static class RfidHelper
  {
    public static bool IsConnected => GetComOpen();
    public static int PortHandle => GetPortHandle();

    private static bool GetComOpen()
    {
      foreach (Form form in Application.OpenForms)
      {
        if (form is Form1 rfidForm)
        {
          return rfidForm.ComOpenStatus;
        }
      }
      return false;
    }

    private static int GetPortHandle()
    {
      foreach (Form form in Application.OpenForms)
      {
        if (form is Form1 rfidForm)
        {
          return rfidForm.PortHandleValue;
        }
      }
      return -1;
    }

    private static byte GetComAdr()
    {
      foreach (Form form in Application.OpenForms)
      {
        if (form is Form1 rfidForm)
        {
          return rfidForm.ComAdrValue;
        }
      }
      return 0xff;
    }

    public static List<string> InventoryTags()
    {
      var tagList = new List<string>();
      if (!IsConnected || PortHandle < 0) return tagList;

      byte comAdr = GetComAdr();
      byte AdrTID = 0;
      byte LenTID = 0;
      byte TIDFlag = 0;
      byte[] EPC = new byte[5000];
      int Totallen = 0;
      int CardNum = 0;

      int fCmdRet = StaticClassReaderB.Inventory_G2(ref comAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, PortHandle);

      if ((fCmdRet == 1) || (fCmdRet == 2) || (fCmdRet == 3) || (fCmdRet == 4) || (fCmdRet == 0xFB) || (fCmdRet == 0))
      {
        if (CardNum > 0)
        {
          byte[] daw = new byte[Totallen];
          Array.Copy(EPC, daw, Totallen);
          string temps = ByteArrayToHexString(daw);

          int m = 0;
          for (int cardIndex = 0; cardIndex < CardNum; cardIndex++)
          {
            int EPClen = daw[m];
            string sEPC = temps.Substring(m * 2 + 2, EPClen * 2);
            m = m + EPClen + 1;
            if (sEPC.Length == EPClen * 2 && !string.IsNullOrEmpty(sEPC))
            {
              tagList.Add(sEPC);
            }
          }
        }
      }

      return tagList;
    }

    private static string ByteArrayToHexString(byte[] data)
    {
      string temp = "";
      for (int i = 0; i < data.Length; i++)
      {
        if (data[i] < 16)
          temp += "0" + data[i].ToString("X");
        else
          temp += data[i].ToString("X");
      }
      return temp;
    }

    public static string InventorySingleTag()
    {
      var tags = InventoryTags();
      return tags.Count > 0 ? tags[0] : null;
    }
  }
}