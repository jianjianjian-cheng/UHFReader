using System;
using System.Collections.Generic;
using ReaderB;

namespace UHFReader.Common
{
  public static class RfidHelper
  {
    public static bool IsConnected => Form1.IsConnected;
    public static int PortHandle => Form1.SharedPortHandle;

    public static List<string> InventoryTags()
    {
      var tagList = new List<string>();
      if (!IsConnected || PortHandle < 0) return tagList;

      byte comAdr = Form1.SharedComAdr;
      byte AdrTID = 0;
      byte LenTID = 0;
      byte TIDFlag = 0;
      byte[] EPC = new byte[5000];
      int Totallen = 0;
      int CardNum = 0;

      int fCmdRet = StaticClassReaderB.Inventory_G2(ref comAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, PortHandle);

      if (fCmdRet == 0 && CardNum > 0)
      {
        byte[] daw = new byte[Totallen];
        Array.Copy(EPC, daw, Totallen);
        string temps = System.Text.Encoding.ASCII.GetString(daw);

        int m = 0;
        while (m < CardNum)
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

      return tagList;
    }

    public static string InventorySingleTag()
    {
      var tags = InventoryTags();
      return tags.Count > 0 ? tags[0] : null;
    }
  }
}