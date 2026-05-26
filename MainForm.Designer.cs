namespace UHFReader
{
    partial class MainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMinimizeRestore = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnMedicineManage = new System.Windows.Forms.Button();
            this.btnTagBind = new System.Windows.Forms.Button();
            this.btnInOut = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnRfidReader = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();

            // --- 顶部面板 - 现代科技感 ---
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1920, 70);
            this.panelTop.TabIndex = 0;

            // --- 标题 ---
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏥 RFID药品管理系统";

            // --- 退出按钮 ---
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(248, 113, 113);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1750, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "退出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // --- 还原按钮 ---
            this.btnMinimizeRestore.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnMinimizeRestore.FlatAppearance.BorderSize = 0;
            this.btnMinimizeRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeRestore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimizeRestore.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeRestore.Location = new System.Drawing.Point(1640, 15);
            this.btnMinimizeRestore.Name = "btnMinimizeRestore";
            this.btnMinimizeRestore.Size = new System.Drawing.Size(100, 40);
            this.btnMinimizeRestore.TabIndex = 9;
            this.btnMinimizeRestore.Text = "❐ 还原";
            this.btnMinimizeRestore.UseVisualStyleBackColor = false;
            this.btnMinimizeRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeRestore.Click += new System.EventHandler(this.btnMinimizeRestore_Click);

            // --- 欢迎标签 ---
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblWelcome.Location = new System.Drawing.Point(1500, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(130, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // --- 顶部面板控件添加 ---
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnMinimizeRestore);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);

            // --- 侧边栏 ---
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 1030);
            this.panelSidebar.TabIndex = 1;

            int buttonY = 30;
            int buttonHeight = 55;
            int buttonSpacing = 15;

            // --- 药品管理按钮 ---
            this.btnMedicineManage.BackColor = System.Drawing.Color.White;
            this.btnMedicineManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnMedicineManage.FlatAppearance.BorderSize = 1;
            this.btnMedicineManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineManage.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnMedicineManage.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnMedicineManage.Location = new System.Drawing.Point(15, buttonY);
            this.btnMedicineManage.Name = "btnMedicineManage";
            this.btnMedicineManage.Size = new System.Drawing.Size(190, buttonHeight);
            this.btnMedicineManage.TabIndex = 2;
            this.btnMedicineManage.Text = "📦 药品管理";
            this.btnMedicineManage.UseVisualStyleBackColor = false;
            this.btnMedicineManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicineManage.Click += new System.EventHandler(this.btnMedicineManage_Click);

            // --- 标签绑定按钮 ---
            buttonY += buttonHeight + buttonSpacing;
            this.btnTagBind.BackColor = System.Drawing.Color.White;
            this.btnTagBind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnTagBind.FlatAppearance.BorderSize = 1;
            this.btnTagBind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTagBind.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnTagBind.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnTagBind.Location = new System.Drawing.Point(15, buttonY);
            this.btnTagBind.Name = "btnTagBind";
            this.btnTagBind.Size = new System.Drawing.Size(190, buttonHeight);
            this.btnTagBind.TabIndex = 3;
            this.btnTagBind.Text = "🏷️ 标签绑定";
            this.btnTagBind.UseVisualStyleBackColor = false;
            this.btnTagBind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTagBind.Click += new System.EventHandler(this.btnTagBind_Click);

            // --- 出入库管理按钮 ---
            buttonY += buttonHeight + buttonSpacing;
            this.btnInOut.BackColor = System.Drawing.Color.White;
            this.btnInOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnInOut.FlatAppearance.BorderSize = 1;
            this.btnInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnInOut.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnInOut.Location = new System.Drawing.Point(15, buttonY);
            this.btnInOut.Name = "btnInOut";
            this.btnInOut.Size = new System.Drawing.Size(190, buttonHeight);
            this.btnInOut.TabIndex = 4;
            this.btnInOut.Text = "📥📤 出入库管理";
            this.btnInOut.UseVisualStyleBackColor = false;
            this.btnInOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInOut.Click += new System.EventHandler(this.btnInOut_Click);

            // --- 库存查询按钮 ---
            buttonY += buttonHeight + buttonSpacing;
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnInventory.FlatAppearance.BorderSize = 1;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnInventory.Location = new System.Drawing.Point(15, buttonY);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(190, buttonHeight);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "🔍 库存查询";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);

            // --- 出入库记录按钮 ---
            buttonY += buttonHeight + buttonSpacing;
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnTransaction.FlatAppearance.BorderSize = 1;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnTransaction.Location = new System.Drawing.Point(15, buttonY);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(190, buttonHeight);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.Text = "📋 出入库记录";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);

            // --- RFID读写器按钮 ---
            buttonY += buttonHeight + buttonSpacing;
            this.btnRfidReader.BackColor = System.Drawing.Color.White;
            this.btnRfidReader.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRfidReader.FlatAppearance.BorderSize = 1;
            this.btnRfidReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRfidReader.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnRfidReader.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRfidReader.Location = new System.Drawing.Point(15, buttonY);
            this.btnRfidReader.Name = "btnRfidReader";
            this.btnRfidReader.Size = new System.Drawing.Size(190, buttonHeight);
            this.btnRfidReader.TabIndex = 7;
            this.btnRfidReader.Text = "📡 RFID读写器";
            this.btnRfidReader.UseVisualStyleBackColor = false;
            this.btnRfidReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRfidReader.Click += new System.EventHandler(this.btnRfidReader_Click);

            // --- 侧边栏控件添加 ---
            this.panelSidebar.Controls.Add(this.btnMedicineManage);
            this.panelSidebar.Controls.Add(this.btnTagBind);
            this.panelSidebar.Controls.Add(this.btnInOut);
            this.panelSidebar.Controls.Add(this.btnInventory);
            this.panelSidebar.Controls.Add(this.btnTransaction);
            this.panelSidebar.Controls.Add(this.btnRfidReader);

            // --- 内容区域 ---
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1700, 1030);
            this.panelContent.TabIndex = 2;

            // --- 窗体设置 ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1100);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID药品管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.panelTop.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMedicineManage;
        private System.Windows.Forms.Button btnTagBind;
        private System.Windows.Forms.Button btnInOut;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnRfidReader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMinimizeRestore;
    }
}