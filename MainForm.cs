using System;
using System.Windows.Forms;
using UHFReader.Common;

namespace UHFReader
{
    public partial class MainForm : Form
    {
        private bool _isFullScreen = true;
        private Form _currentChildForm = null;

        private MedicineForm _medicineForm = null;
        private TagBindingForm _tagBindingForm = null;
        private InOutForm _inOutForm = null;
        private InventoryForm _inventoryForm = null;
        private TransactionForm _transactionForm = null;
        private Form1 _rfidReaderForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                lblWelcome.Text = $"欢迎，{CurrentUser.User.Username}！";
            }
        }

        private void btnMinimizeRestore_Click(object sender, EventArgs e)
        {
            _isFullScreen = !_isFullScreen;
            if (_isFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                btnMinimizeRestore.Text = "❐ 还原";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                btnMinimizeRestore.Text = "⬜ 全屏";
            }
        }

        private void ShowChildForm(Form childForm)
        {
            panelContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = System.Drawing.Color.FromArgb(50, 60, 85);
            panelContent.Controls.Add(childForm);
            childForm.Show();
            _currentChildForm = childForm;
        }

        private void btnMedicineManage_Click(object sender, EventArgs e)
        {
            if (_medicineForm == null || _medicineForm.IsDisposed)
            {
                _medicineForm = new MedicineForm();
            }
            ShowChildForm(_medicineForm);
        }

        private void btnTagBind_Click(object sender, EventArgs e)
        {
            if (_tagBindingForm == null || _tagBindingForm.IsDisposed)
            {
                _tagBindingForm = new TagBindingForm();
            }
            ShowChildForm(_tagBindingForm);
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            if (_inOutForm == null || _inOutForm.IsDisposed)
            {
                _inOutForm = new InOutForm();
            }
            ShowChildForm(_inOutForm);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (_inventoryForm == null || _inventoryForm.IsDisposed)
            {
                _inventoryForm = new InventoryForm();
            }
            ShowChildForm(_inventoryForm);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (_transactionForm == null || _transactionForm.IsDisposed)
            {
                _transactionForm = new TransactionForm();
            }
            ShowChildForm(_transactionForm);
        }

        private void btnRfidReader_Click(object sender, EventArgs e)
        {
            if (_rfidReaderForm == null || _rfidReaderForm.IsDisposed)
            {
                _rfidReaderForm = new Form1();
            }
            ShowChildForm(_rfidReaderForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                var result = MessageBox.Show("确定要退出系统吗？", "退出确认",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}