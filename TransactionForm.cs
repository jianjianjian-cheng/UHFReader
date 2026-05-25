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
