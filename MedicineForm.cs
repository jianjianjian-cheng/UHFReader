using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
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

    private void btnImportExcel_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx";
      openFileDialog.Title = "选择Excel文件";

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string filePath = openFileDialog.FileName;
        ImportMedicinesFromExcel(filePath);
      }
    }

    private void ImportMedicinesFromExcel(string filePath)
    {
      string connectionString = "";
      string fileExt = Path.GetExtension(filePath).ToLower();

      if (fileExt == ".xls")
      {
        connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath};Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
      }
      else if (fileExt == ".xlsx")
      {
        connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
      }
      else
      {
        MessageBox.Show("请选择Excel文件(.xls或.xlsx)！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        using (OleDbConnection conn = new OleDbConnection(connectionString))
        {
          conn.Open();
          DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
          string sheetName = dt.Rows[0]["TABLE_NAME"].ToString();

          string sql = $"SELECT * FROM [{sheetName}]";
          OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
          DataTable resultTable = new DataTable();
          adapter.Fill(resultTable);

          if (resultTable.Rows.Count == 0)
          {
            MessageBox.Show("Excel文件中没有数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }

          List<Medicine> medicines = new List<Medicine>();
          int successCount = 0;
          int failCount = 0;
          List<string> errorMessages = new List<string>();

          for (int i = 0; i < resultTable.Rows.Count; i++)
          {
            try
            {
              DataRow row = resultTable.Rows[i];
              string code = row["药品编码"]?.ToString().Trim() ?? "";
              string name = row["药品名称"]?.ToString().Trim() ?? "";
              string spec = row["规格"]?.ToString().Trim() ?? "";
              string manufacturer = row["生产厂家"]?.ToString().Trim() ?? "";
              string description = row["描述"]?.ToString().Trim() ?? "";

              if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name))
              {
                failCount++;
                errorMessages.Add($"第{i + 2}行：药品编码或名称为空");
                continue;
              }

              if (_medicineBll.ExistsByCode(code))
              {
                failCount++;
                errorMessages.Add($"第{i + 2}行：药品编码'{code}'已存在");
                continue;
              }

              medicines.Add(new Medicine
              {
                Code = code,
                Name = name,
                Specification = spec,
                Manufacturer = manufacturer,
                Description = description
              });
              successCount++;
            }
            catch (Exception ex)
            {
              failCount++;
              errorMessages.Add($"第{i + 2}行：{ex.Message}");
            }
          }

          foreach (var medicine in medicines)
          {
            _medicineBll.AddMedicine(medicine);
          }

          string message = $"导入完成！\n成功：{successCount}条\n失败：{failCount}条";
          if (errorMessages.Count > 0 && errorMessages.Count <= 10)
          {
            message += "\n\n错误信息：\n" + string.Join("\n", errorMessages);
          }
          else if (errorMessages.Count > 10)
          {
            message += $"\n\n前10条错误：\n" + string.Join("\n", errorMessages.GetRange(0, 10));
          }

          MessageBox.Show(message, "导入结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
          LoadMedicines();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("导入失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnExportTemplate_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
      saveFileDialog.Title = "保存模板文件";
      saveFileDialog.FileName = "药品导入模板.xlsx";

      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        string filePath = saveFileDialog.FileName;
        ExportTemplate(filePath);
      }
    }

    private void ExportTemplate(string filePath)
    {
      string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0;HDR=YES;'";

      try
      {
        using (OleDbConnection conn = new OleDbConnection(connectionString))
        {
          conn.Open();

          string createTableSql = @"CREATE TABLE [药品列表] (
                        [药品编码] VARCHAR(50),
                        [药品名称] VARCHAR(100),
                        [规格] VARCHAR(100),
                        [生产厂家] VARCHAR(100),
                        [描述] VARCHAR(500)
                    )";
          OleDbCommand cmd = new OleDbCommand(createTableSql, conn);
          cmd.ExecuteNonQuery();

          string insertSql = @"INSERT INTO [药品列表] ([药品编码], [药品名称], [规格], [生产厂家], [描述]) VALUES (?, ?, ?, ?, ?)";
          cmd = new OleDbCommand(insertSql, conn);

          List<string[]> sampleData = new List<string[]>
                    {
                        new string[] {"MED001", "阿莫西林胶囊", "0.5g*20粒", "华北制药", "青霉素类抗生素"},
                        new string[] {"MED002", "布洛芬缓释胶囊", "0.3g*20粒", "扬子江药业", "解热镇痛药"},
                        new string[] {"MED003", "头孢克肟分散片", "0.1g*6片", "石药集团", "头孢类抗生素"},
                        new string[] {"MED004", "复方氨酚烷胺片", "12片/盒", "白云山制药", "感冒药"},
                        new string[] {"MED005", "维生素C片", "100mg*100片", "华中药业", "维生素类"}
                    };

          foreach (var row in sampleData)
          {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p1", row[0]);
            cmd.Parameters.AddWithValue("@p2", row[1]);
            cmd.Parameters.AddWithValue("@p3", row[2]);
            cmd.Parameters.AddWithValue("@p4", row[3]);
            cmd.Parameters.AddWithValue("@p5", row[4]);
            cmd.ExecuteNonQuery();
          }

          MessageBox.Show($"模板已导出到：\n{filePath}\n\n请保留表头，删除示例数据后填写您的药品信息！", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("导出模板失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
