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
      SetColumnNames();
    }

    private void SetColumnNames()
    {
      if (dgvInventory.Columns["Id"] != null) dgvInventory.Columns["Id"].HeaderText = "编号";
      if (dgvInventory.Columns["MedicineId"] != null) dgvInventory.Columns["MedicineId"].HeaderText = "药品ID";
      if (dgvInventory.Columns["Code"] != null) dgvInventory.Columns["Code"].HeaderText = "药品编码";
      if (dgvInventory.Columns["Name"] != null) dgvInventory.Columns["Name"].HeaderText = "药品名称";
      if (dgvInventory.Columns["Specification"] != null) dgvInventory.Columns["Specification"].HeaderText = "规格";
      if (dgvInventory.Columns["Manufacturer"] != null) dgvInventory.Columns["Manufacturer"].HeaderText = "生产厂家";
      if (dgvInventory.Columns["Quantity"] != null) dgvInventory.Columns["Quantity"].HeaderText = "库存数量";
      if (dgvInventory.Columns["UpdateTime"] != null) dgvInventory.Columns["UpdateTime"].HeaderText = "更新时间";
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