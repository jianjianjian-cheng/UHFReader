namespace UHFReader
{
  partial class InventoryForm
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
      this.lblSearch = new System.Windows.Forms.Label();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.dgvInventory = new System.Windows.Forms.DataGridView();
      this.panelTop.SuspendLayout();
      this.tableLayoutPanelMain.SuspendLayout();
      this.panelControls.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
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
      this.lblTitle.Size = new System.Drawing.Size(200, 36);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "🔍 库存查询";

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

      // --- 主布局面板 ---
      this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
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

      // --- 控制面板 ---
      this.panelControls.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControls.Location = new System.Drawing.Point(18, 18);
      this.panelControls.Name = "panelControls";
      this.panelControls.Size = new System.Drawing.Size(1164, 36);
      this.panelControls.TabIndex = 0;

      // --- 搜索标签 ---
      this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblSearch.Location = new System.Drawing.Point(0, 0);
      this.lblSearch.Name = "lblSearch";
      this.lblSearch.Size = new System.Drawing.Size(80, 25);
      this.lblSearch.TabIndex = 0;
      this.lblSearch.Text = "搜索药品:";

      // --- 搜索框 ---
      this.txtSearch.BackColor = System.Drawing.Color.White;
      this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtSearch.Location = new System.Drawing.Point(85, 0);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(450, 28);
      this.txtSearch.TabIndex = 1;
      this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);

      // --- 搜索按钮 ---
      this.btnSearch.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnSearch.FlatAppearance.BorderSize = 0;
      this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnSearch.ForeColor = System.Drawing.Color.White;
      this.btnSearch.Location = new System.Drawing.Point(545, -2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(90, 35);
      this.btnSearch.TabIndex = 2;
      this.btnSearch.Text = "搜索";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

      // --- 刷新按钮 ---
      this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnRefresh.FlatAppearance.BorderSize = 0;
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(1025, -2);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(90, 35);
      this.btnRefresh.TabIndex = 3;
      this.btnRefresh.Text = "刷新";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

      // --- 库存表格 ---
      this.dgvInventory.AllowUserToAddRows = false;
      this.dgvInventory.AllowUserToDeleteRows = false;
      this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
      this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvInventory.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.FromArgb(59, 130, 246),
        ForeColor = System.Drawing.Color.White,
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold),
        Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      };
      this.dgvInventory.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
      {
        BackColor = System.Drawing.Color.White,
        ForeColor = System.Drawing.Color.FromArgb(51, 65, 85),
        Font = new System.Drawing.Font("Microsoft YaHei UI", 9F),
        SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254),
        SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
      };
      this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvInventory.EnableHeadersVisualStyles = false;
      this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.dgvInventory.Name = "dgvInventory";
      this.dgvInventory.ReadOnly = true;
      this.dgvInventory.RowHeadersVisible = false;
      this.dgvInventory.RowTemplate.Height = 35;
      this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvInventory.TabIndex = 4;
      this.dgvInventory.ColumnHeadersHeight = 40;

      // --- 控制面板控件添加 ---
      this.panelControls.Controls.Add(this.lblSearch);
      this.panelControls.Controls.Add(this.txtSearch);
      this.panelControls.Controls.Add(this.btnSearch);
      this.panelControls.Controls.Add(this.btnRefresh);

      // --- 主面板控件添加 ---
      this.tableLayoutPanelMain.Controls.Add(this.panelControls, 0, 0);
      this.tableLayoutPanelMain.Controls.Add(this.dgvInventory, 0, 1);

      // --- 窗体设置 ---
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 700);
      this.Controls.Add(this.tableLayoutPanelMain);
      this.Controls.Add(this.panelTop);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "InventoryForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "库存查询";
      this.Load += new System.EventHandler(this.InventoryForm_Load);

      this.panelTop.ResumeLayout(false);
      this.tableLayoutPanelMain.ResumeLayout(false);
      this.panelControls.ResumeLayout(false);
      this.panelControls.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    private System.Windows.Forms.Panel panelControls;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.DataGridView dgvInventory;
  }
}
