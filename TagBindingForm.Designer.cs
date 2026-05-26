namespace UHFReader
{
  partial class TagBindingForm
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
      this.components = new System.ComponentModel.Container();
      this.panelTop = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.panelLeft = new System.Windows.Forms.Panel();
      this.lblEpc = new System.Windows.Forms.Label();
      this.lblTid = new System.Windows.Forms.Label();
      this.lblMedicine = new System.Windows.Forms.Label();
      this.txtEpc = new System.Windows.Forms.TextBox();
      this.txtTid = new System.Windows.Forms.TextBox();
      this.cmbMedicine = new System.Windows.Forms.ComboBox();
      this.btnBind = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnScan = new System.Windows.Forms.Button();
      this.btnOpenPort = new System.Windows.Forms.Button();
      this.lblScanStatus = new System.Windows.Forms.Label();
      this.lblPortStatus = new System.Windows.Forms.Label();
      this.lblScanList = new System.Windows.Forms.Label();
      this.panelRight = new System.Windows.Forms.Panel();
      this.dgvTags = new System.Windows.Forms.DataGridView();
      this.dgvScanTags = new System.Windows.Forms.DataGridView();
      this.scanTimer = new System.Windows.Forms.Timer(this.components);
      this.panelTop.SuspendLayout();
      this.panelLeft.SuspendLayout();
      this.panelRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvScanTags)).BeginInit();
      this.SuspendLayout();

      // --- 顶部面板 ---
      this.panelTop.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(1200, 60);
      this.panelTop.TabIndex = 0;

      // --- 标题 ---
      this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.lblTitle.Location = new System.Drawing.Point(20, 12);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(150, 36);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "🏷️ 标签绑定";

      // --- 关闭按钮 ---
      this.btnClose.BackColor = System.Drawing.Color.FromArgb(248, 113, 113);
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

      // --- 顶部面板控件添加 ---
      this.panelTop.Controls.Add(this.lblTitle);
      this.panelTop.Controls.Add(this.btnClose);

      // --- 左侧面板 ---
      this.panelLeft.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelLeft.Name = "panelLeft";
      this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
      this.panelLeft.Size = new System.Drawing.Size(320, 600);
      this.panelLeft.TabIndex = 1;

      int labelY = 20;
      int inputY = 45;
      int spacing = 45;

      // --- EPC标签 ---
      this.lblEpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblEpc.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblEpc.Location = new System.Drawing.Point(15, labelY);
      this.lblEpc.Name = "lblEpc";
      this.lblEpc.Size = new System.Drawing.Size(80, 20);
      this.lblEpc.TabIndex = 1;
      this.lblEpc.Text = "EPC:";

      // --- EPC输入框 ---
      this.txtEpc.BackColor = System.Drawing.Color.White;
      this.txtEpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtEpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtEpc.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtEpc.Location = new System.Drawing.Point(15, inputY);
      this.txtEpc.Name = "txtEpc";
      this.txtEpc.Size = new System.Drawing.Size(290, 25);
      this.txtEpc.TabIndex = 4;

      // --- TID ---
      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblTid.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblTid.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblTid.Location = new System.Drawing.Point(15, labelY);
      this.lblTid.Name = "lblTid";
      this.lblTid.Size = new System.Drawing.Size(80, 20);
      this.lblTid.TabIndex = 2;
      this.lblTid.Text = "TID:";

      this.txtTid.BackColor = System.Drawing.Color.White;
      this.txtTid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTid.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtTid.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtTid.Location = new System.Drawing.Point(15, inputY);
      this.txtTid.Name = "txtTid";
      this.txtTid.Size = new System.Drawing.Size(290, 25);
      this.txtTid.TabIndex = 5;

      // --- 药品选择 ---
      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblMedicine.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblMedicine.Location = new System.Drawing.Point(15, labelY);
      this.lblMedicine.Name = "lblMedicine";
      this.lblMedicine.Size = new System.Drawing.Size(80, 20);
      this.lblMedicine.TabIndex = 3;
      this.lblMedicine.Text = "药品:";

      this.cmbMedicine.BackColor = System.Drawing.Color.White;
      this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cmbMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.cmbMedicine.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.cmbMedicine.Location = new System.Drawing.Point(15, inputY);
      this.cmbMedicine.Name = "cmbMedicine";
      this.cmbMedicine.Size = new System.Drawing.Size(290, 30);
      this.cmbMedicine.TabIndex = 6;

      int btnY = 220;
      int btnWidth = 130;
      int btnHeight = 40;
      int btnSpacing = 15;

      // --- 扫描按钮 ---
      this.btnScan.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
      this.btnScan.FlatAppearance.BorderSize = 0;
      this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnScan.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnScan.ForeColor = System.Drawing.Color.White;
      this.btnScan.Location = new System.Drawing.Point(15, btnY);
      this.btnScan.Name = "btnScan";
      this.btnScan.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnScan.TabIndex = 9;
      this.btnScan.Text = "📡 扫描标签";
      this.btnScan.UseVisualStyleBackColor = false;
      this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnScan.Click += new System.EventHandler(this.btnScan_Click);

      // --- 绑定按钮 ---
      this.btnBind.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnBind.FlatAppearance.BorderSize = 0;
      this.btnBind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBind.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnBind.ForeColor = System.Drawing.Color.White;
      this.btnBind.Location = new System.Drawing.Point(15 + btnWidth + btnSpacing, btnY);
      this.btnBind.Name = "btnBind";
      this.btnBind.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnBind.TabIndex = 7;
      this.btnBind.Text = "绑定";
      this.btnBind.UseVisualStyleBackColor = false;
      this.btnBind.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBind.Click += new System.EventHandler(this.btnBind_Click);

      // --- 扫描状态 ---
      btnY += btnHeight + 10;
      this.lblScanStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.lblScanStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.lblScanStatus.Location = new System.Drawing.Point(15, btnY);
      this.lblScanStatus.Name = "lblScanStatus";
      this.lblScanStatus.Size = new System.Drawing.Size(290, 25);
      this.lblScanStatus.TabIndex = 10;
      this.lblScanStatus.Text = "状态: 未扫描";

      // --- 刷新按钮 ---
      btnY += 35;
      this.btnRefresh.BackColor = System.Drawing.Color.White;
      this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnRefresh.FlatAppearance.BorderSize = 1;
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.btnRefresh.Location = new System.Drawing.Point(15, btnY);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(135, 40);
      this.btnRefresh.TabIndex = 8;
      this.btnRefresh.Text = "刷新列表";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

      // --- 打开端口按钮 ---
      this.btnOpenPort.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
      this.btnOpenPort.FlatAppearance.BorderSize = 0;
      this.btnOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOpenPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnOpenPort.ForeColor = System.Drawing.Color.White;
      this.btnOpenPort.Location = new System.Drawing.Point(15 + 135 + 20, btnY);
      this.btnOpenPort.Name = "btnOpenPort";
      this.btnOpenPort.Size = new System.Drawing.Size(135, 40);
      this.btnOpenPort.TabIndex = 11;
      this.btnOpenPort.Text = "🔌 打开端口";
      this.btnOpenPort.UseVisualStyleBackColor = false;
      this.btnOpenPort.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);

      // --- 端口状态标签 ---
      btnY += btnHeight + 15;
      this.lblPortStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.lblPortStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.lblPortStatus.Location = new System.Drawing.Point(15, btnY);
      this.lblPortStatus.Name = "lblPortStatus";
      this.lblPortStatus.Size = new System.Drawing.Size(290, 25);
      this.lblPortStatus.TabIndex = 12;
      this.lblPortStatus.Text = "端口状态: 未连接";

      // --- 扫描标签列表标题 ---
      btnY += 30;
      this.lblScanList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblScanList.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblScanList.Location = new System.Drawing.Point(15, btnY);
      this.lblScanList.Name = "lblScanList";
      this.lblScanList.Size = new System.Drawing.Size(290, 25);
      this.lblScanList.TabIndex = 13;
      this.lblScanList.Text = "📡 扫描到的标签";

      // --- 扫描标签列表 ---
      btnY += 25;
      this.dgvScanTags.AllowUserToAddRows = false;
      this.dgvScanTags.AllowUserToDeleteRows = false;
      this.dgvScanTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvScanTags.BackgroundColor = System.Drawing.Color.White;
      this.dgvScanTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.dgvScanTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvScanTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvScanTags.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(16, 185, 129),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvScanTags.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.White,
        ForeColor = System.Drawing.Color.FromArgb(51, 65, 85),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 8F),
        SelectionBackColor = System.Drawing.Color.FromArgb(200, 240, 215),
        SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
      };
      this.dgvScanTags.EnableHeadersVisualStyles = false;
      this.dgvScanTags.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.dgvScanTags.Location = new System.Drawing.Point(15, btnY);
      this.dgvScanTags.Name = "dgvScanTags";
      this.dgvScanTags.ReadOnly = true;
      this.dgvScanTags.RowHeadersVisible = false;
      this.dgvScanTags.RowTemplate.Height = 28;
      this.dgvScanTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvScanTags.Size = new System.Drawing.Size(290, 180);
      this.dgvScanTags.TabIndex = 14;
      this.dgvScanTags.ColumnHeadersHeight = 30;

      // --- 左侧面板控件添加 ---
      this.panelLeft.Controls.Add(this.lblEpc);
      this.panelLeft.Controls.Add(this.txtEpc);
      this.panelLeft.Controls.Add(this.lblTid);
      this.panelLeft.Controls.Add(this.txtTid);
      this.panelLeft.Controls.Add(this.lblMedicine);
      this.panelLeft.Controls.Add(this.cmbMedicine);
      this.panelLeft.Controls.Add(this.btnScan);
      this.panelLeft.Controls.Add(this.btnBind);
      this.panelLeft.Controls.Add(this.lblScanStatus);
      this.panelLeft.Controls.Add(this.btnRefresh);
      this.panelLeft.Controls.Add(this.btnOpenPort);
      this.panelLeft.Controls.Add(this.lblPortStatus);
      this.panelLeft.Controls.Add(this.lblScanList);
      this.panelLeft.Controls.Add(this.dgvScanTags);

      // --- 右侧面板 ---
      this.panelRight.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelRight.Name = "panelRight";
      this.panelRight.Padding = new System.Windows.Forms.Padding(15);
      this.panelRight.Size = new System.Drawing.Size(835, 600);
      this.panelRight.TabIndex = 2;

      // --- 标签表格 ---
      this.dgvTags.AllowUserToAddRows = false;
      this.dgvTags.AllowUserToDeleteRows = false;
      this.dgvTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvTags.BackgroundColor = System.Drawing.Color.White;
      this.dgvTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvTags.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(59, 130, 246),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvTags.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.White,
        ForeColor = System.Drawing.Color.FromArgb(51, 65, 85),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F),
        SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254),
        SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
      };
      this.dgvTags.EnableHeadersVisualStyles = false;
      this.dgvTags.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.dgvTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvTags.Location = new System.Drawing.Point(15, 15);
      this.dgvTags.Name = "dgvTags";
      this.dgvTags.ReadOnly = true;
      this.dgvTags.RowHeadersVisible = false;
      this.dgvTags.RowTemplate.Height = 35;
      this.dgvTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvTags.Size = new System.Drawing.Size(805, 570);
      this.dgvTags.TabIndex = 9;
      this.dgvTags.ColumnHeadersHeight = 40;

      // --- 右侧面板控件添加 ---
      this.panelRight.Controls.Add(this.dgvTags);

      this.scanTimer.Enabled = false;
      this.scanTimer.Interval = 500;
      this.scanTimer.Tick += new System.EventHandler(this.scanTimer_Tick);

      // --- 窗体设置 ---
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 700);
      this.Controls.Add(this.panelRight);
      this.Controls.Add(this.panelLeft);
      this.Controls.Add(this.panelTop);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "TagBindingForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "标签绑定";
      this.Load += new System.EventHandler(this.TagBindingForm_Load);
      this.VisibleChanged += new System.EventHandler(this.TagBindingForm_VisibleChanged);

      this.panelTop.ResumeLayout(false);
      this.panelLeft.ResumeLayout(false);
      this.panelRight.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvScanTags)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblEpc;
    private System.Windows.Forms.Label lblTid;
    private System.Windows.Forms.Label lblMedicine;
    private System.Windows.Forms.TextBox txtEpc;
    private System.Windows.Forms.TextBox txtTid;
    private System.Windows.Forms.ComboBox cmbMedicine;
    private System.Windows.Forms.Button btnBind;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnScan;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.Label lblScanStatus;
    private System.Windows.Forms.Label lblPortStatus;
    private System.Windows.Forms.Label lblScanList;
    private System.Windows.Forms.DataGridView dgvTags;
    private System.Windows.Forms.DataGridView dgvScanTags;
    private System.Windows.Forms.Timer scanTimer;
  }
}
