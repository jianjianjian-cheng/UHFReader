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
      this.lblScanStatus = new System.Windows.Forms.Label();
      this.panelRight = new System.Windows.Forms.Panel();
      this.dgvTags = new System.Windows.Forms.DataGridView();
      this.scanTimer = new System.Windows.Forms.Timer(this.components);
      this.panelTop.SuspendLayout();
      this.panelLeft.SuspendLayout();
      this.panelRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
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
      this.lblTitle.Size = new System.Drawing.Size(150, 36);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "🏷️ 标签绑定";

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
      this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelLeft.Name = "panelLeft";
      this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
      this.panelLeft.Size = new System.Drawing.Size(320, 600);
      this.panelLeft.TabIndex = 1;

      int labelY = 20;
      int inputY = 45;
      int spacing = 45;

      this.lblEpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblEpc.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblEpc.Location = new System.Drawing.Point(15, labelY);
      this.lblEpc.Name = "lblEpc";
      this.lblEpc.Size = new System.Drawing.Size(80, 20);
      this.lblEpc.TabIndex = 1;
      this.lblEpc.Text = "EPC:";

      this.txtEpc.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtEpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtEpc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtEpc.ForeColor = System.Drawing.Color.White;
      this.txtEpc.Location = new System.Drawing.Point(15, inputY);
      this.txtEpc.Name = "txtEpc";
      this.txtEpc.Size = new System.Drawing.Size(290, 25);
      this.txtEpc.TabIndex = 4;

      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblTid.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblTid.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblTid.Location = new System.Drawing.Point(15, labelY);
      this.lblTid.Name = "lblTid";
      this.lblTid.Size = new System.Drawing.Size(80, 20);
      this.lblTid.TabIndex = 2;
      this.lblTid.Text = "TID:";

      this.txtTid.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtTid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtTid.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtTid.ForeColor = System.Drawing.Color.White;
      this.txtTid.Location = new System.Drawing.Point(15, inputY);
      this.txtTid.Name = "txtTid";
      this.txtTid.Size = new System.Drawing.Size(290, 25);
      this.txtTid.TabIndex = 5;

      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblMedicine.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblMedicine.Location = new System.Drawing.Point(15, labelY);
      this.lblMedicine.Name = "lblMedicine";
      this.lblMedicine.Size = new System.Drawing.Size(80, 20);
      this.lblMedicine.TabIndex = 3;
      this.lblMedicine.Text = "药品:";

      this.cmbMedicine.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cmbMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.cmbMedicine.ForeColor = System.Drawing.Color.White;
      this.cmbMedicine.Location = new System.Drawing.Point(15, inputY);
      this.cmbMedicine.Name = "cmbMedicine";
      this.cmbMedicine.Size = new System.Drawing.Size(290, 30);
      this.cmbMedicine.TabIndex = 6;

      int btnY = 220;
      int btnWidth = 130;
      int btnHeight = 40;
      int btnSpacing = 15;

      this.btnScan.BackColor = System.Drawing.Color.FromArgb(70, 180, 100);
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

      this.btnBind.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
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

      btnY += btnHeight + 10;
      this.lblScanStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.lblScanStatus.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblScanStatus.Location = new System.Drawing.Point(15, btnY);
      this.lblScanStatus.Name = "lblScanStatus";
      this.lblScanStatus.Size = new System.Drawing.Size(290, 25);
      this.lblScanStatus.TabIndex = 10;
      this.lblScanStatus.Text = "状态: 未扫描";

      btnY += 35;
      this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(90, 100, 130);
      this.btnRefresh.FlatAppearance.BorderSize = 0;
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.btnRefresh.Location = new System.Drawing.Point(15, btnY);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(290, 40);
      this.btnRefresh.TabIndex = 8;
      this.btnRefresh.Text = "刷新列表";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

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

      this.panelRight.BackColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelRight.Name = "panelRight";
      this.panelRight.Padding = new System.Windows.Forms.Padding(15);
      this.panelRight.Size = new System.Drawing.Size(835, 600);
      this.panelRight.TabIndex = 2;

      this.dgvTags.AllowUserToAddRows = false;
      this.dgvTags.AllowUserToDeleteRows = false;
      this.dgvTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvTags.BackgroundColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.dgvTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvTags.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(45, 55, 75),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvTags.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(55, 65, 90),
        ForeColor = System.Drawing.Color.FromArgb(180, 190, 210),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F),
        SelectionBackColor = System.Drawing.Color.FromArgb(70, 130, 200),
        SelectionForeColor = System.Drawing.Color.White
      };
      this.dgvTags.EnableHeadersVisualStyles = false;
      this.dgvTags.GridColor = System.Drawing.Color.FromArgb(90, 100, 130);
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

      this.panelRight.Controls.Add(this.dgvTags);

      this.scanTimer.Enabled = false;
      this.scanTimer.Interval = 500;
      this.scanTimer.Tick += new System.EventHandler(this.scanTimer_Tick);

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
    private System.Windows.Forms.Label lblScanStatus;
    private System.Windows.Forms.DataGridView dgvTags;
    private System.Windows.Forms.Timer scanTimer;
  }
}