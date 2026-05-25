using System;
using System.Linq;
using System.Windows.Forms;
using UHFReader.BLL;
using UHFReader.Common;
using UHFReader.Models;

namespace UHFReader
{
  public partial class InOutForm : Form
  {
    private TransactionRecordBll _transactionBll = new TransactionRecordBll();
    private RfidTagBll _tagBll = new RfidTagBll();
    private MedicineBll _medicineBll = new MedicineBll();
    private bool isScanning = false;

    public InOutForm()
    {
      InitializeComponent();
    }

    private void InOutForm_Load(object sender, EventArgs e)
    {
      LoadMedicines();
      LoadRecords();
    }

    private void LoadMedicines()
    {
      var medicines = _medicineBll.GetAllMedicines();
      cmbMedicine.DataSource = medicines;
      cmbMedicine.DisplayMember = "Name";
      cmbMedicine.ValueMember = "Id";
    }

    private void txtEpc_TextChanged(object sender, EventArgs e)
    {
      string epc = txtEpc.Text.Trim();
      if (!string.IsNullOrEmpty(epc))
      {
        var tag = _tagBll.GetTagByEpc(epc);
        if (tag != null && tag.MedicineId.HasValue)
        {
          var medicine = _medicineBll.GetMedicineById(tag.MedicineId.Value);
          if (medicine != null)
          {
            cmbMedicine.SelectedValue = medicine.Id;
            lblTagStatus.Text = $"标签状态: {GetStatusText(tag.Status)}";
          }
        }
      }
    }

    private string GetStatusText(string status)
    {
      switch (status)
      {
        case "Unbound": return "未绑定";
        case "Bound": return "已绑定";
        case "InStock": return "已入库";
        case "OutStock": return "已出库";
        default: return status;
      }
    }

    private void btnIn_Click(object sender, EventArgs e)
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
      int quantity = Convert.ToInt32(numQuantity.Value);

      if (_transactionBll.StockIn(epc, medicineId, quantity, CurrentUser.User.Id, CurrentUser.User.Username))
      {
        MessageBox.Show($"入库成功！数量：{quantity}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtEpc.Clear();
        numQuantity.Value = 1;
        lblTagStatus.Text = "标签状态: -";
        LoadRecords();
      }
      else
      {
        MessageBox.Show("入库失败！请检查标签状态是否正确。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnOut_Click(object sender, EventArgs e)
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
      int quantity = Convert.ToInt32(numQuantity.Value);

      if (_transactionBll.StockOut(epc, medicineId, quantity, CurrentUser.User.Id, CurrentUser.User.Username))
      {
        MessageBox.Show($"出库成功！数量：{quantity}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtEpc.Clear();
        numQuantity.Value = 1;
        lblTagStatus.Text = "标签状态: -";
        LoadRecords();
      }
      else
      {
        MessageBox.Show("出库失败！请检查标签状态是否正确。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LoadRecords()
    {
      dgvRecords.DataSource = _transactionBll.GetAllTransactions();
      SetColumnNames();
    }

    private void SetColumnNames()
    {
      if (dgvRecords.Columns["Id"] != null) dgvRecords.Columns["Id"].HeaderText = "编号";
      if (dgvRecords.Columns["Type"] != null) dgvRecords.Columns["Type"].HeaderText = "类型";
      if (dgvRecords.Columns["MedicineId"] != null) dgvRecords.Columns["MedicineId"].HeaderText = "药品ID";
      if (dgvRecords.Columns["MedicineName"] != null) dgvRecords.Columns["MedicineName"].HeaderText = "药品名称";
      if (dgvRecords.Columns["TagId"] != null) dgvRecords.Columns["TagId"].HeaderText = "标签ID";
      if (dgvRecords.Columns["Epc"] != null) dgvRecords.Columns["Epc"].HeaderText = "电子标签号";
      if (dgvRecords.Columns["Quantity"] != null) dgvRecords.Columns["Quantity"].HeaderText = "数量";
      if (dgvRecords.Columns["OperatorId"] != null) dgvRecords.Columns["OperatorId"].HeaderText = "操作员ID";
      if (dgvRecords.Columns["OperatorName"] != null) dgvRecords.Columns["OperatorName"].HeaderText = "操作员";
      if (dgvRecords.Columns["CreateTime"] != null) dgvRecords.Columns["CreateTime"].HeaderText = "操作时间";
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      LoadRecords();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void btnScan_Click(object sender, EventArgs e)
    {
      if (!RfidHelper.IsConnected)
      {
        MessageBox.Show("请先在RFID读写器界面打开端口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      isScanning = !isScanning;
      if (isScanning)
      {
        btnScan.Text = "⏹ 停止扫描";
        btnScan.BackColor = System.Drawing.Color.FromArgb(230, 80, 80);
        lblTagStatus.ForeColor = System.Drawing.Color.LightBlue;
        lblTagStatus.Text = "标签状态: 扫描中...";
        scanTimer.Start();
      }
      else
      {
        btnScan.Text = "📡 扫描标签";
        btnScan.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
        lblTagStatus.ForeColor = System.Drawing.Color.LightGreen;
        scanTimer.Stop();
      }
    }

    private void scanTimer_Tick(object sender, EventArgs e)
    {
      string epc = RfidHelper.InventorySingleTag();
      if (!string.IsNullOrEmpty(epc))
      {
        txtEpc.Text = epc;

        var tag = _tagBll.GetTagByEpc(epc);
        if (tag != null)
        {
          if (tag.MedicineId.HasValue)
          {
            var medicine = _medicineBll.GetMedicineById(tag.MedicineId.Value);
            if (medicine != null)
            {
              cmbMedicine.SelectedValue = medicine.Id;
              lblTagStatus.ForeColor = System.Drawing.Color.LightGreen;
              lblTagStatus.Text = $"标签状态: {GetStatusText(tag.Status)}";
            }
          }
          else
          {
            lblTagStatus.ForeColor = System.Drawing.Color.Yellow;
            lblTagStatus.Text = "标签状态: 未绑定药品";
            cmbMedicine.SelectedIndex = -1;
          }
        }
        else
        {
          lblTagStatus.ForeColor = System.Drawing.Color.Red;
          lblTagStatus.Text = "标签状态: 未绑定（新标签）";
          cmbMedicine.SelectedIndex = -1;
          MessageBox.Show("该标签尚未绑定药品，请先在标签绑定界面进行绑定！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }
  }
}
