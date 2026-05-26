namespace UHFReader
{
  partial class LoginForm
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
      this.panelMain = new System.Windows.Forms.Panel();
      this.cmbSavedAccounts = new System.Windows.Forms.ComboBox();
      this.btnClearHistory = new System.Windows.Forms.Button();
      this.panelLoginBox = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblSubtitle = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblUsernameIcon = new System.Windows.Forms.Label();
      this.lblPasswordIcon = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.panelMain.SuspendLayout();
      this.panelLoginBox.SuspendLayout();
      this.SuspendLayout();

      // --- 主背景面板 - 极简科技感 ---
      this.panelMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(0, 0);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(800, 600);
      this.panelMain.TabIndex = 0;

      // --- 历史账号下拉框 ---
      this.cmbSavedAccounts.BackColor = System.Drawing.Color.White;
      this.cmbSavedAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSavedAccounts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.cmbSavedAccounts.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.cmbSavedAccounts.FormattingEnabled = true;
      this.cmbSavedAccounts.Location = new System.Drawing.Point(30, 30);
      this.cmbSavedAccounts.Name = "cmbSavedAccounts";
      this.cmbSavedAccounts.Size = new System.Drawing.Size(180, 28);
      this.cmbSavedAccounts.TabIndex = 10;
      this.cmbSavedAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbSavedAccounts_SelectedIndexChanged);

      // --- 清除历史按钮 ---
      this.btnClearHistory.BackColor = System.Drawing.Color.White;
      this.btnClearHistory.FlatAppearance.BorderSize = 1;
      this.btnClearHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClearHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.btnClearHistory.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.btnClearHistory.Location = new System.Drawing.Point(220, 30);
      this.btnClearHistory.Name = "btnClearHistory";
      this.btnClearHistory.Size = new System.Drawing.Size(80, 28);
      this.btnClearHistory.TabIndex = 11;
      this.btnClearHistory.Text = "清除历史";
      this.btnClearHistory.UseVisualStyleBackColor = false;
      this.btnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);

      // --- 登录卡片面板 - 白色卡片 + 柔和效果 ---
      this.panelLoginBox.BackColor = System.Drawing.Color.White;
      this.panelLoginBox.Location = new System.Drawing.Point(200, 80);
      this.panelLoginBox.Name = "panelLoginBox";
      this.panelLoginBox.Size = new System.Drawing.Size(400, 440);
      this.panelLoginBox.TabIndex = 1;

      // --- 标题 - 现代化 ---
      this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.lblTitle.Location = new System.Drawing.Point(0, 40);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(400, 45);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "🏥 RFID药品管理系统";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      // --- 副标题 ---
      this.lblSubtitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.lblSubtitle.Location = new System.Drawing.Point(0, 90);
      this.lblSubtitle.Name = "lblSubtitle";
      this.lblSubtitle.Size = new System.Drawing.Size(400, 25);
      this.lblSubtitle.TabIndex = 1;
      this.lblSubtitle.Text = "医药仓储RFID智能管理系统";
      this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      // --- 用户名图标 ---
      this.lblUsernameIcon.AutoSize = false;
      this.lblUsernameIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
      this.lblUsernameIcon.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.lblUsernameIcon.Location = new System.Drawing.Point(40, 140);
      this.lblUsernameIcon.Name = "lblUsernameIcon";
      this.lblUsernameIcon.Size = new System.Drawing.Size(35, 35);
      this.lblUsernameIcon.TabIndex = 2;
      this.lblUsernameIcon.Text = "👤";
      this.lblUsernameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      // --- 用户名输入框 ---
      this.txtUsername.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtUsername.Location = new System.Drawing.Point(80, 140);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(280, 35);
      this.txtUsername.TabIndex = 3;
      this.txtUsername.Text = "admin";

      // --- 密码图标 ---
      this.lblPasswordIcon.AutoSize = false;
      this.lblPasswordIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
      this.lblPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.lblPasswordIcon.Location = new System.Drawing.Point(40, 200);
      this.lblPasswordIcon.Name = "lblPasswordIcon";
      this.lblPasswordIcon.Size = new System.Drawing.Size(35, 35);
      this.lblPasswordIcon.TabIndex = 5;
      this.lblPasswordIcon.Text = "🔒";
      this.lblPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      // --- 密码输入框 ---
      this.txtPassword.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtPassword.Location = new System.Drawing.Point(80, 200);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '●';
      this.txtPassword.Size = new System.Drawing.Size(280, 35);
      this.txtPassword.TabIndex = 6;
      this.txtPassword.Text = "admin";

      // --- 登录按钮 - 科技蓝 ---
      this.btnLogin.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnLogin.FlatAppearance.BorderSize = 0;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(40, 260);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(320, 45);
      this.btnLogin.TabIndex = 8;
      this.btnLogin.Text = "登录";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

      // --- 注册按钮 - 清新绿 ---
      this.btnRegister.BackColor = System.Drawing.Color.White;
      this.btnRegister.FlatAppearance.BorderSize = 1;
      this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnRegister.Location = new System.Drawing.Point(40, 320);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(150, 40);
      this.btnRegister.TabIndex = 9;
      this.btnRegister.Text = "📝 注册账号";
      this.btnRegister.UseVisualStyleBackColor = false;
      this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

      // --- 取消/退出按钮 ---
      this.btnCancel.BackColor = System.Drawing.Color.White;
      this.btnCancel.FlatAppearance.BorderSize = 1;
      this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.btnCancel.Location = new System.Drawing.Point(210, 320);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(150, 40);
      this.btnCancel.TabIndex = 12;
      this.btnCancel.Text = "退出";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

      // --- 登录框控件添加 ---
      this.panelLoginBox.Controls.Add(this.lblTitle);
      this.panelLoginBox.Controls.Add(this.lblSubtitle);
      this.panelLoginBox.Controls.Add(this.lblUsernameIcon);
      this.panelLoginBox.Controls.Add(this.txtUsername);
      this.panelLoginBox.Controls.Add(this.lblPasswordIcon);
      this.panelLoginBox.Controls.Add(this.txtPassword);
      this.panelLoginBox.Controls.Add(this.btnLogin);
      this.panelLoginBox.Controls.Add(this.btnRegister);
      this.panelLoginBox.Controls.Add(this.btnCancel);

      // --- 底部描述 ---
      this.lblDescription.AutoSize = false;
      this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
      this.lblDescription.Location = new System.Drawing.Point(50, 540);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(700, 50);
      this.lblDescription.TabIndex = 10;
      this.lblDescription.Text = "💡 药品管理 • 标签绑定 • 出入库管理 • 库存查询 • 记录查询 • RFID读写";
      this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;

      // --- 主面板控件 ---
      this.panelMain.Controls.Add(this.cmbSavedAccounts);
      this.panelMain.Controls.Add(this.btnClearHistory);
      this.panelMain.Controls.Add(this.panelLoginBox);
      this.panelMain.Controls.Add(this.lblDescription);

      // --- 窗体设置 ---
      this.AcceptButton = this.btnLogin;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 600);
      this.Controls.Add(this.panelMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RFID药品管理系统 - 登录";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

      this.panelMain.ResumeLayout(false);
      this.panelLoginBox.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Panel panelLoginBox;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblUsernameIcon;
    private System.Windows.Forms.Label lblPasswordIcon;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.ComboBox cmbSavedAccounts;
    private System.Windows.Forms.Button btnClearHistory;
  }
}