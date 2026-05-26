using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UHFReader.BLL;
using UHFReader.Models;

namespace UHFReader
{
  public partial class MedicineForm : Form
  {
    private MedicineBll _medicineBll = new MedicineBll();
    private int _selectedMedicineId = -1;

    public MedicineForm()
    {
      InitializeComponent();
    }

    private void MedicineForm_Load(object sender, EventArgs e)
    {
      LoadMedicines();
    }

    private void LoadMedicines()
    {
      dgvMedicines.DataSource = _medicineBll.GetAllMedicines();
      SetColumnNames();
    }

    private void SetColumnNames()
    {
      if (dgvMedicines.Columns["Id"] != null) dgvMedicines.Columns["Id"].HeaderText = "编号";
      if (dgvMedicines.Columns["Code"] != null) dgvMedicines.Columns["Code"].HeaderText = "药品编码";
      if (dgvMedicines.Columns["Name"] != null) dgvMedicines.Columns["Name"].HeaderText = "药品名称";
      if (dgvMedicines.Columns["Specification"] != null) dgvMedicines.Columns["Specification"].HeaderText = "规格";
      if (dgvMedicines.Columns["Manufacturer"] != null) dgvMedicines.Columns["Manufacturer"].HeaderText = "生产厂家";
      if (dgvMedicines.Columns["Description"] != null) dgvMedicines.Columns["Description"].HeaderText = "描述";
      if (dgvMedicines.Columns["CreateTime"] != null) dgvMedicines.Columns["CreateTime"].HeaderText = "创建时间";
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      string keyword = txtSearch.Text.Trim();
      if (string.IsNullOrEmpty(keyword))
      {
        LoadMedicines();
      }
      else
      {
        dgvMedicines.DataSource = _medicineBll.SearchMedicines(keyword);
        SetColumnNames();
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtName.Text))
      {
        MessageBox.Show("药品编码和名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      var medicine = new Medicine
      {
        Code = txtCode.Text.Trim(),
        Name = txtName.Text.Trim(),
        Specification = txtSpecification.Text.Trim(),
        Manufacturer = txtManufacturer.Text.Trim(),
        Description = txtDescription.Text.Trim()
      };

      if (_medicineBll.AddMedicine(medicine))
      {
        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearInputs();
        LoadMedicines();
      }
      else
      {
        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (_selectedMedicineId == -1)
      {
        MessageBox.Show("请先选择要修改的药品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      var medicine = new Medicine
      {
        Id = _selectedMedicineId,
        Code = txtCode.Text.Trim(),
        Name = txtName.Text.Trim(),
        Specification = txtSpecification.Text.Trim(),
        Manufacturer = txtManufacturer.Text.Trim(),
        Description = txtDescription.Text.Trim()
      };

      if (_medicineBll.UpdateMedicine(medicine))
      {
        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearInputs();
        LoadMedicines();
      }
      else
      {
        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (_selectedMedicineId == -1)
      {
        MessageBox.Show("请先选择要删除的药品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      var result = MessageBox.Show("确定要删除该药品吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        if (_medicineBll.DeleteMedicine(_selectedMedicineId))
        {
          MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          ClearInputs();
          LoadMedicines();
        }
        else
        {
          MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearInputs();
    }

    private void ClearInputs()
    {
      _selectedMedicineId = -1;
      txtCode.Clear();
      txtName.Clear();
      txtSpecification.Clear();
      txtManufacturer.Clear();
      txtDescription.Clear();
    }

    private void dgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var row = dgvMedicines.Rows[e.RowIndex];
        _selectedMedicineId = Convert.ToInt32(row.Cells["Id"].Value);
        txtCode.Text = row.Cells["Code"].Value?.ToString() ?? "";
        txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
        txtSpecification.Text = row.Cells["Specification"].Value?.ToString() ?? "";
        txtManufacturer.Text = row.Cells["Manufacturer"].Value?.ToString() ?? "";
        txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
