namespace UHFReader
{
  partial class TransactionForm
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelTop = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
      this.panelControls = new System.Windows.Forms.Panel();
      this.rdbAll = new System.Windows.Forms.RadioButton();
      this.rdbIn = new System.Windows.Forms.RadioButton();
      this.rdbOut = new System.Windows.Forms.RadioButton();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.dgvTransactions = new System.Windows.Forms.DataGridView();
      this.panelTop.SuspendLayout();
      this.tableLayoutPanelMain.SuspendLayout();
      this.panelControls.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
      this.SuspendLayout();

      this.panelTop.BackColor = System.Drawing.Color.FromArgb(45, 55, 75);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(1200, 60);
      this.panelTop.TabIndex = 0;

      this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(20, 12);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(200, 36);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "📋 出入库记录";

      this.btnClose.BackColor = System.Drawing.Color.FromArgb(230, 80, 80);
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
      this.btnClose.ForeColor = System.Drawing.Color.White;
      this.btnClose.Location = new System.Drawing.Point(1100, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(80, 36);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

      this.panelTop.Controls.Add(this.lblTitle);
      this.panelTop.Controls.Add(this.btnClose);

      this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.tableLayoutPanelMain.ColumnCount = 1;
      this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 60);
      this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
      this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(15);
      this.tableLayoutPanelMain.RowCount = 2;
      this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelMain.Size = new System.Drawing.Size(1200, 640);
      this.tableLayoutPanelMain.TabIndex = 1;

      this.panelControls.BackColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControls.Location = new System.Drawing.Point(18, 18);
      this.panelControls.Name = "panelControls";
      this.panelControls.Size = new System.Drawing.Size(1164, 36);
      this.panelControls.TabIndex = 0;

      int radioY = 0;
      int radioWidth = 80;

      this.rdbAll.AutoSize = true;
      this.rdbAll.Checked = true;
      this.rdbAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.rdbAll.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.rdbAll.Location = new System.Drawing.Point(5, radioY);
      this.rdbAll.Name = "rdbAll";
      this.rdbAll.Size = new System.Drawing.Size(60, 28);
      this.rdbAll.TabIndex = 0;
      this.rdbAll.TabStop = true;
      this.rdbAll.Text = "全部";
      this.rdbAll.UseVisualStyleBackColor = true;
      this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);

      this.rdbIn.AutoSize = true;
      this.rdbIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.rdbIn.ForeColor = System.Drawing.Color.LightGreen;
      this.rdbIn.Location = new System.Drawing.Point(70, radioY);
      this.rdbIn.Name = "rdbIn";
      this.rdbIn.Size = new System.Drawing.Size(60, 28);
      this.rdbIn.TabIndex = 1;
      this.rdbIn.Text = "📥 入库";
      this.rdbIn.UseVisualStyleBackColor = true;
      this.rdbIn.CheckedChanged += new System.EventHandler(this.rdbIn_CheckedChanged);

      this.rdbOut.AutoSize = true;
      this.rdbOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.rdbOut.ForeColor = System.Drawing.Color.LightSalmon;
      this.rdbOut.Location = new System.Drawing.Point(135, radioY);
      this.rdbOut.Name = "rdbOut";
      this.rdbOut.Size = new System.Drawing.Size(65, 28);
      this.rdbOut.TabIndex = 2;
      this.rdbOut.Text = "📤 出库";
      this.rdbOut.UseVisualStyleBackColor = true;
      this.rdbOut.CheckedChanged += new System.EventHandler(this.rdbOut_CheckedChanged);

      this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
      this.btnRefresh.FlatAppearance.BorderSize = 0;
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(1015, -2);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(90, 35);
      this.btnRefresh.TabIndex = 3;
      this.btnRefresh.Text = "刷新";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

      this.dgvTransactions.AllowUserToAddRows = false;
      this.dgvTransactions.AllowUserToDeleteRows = false;
      this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvTransactions.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(45, 55, 75),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvTransactions.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(55, 65, 90),
        ForeColor = System.Drawing.Color.FromArgb(180, 190, 210),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F),
        SelectionBackColor = System.Drawing.Color.FromArgb(70, 130, 200),
        SelectionForeColor = System.Drawing.Color.White
      };
      this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvTransactions.EnableHeadersVisualStyles = false;
      this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(90, 100, 130);
      this.dgvTransactions.Name = "dgvTransactions";
      this.dgvTransactions.ReadOnly = true;
      this.dgvTransactions.RowHeadersVisible = false;
      this.dgvTransactions.RowTemplate.Height = 35;
      this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvTransactions.TabIndex = 4;
      this.dgvTransactions.ColumnHeadersHeight = 40;

      this.panelControls.Controls.Add(this.rdbAll);
      this.panelControls.Controls.Add(this.rdbIn);
      this.panelControls.Controls.Add(this.rdbOut);
      this.panelControls.Controls.Add(this.btnRefresh);

      this.tableLayoutPanelMain.Controls.Add(this.panelControls, 0, 0);
      this.tableLayoutPanelMain.Controls.Add(this.dgvTransactions, 0, 1);

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 700);
      this.Controls.Add(this.tableLayoutPanelMain);
      this.Controls.Add(this.panelTop);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "TransactionForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "出入库记录";
      this.Load += new System.EventHandler(this.TransactionForm_Load);

      this.panelTop.ResumeLayout(false);
      this.tableLayoutPanelMain.ResumeLayout(false);
      this.panelControls.ResumeLayout(false);
      this.panelControls.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    private System.Windows.Forms.Panel panelControls;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.RadioButton rdbAll;
    private System.Windows.Forms.RadioButton rdbIn;
    private System.Windows.Forms.RadioButton rdbOut;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.DataGridView dgvTransactions;
  }
}