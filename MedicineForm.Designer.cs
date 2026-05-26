namespace UHFReader
{
  partial class MedicineForm
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
      this.lblCode = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.lblSpecification = new System.Windows.Forms.Label();
      this.lblManufacturer = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.txtCode = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtSpecification = new System.Windows.Forms.TextBox();
      this.txtManufacturer = new System.Windows.Forms.TextBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnImportExcel = new System.Windows.Forms.Button();
      this.btnExportTemplate = new System.Windows.Forms.Button();
      this.panelRight = new System.Windows.Forms.Panel();
      this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
      this.panelSearch = new System.Windows.Forms.Panel();
      this.lblSearch = new System.Windows.Forms.Label();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.dgvMedicines = new System.Windows.Forms.DataGridView();
      this.panelTop.SuspendLayout();
      this.panelLeft.SuspendLayout();
      this.panelRight.SuspendLayout();
      this.tableLayoutPanelRight.SuspendLayout();
      this.panelSearch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
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
      this.lblTitle.Text = "📦 药品管理";

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
      int labelHeight = 20;
      int inputHeight = 35;
      int spacing = 40;

      // --- 药品编码标签 ---
      this.lblCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblCode.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblCode.Location = new System.Drawing.Point(15, labelY);
      this.lblCode.Name = "lblCode";
      this.lblCode.Size = new System.Drawing.Size(80, 20);
      this.lblCode.TabIndex = 1;
      this.lblCode.Text = "药品编码:";

      // --- 药品编码输入框 ---
      this.txtCode.BackColor = System.Drawing.Color.White;
      this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtCode.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtCode.Location = new System.Drawing.Point(15, inputY);
      this.txtCode.Name = "txtCode";
      this.txtCode.Size = new System.Drawing.Size(290, 25);
      this.txtCode.TabIndex = 6;

      // --- 药品名称 ---
      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblName.Location = new System.Drawing.Point(15, labelY);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(80, 20);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "药品名称:";

      this.txtName.BackColor = System.Drawing.Color.White;
      this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtName.Location = new System.Drawing.Point(15, inputY);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(290, 25);
      this.txtName.TabIndex = 7;

      // --- 规格 ---
      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblSpecification.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblSpecification.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblSpecification.Location = new System.Drawing.Point(15, labelY);
      this.lblSpecification.Name = "lblSpecification";
      this.lblSpecification.Size = new System.Drawing.Size(80, 20);
      this.lblSpecification.TabIndex = 3;
      this.lblSpecification.Text = "规格:";

      this.txtSpecification.BackColor = System.Drawing.Color.White;
      this.txtSpecification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSpecification.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtSpecification.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtSpecification.Location = new System.Drawing.Point(15, inputY);
      this.txtSpecification.Name = "txtSpecification";
      this.txtSpecification.Size = new System.Drawing.Size(290, 25);
      this.txtSpecification.TabIndex = 8;

      // --- 生产厂家 ---
      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblManufacturer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblManufacturer.Location = new System.Drawing.Point(15, labelY);
      this.lblManufacturer.Name = "lblManufacturer";
      this.lblManufacturer.Size = new System.Drawing.Size(80, 20);
      this.lblManufacturer.TabIndex = 4;
      this.lblManufacturer.Text = "生产厂家:";

      this.txtManufacturer.BackColor = System.Drawing.Color.White;
      this.txtManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtManufacturer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtManufacturer.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtManufacturer.Location = new System.Drawing.Point(15, inputY);
      this.txtManufacturer.Name = "txtManufacturer";
      this.txtManufacturer.Size = new System.Drawing.Size(290, 25);
      this.txtManufacturer.TabIndex = 9;

      // --- 描述 ---
      labelY += spacing + 15;
      inputY += spacing + 15;
      this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblDescription.Location = new System.Drawing.Point(15, labelY);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(80, 20);
      this.lblDescription.TabIndex = 5;
      this.lblDescription.Text = "描述:";

      this.txtDescription.BackColor = System.Drawing.Color.White;
      this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtDescription.Location = new System.Drawing.Point(15, inputY);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(290, 60);
      this.txtDescription.TabIndex = 10;

      int btnY = 420;
      int btnWidth = 130;
      int btnHeight = 40;
      int btnSpacing = 15;

      // --- 添加按钮 ---
      this.btnAdd.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnAdd.FlatAppearance.BorderSize = 0;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnAdd.ForeColor = System.Drawing.Color.White;
      this.btnAdd.Location = new System.Drawing.Point(15, btnY);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnAdd.TabIndex = 11;
      this.btnAdd.Text = "添加";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

      // --- 修改按钮 ---
      this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnUpdate.FlatAppearance.BorderSize = 0;
      this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnUpdate.ForeColor = System.Drawing.Color.White;
      this.btnUpdate.Location = new System.Drawing.Point(15 + btnWidth + btnSpacing, btnY);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnUpdate.TabIndex = 12;
      this.btnUpdate.Text = "修改";
      this.btnUpdate.UseVisualStyleBackColor = false;
      this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

      // --- 删除按钮 ---
      this.btnDelete.BackColor = System.Drawing.Color.FromArgb(248, 113, 113);
      this.btnDelete.FlatAppearance.BorderSize = 0;
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnDelete.ForeColor = System.Drawing.Color.White;
      this.btnDelete.Location = new System.Drawing.Point(15, btnY + btnHeight + 10);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnDelete.TabIndex = 13;
      this.btnDelete.Text = "删除";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

      // --- 清空按钮 ---
      this.btnClear.BackColor = System.Drawing.Color.White;
      this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnClear.FlatAppearance.BorderSize = 1;
      this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.btnClear.Location = new System.Drawing.Point(15 + btnWidth + btnSpacing, btnY + btnHeight + 10);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnClear.TabIndex = 14;
      this.btnClear.Text = "清空";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

      // --- 导入Excel按钮 ---
      this.btnImportExcel.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnImportExcel.FlatAppearance.BorderSize = 0;
      this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnImportExcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
      this.btnImportExcel.ForeColor = System.Drawing.Color.White;
      this.btnImportExcel.Location = new System.Drawing.Point(15, btnY + (btnHeight + 10) * 2);
      this.btnImportExcel.Name = "btnImportExcel";
      this.btnImportExcel.Size = new System.Drawing.Size(btnWidth, 35);
      this.btnImportExcel.TabIndex = 19;
      this.btnImportExcel.Text = "Excel批量导入";
      this.btnImportExcel.UseVisualStyleBackColor = false;
      this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);

      // --- 导出模板按钮 ---
      this.btnExportTemplate.BackColor = System.Drawing.Color.White;
      this.btnExportTemplate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnExportTemplate.FlatAppearance.BorderSize = 1;
      this.btnExportTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExportTemplate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.btnExportTemplate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.btnExportTemplate.Location = new System.Drawing.Point(15 + btnWidth + btnSpacing, btnY + (btnHeight + 10) * 2);
      this.btnExportTemplate.Name = "btnExportTemplate";
      this.btnExportTemplate.Size = new System.Drawing.Size(btnWidth, 35);
      this.btnExportTemplate.TabIndex = 20;
      this.btnExportTemplate.Text = "导出模板";
      this.btnExportTemplate.UseVisualStyleBackColor = false;
      this.btnExportTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExportTemplate.Click += new System.EventHandler(this.btnExportTemplate_Click);

      // --- 左侧面板控件添加 ---
      this.panelLeft.Controls.Add(this.lblCode);
      this.panelLeft.Controls.Add(this.txtCode);
      this.panelLeft.Controls.Add(this.lblName);
      this.panelLeft.Controls.Add(this.txtName);
      this.panelLeft.Controls.Add(this.lblSpecification);
      this.panelLeft.Controls.Add(this.txtSpecification);
      this.panelLeft.Controls.Add(this.lblManufacturer);
      this.panelLeft.Controls.Add(this.txtManufacturer);
      this.panelLeft.Controls.Add(this.lblDescription);
      this.panelLeft.Controls.Add(this.txtDescription);
      this.panelLeft.Controls.Add(this.btnAdd);
      this.panelLeft.Controls.Add(this.btnUpdate);
      this.panelLeft.Controls.Add(this.btnDelete);
      this.panelLeft.Controls.Add(this.btnClear);
      this.panelLeft.Controls.Add(this.btnImportExcel);
      this.panelLeft.Controls.Add(this.btnExportTemplate);

      // --- 右侧面板 ---
      this.panelRight.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelRight.Name = "panelRight";
      this.panelRight.Size = new System.Drawing.Size(835, 600);
      this.panelRight.TabIndex = 2;

      // --- 右侧表格布局 ---
      this.tableLayoutPanelRight.ColumnCount = 1;
      this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelRight.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
      this.tableLayoutPanelRight.Padding = new System.Windows.Forms.Padding(15);
      this.tableLayoutPanelRight.RowCount = 2;
      this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelRight.Size = new System.Drawing.Size(835, 600);
      this.tableLayoutPanelRight.TabIndex = 0;

      // --- 搜索面板 ---
      this.panelSearch.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelSearch.Location = new System.Drawing.Point(18, 18);
      this.panelSearch.Name = "panelSearch";
      this.panelSearch.Size = new System.Drawing.Size(799, 22);
      this.panelSearch.TabIndex = 0;

      // --- 搜索标签 ---
      this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblSearch.Location = new System.Drawing.Point(0, 0);
      this.lblSearch.Name = "lblSearch";
      this.lblSearch.Size = new System.Drawing.Size(60, 20);
      this.lblSearch.TabIndex = 15;
      this.lblSearch.Text = "搜索:";

      // --- 搜索输入框 ---
      this.txtSearch.BackColor = System.Drawing.Color.White;
      this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtSearch.Location = new System.Drawing.Point(65, 0);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(550, 25);
      this.txtSearch.TabIndex = 16;

      // --- 搜索按钮 ---
      this.btnSearch.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnSearch.FlatAppearance.BorderSize = 0;
      this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnSearch.ForeColor = System.Drawing.Color.White;
      this.btnSearch.Location = new System.Drawing.Point(625, -2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(80, 32);
      this.btnSearch.TabIndex = 17;
      this.btnSearch.Text = "搜索";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

      // --- 药品表格 ---
      this.dgvMedicines.AllowUserToAddRows = false;
      this.dgvMedicines.AllowUserToDeleteRows = false;
      this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvMedicines.BackgroundColor = System.Drawing.Color.White;
      this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvMedicines.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(59, 130, 246),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvMedicines.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.White,
        ForeColor = System.Drawing.Color.FromArgb(51, 65, 85),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F),
        SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254),
        SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
      };
      this.dgvMedicines.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvMedicines.EnableHeadersVisualStyles = false;
      this.dgvMedicines.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.dgvMedicines.Name = "dgvMedicines";
      this.dgvMedicines.ReadOnly = true;
      this.dgvMedicines.RowHeadersVisible = false;
      this.dgvMedicines.RowTemplate.Height = 35;
      this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvMedicines.TabIndex = 18;
      this.dgvMedicines.ColumnHeadersHeight = 40;
      this.dgvMedicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellClick);

      // --- 搜索面板控件添加 ---
      this.panelSearch.Controls.Add(this.lblSearch);
      this.panelSearch.Controls.Add(this.txtSearch);
      this.panelSearch.Controls.Add(this.btnSearch);

      // --- 右侧布局控件添加 ---
      this.tableLayoutPanelRight.Controls.Add(this.panelSearch, 0, 0);
      this.tableLayoutPanelRight.Controls.Add(this.dgvMedicines, 0, 1);

      // --- 右侧面板控件添加 ---
      this.panelRight.Controls.Add(this.tableLayoutPanelRight);

      // --- 窗体设置 ---
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 700);
      this.Controls.Add(this.panelRight);
      this.Controls.Add(this.panelLeft);
      this.Controls.Add(this.panelTop);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MedicineForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "药品管理";
      this.Load += new System.EventHandler(this.MedicineForm_Load);

      this.panelTop.ResumeLayout(false);
      this.panelLeft.ResumeLayout(false);
      this.panelRight.ResumeLayout(false);
      this.tableLayoutPanelRight.ResumeLayout(false);
      this.panelSearch.ResumeLayout(false);
      this.panelSearch.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
    private System.Windows.Forms.Panel panelSearch;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblCode;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblSpecification;
    private System.Windows.Forms.Label lblManufacturer;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.TextBox txtCode;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtSpecification;
    private System.Windows.Forms.TextBox txtManufacturer;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnImportExcel;
    private System.Windows.Forms.Button btnExportTemplate;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.DataGridView dgvMedicines;
  }
}