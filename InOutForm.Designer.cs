namespace UHFReader
{
  partial class InOutForm
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
      this.panelLeft = new System.Windows.Forms.Panel();
      this.lblEpc = new System.Windows.Forms.Label();
      this.txtEpc = new System.Windows.Forms.TextBox();
      this.lblMedicine = new System.Windows.Forms.Label();
      this.cmbMedicine = new System.Windows.Forms.ComboBox();
      this.lblTagStatus = new System.Windows.Forms.Label();
      this.btnIn = new System.Windows.Forms.Button();
      this.btnOut = new System.Windows.Forms.Button();
      this.btnScan = new System.Windows.Forms.Button();
      this.panelRight = new System.Windows.Forms.Panel();
      this.dgvRecords = new System.Windows.Forms.DataGridView();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.scanTimer = new System.Windows.Forms.Timer();
      this.panelTop.SuspendLayout();
      this.panelLeft.SuspendLayout();
      this.panelRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
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
      this.lblTitle.Text = "📥📤 出入库管理";

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

      this.panelLeft.BackColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.panelLeft.Location = new System.Drawing.Point(15, 75);
      this.panelLeft.Name = "panelLeft";
      this.panelLeft.Padding = new System.Windows.Forms.Padding(20);
      this.panelLeft.Size = new System.Drawing.Size(380, 350);
      this.panelLeft.TabIndex = 1;

      int labelY = 20;
      int inputY = 45;
      int spacing = 50;

      this.lblEpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblEpc.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblEpc.Location = new System.Drawing.Point(20, labelY);
      this.lblEpc.Name = "lblEpc";
      this.lblEpc.Size = new System.Drawing.Size(80, 25);
      this.lblEpc.TabIndex = 0;
      this.lblEpc.Text = "EPC编码:";

      this.txtEpc.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtEpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtEpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.txtEpc.ForeColor = System.Drawing.Color.White;
      this.txtEpc.Location = new System.Drawing.Point(120, inputY);
      this.txtEpc.Name = "txtEpc";
      this.txtEpc.Size = new System.Drawing.Size(220, 28);
      this.txtEpc.TabIndex = 1;
      this.txtEpc.TextChanged += new System.EventHandler(this.txtEpc_TextChanged);

      labelY += spacing;
      inputY += spacing;
      this.lblMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblMedicine.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblMedicine.Location = new System.Drawing.Point(20, labelY);
      this.lblMedicine.Name = "lblMedicine";
      this.lblMedicine.Size = new System.Drawing.Size(80, 25);
      this.lblMedicine.TabIndex = 2;
      this.lblMedicine.Text = "药品名称:";

      this.cmbMedicine.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.cmbMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.cmbMedicine.ForeColor = System.Drawing.Color.White;
      this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMedicine.FormattingEnabled = true;
      this.cmbMedicine.Location = new System.Drawing.Point(120, inputY);
      this.cmbMedicine.Name = "cmbMedicine";
      this.cmbMedicine.Size = new System.Drawing.Size(220, 28);
      this.cmbMedicine.TabIndex = 3;

      labelY += spacing;
      this.lblTagStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblTagStatus.ForeColor = System.Drawing.Color.LightGreen;
      this.lblTagStatus.Location = new System.Drawing.Point(20, labelY);
      this.lblTagStatus.Name = "lblTagStatus";
      this.lblTagStatus.Size = new System.Drawing.Size(320, 25);
      this.lblTagStatus.TabIndex = 4;
      this.lblTagStatus.Text = "标签状态: 未扫描";

      int btnY = 180;
      int btnWidth = 150;
      int btnHeight = 50;

      this.btnIn.BackColor = System.Drawing.Color.FromArgb(70, 180, 100);
      this.btnIn.FlatAppearance.BorderSize = 0;
      this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnIn.ForeColor = System.Drawing.Color.White;
      this.btnIn.Location = new System.Drawing.Point(20, btnY);
      this.btnIn.Name = "btnIn";
      this.btnIn.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnIn.TabIndex = 5;
      this.btnIn.Text = "📥 入库";
      this.btnIn.UseVisualStyleBackColor = false;
      this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnIn.Click += new System.EventHandler(this.btnIn_Click);

      this.btnOut.BackColor = System.Drawing.Color.FromArgb(230, 100, 80);
      this.btnOut.FlatAppearance.BorderSize = 0;
      this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnOut.ForeColor = System.Drawing.Color.White;
      this.btnOut.Location = new System.Drawing.Point(20 + btnWidth + 20, btnY);
      this.btnOut.Name = "btnOut";
      this.btnOut.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnOut.TabIndex = 6;
      this.btnOut.Text = "📤 出库";
      this.btnOut.UseVisualStyleBackColor = false;
      this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnOut.Click += new System.EventHandler(this.btnOut_Click);

      int scanBtnY = btnY + btnHeight + 20;
      this.btnScan.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
      this.btnScan.FlatAppearance.BorderSize = 0;
      this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnScan.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
      this.btnScan.ForeColor = System.Drawing.Color.White;
      this.btnScan.Location = new System.Drawing.Point(20, scanBtnY);
      this.btnScan.Name = "btnScan";
      this.btnScan.Size = new System.Drawing.Size(310, 40);
      this.btnScan.TabIndex = 7;
      this.btnScan.Text = "📡 扫描标签";
      this.btnScan.UseVisualStyleBackColor = false;
      this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnScan.Click += new System.EventHandler(this.btnScan_Click);

      this.scanTimer.Interval = 500;
      this.scanTimer.Tick += new System.EventHandler(this.scanTimer_Tick);

      this.panelLeft.Controls.Add(this.lblEpc);
      this.panelLeft.Controls.Add(this.txtEpc);
      this.panelLeft.Controls.Add(this.lblMedicine);
      this.panelLeft.Controls.Add(this.cmbMedicine);
      this.panelLeft.Controls.Add(this.lblTagStatus);
      this.panelLeft.Controls.Add(this.btnIn);
      this.panelLeft.Controls.Add(this.btnOut);
      this.panelLeft.Controls.Add(this.btnScan);

      this.panelRight.BackColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.panelRight.Location = new System.Drawing.Point(410, 75);
      this.panelRight.Name = "panelRight";
      this.panelRight.Padding = new System.Windows.Forms.Padding(15);
      this.panelRight.Size = new System.Drawing.Size(775, 580);
      this.panelRight.TabIndex = 2;

      this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
      this.btnRefresh.FlatAppearance.BorderSize = 0;
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(660, 10);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(90, 35);
      this.btnRefresh.TabIndex = 1;
      this.btnRefresh.Text = "刷新";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

      this.dgvRecords.AllowUserToAddRows = false;
      this.dgvRecords.AllowUserToDeleteRows = false;
      this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvRecords.BackgroundColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvRecords.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(45, 55, 75),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvRecords.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(55, 65, 90),
        ForeColor = System.Drawing.Color.FromArgb(180, 190, 210),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F),
        SelectionBackColor = System.Drawing.Color.FromArgb(70, 130, 200),
        SelectionForeColor = System.Drawing.Color.White
      };
      this.dgvRecords.EnableHeadersVisualStyles = false;
      this.dgvRecords.GridColor = System.Drawing.Color.FromArgb(90, 100, 130);
      this.dgvRecords.Location = new System.Drawing.Point(15, 55);
      this.dgvRecords.Name = "dgvRecords";
      this.dgvRecords.ReadOnly = true;
      this.dgvRecords.RowHeadersVisible = false;
      this.dgvRecords.RowTemplate.Height = 35;
      this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvRecords.Size = new System.Drawing.Size(740, 505);
      this.dgvRecords.TabIndex = 0;
      this.dgvRecords.ColumnHeadersHeight = 40;

      this.panelRight.Controls.Add(this.btnRefresh);
      this.panelRight.Controls.Add(this.dgvRecords);

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 700);
      this.Controls.Add(this.panelRight);
      this.Controls.Add(this.panelLeft);
      this.Controls.Add(this.panelTop);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "InOutForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "出入库管理";
      this.Load += new System.EventHandler(this.InOutForm_Load);

      this.panelTop.ResumeLayout(false);
      this.panelLeft.ResumeLayout(false);
      this.panelRight.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblEpc;
    private System.Windows.Forms.TextBox txtEpc;
    private System.Windows.Forms.Label lblMedicine;
    private System.Windows.Forms.ComboBox cmbMedicine;
    private System.Windows.Forms.Label lblTagStatus;
    private System.Windows.Forms.Button btnIn;
    private System.Windows.Forms.Button btnOut;
    private System.Windows.Forms.Button btnScan;
    private System.Windows.Forms.DataGridView dgvRecords;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Timer scanTimer;
  }
}