using System;
using System.Windows.Forms;
using UHFReader.BLL;

namespace UHFReader
{
  public partial class TransactionForm : Form
  {
    private TransactionRecordBll _transactionBll = new TransactionRecordBll();

    public TransactionForm()
    {
      InitializeComponent();
    }

    private void TransactionForm_Load(object sender, EventArgs e)
    {
      LoadTransactions();
    }

    private void LoadTransactions()
    {
      if (rdbAll.Checked)
      {
        dgvTransactions.DataSource = _transactionBll.GetAllTransactions();
      }
      else if (rdbIn.Checked)
      {
        dgvTransactions.DataSource = _transactionBll.GetTransactionsByType("In");
      }
      else if (rdbOut.Checked)
      {
        dgvTransactions.DataSource = _transactionBll.GetTransactionsByType("Out");
      }
      SetColumnNames();
    }

    private void SetColumnNames()
    {
      if (dgvTransactions.Columns["Id"] != null) dgvTransactions.Columns["Id"].HeaderText = "编号";
      if (dgvTransactions.Columns["Type"] != null) dgvTransactions.Columns["Type"].HeaderText = "类型";
      if (dgvTransactions.Columns["MedicineId"] != null) dgvTransactions.Columns["MedicineId"].HeaderText = "药品ID";
      if (dgvTransactions.Columns["MedicineName"] != null) dgvTransactions.Columns["MedicineName"].HeaderText = "药品名称";
      if (dgvTransactions.Columns["TagId"] != null) dgvTransactions.Columns["TagId"].HeaderText = "标签ID";
      if (dgvTransactions.Columns["Epc"] != null) dgvTransactions.Columns["Epc"].HeaderText = "电子标签号";
      if (dgvTransactions.Columns["Quantity"] != null) dgvTransactions.Columns["Quantity"].HeaderText = "数量";
      if (dgvTransactions.Columns["OperatorId"] != null) dgvTransactions.Columns["OperatorId"].HeaderText = "操作员ID";
      if (dgvTransactions.Columns["OperatorName"] != null) dgvTransactions.Columns["OperatorName"].HeaderText = "操作员";
      if (dgvTransactions.Columns["CreateTime"] != null) dgvTransactions.Columns["CreateTime"].HeaderText = "操作时间";
    }

    private void rdbAll_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbAll.Checked) LoadTransactions();
    }

    private void rdbIn_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbIn.Checked) LoadTransactions();
    }

    private void rdbOut_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbOut.Checked) LoadTransactions();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      LoadTransactions();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
