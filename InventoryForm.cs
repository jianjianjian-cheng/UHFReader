using System;
using System.Windows.Forms;
using UHFReader.BLL;

namespace UHFReader
{
  public partial class InventoryForm : Form
  {
    private InventoryBll _inventoryBll = new InventoryBll();

    public InventoryForm()
    {
      InitializeComponent();
    }

    private void InventoryForm_Load(object sender, EventArgs e)
    {
      LoadInventory();
    }

    private void LoadInventory(string keyword = "")
    {
      dgvInventory.DataSource = _inventoryBll.GetAllInventoryWithMedicine();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      txtSearch.Clear();
      LoadInventory();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      LoadInventory(txtSearch.Text.Trim());
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnSearch_Click(sender, e);
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}