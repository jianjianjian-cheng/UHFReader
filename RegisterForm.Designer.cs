namespace UHFReader
{
  partial class RegisterForm
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
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblUsername = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblConfirmPassword = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtConfirmPassword = new System.Windows.Forms.TextBox();
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblHint = new System.Windows.Forms.Label();
      this.panelMain = new System.Windows.Forms.Panel();
      this.panelMain.SuspendLayout();
      this.SuspendLayout();

      // --- 主背景面板 ---
      this.panelMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(0, 0);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(450, 500);
      this.panelMain.TabIndex = 0;

      // --- 标题 ---
      this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.lblTitle.Location = new System.Drawing.Point(0, 40);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(450, 40);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "📝 用户注册";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      // --- 用户名标签 ---
      this.lblUsername.AutoSize = true;
      this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblUsername.Location = new System.Drawing.Point(60, 110);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(90, 20);
      this.lblUsername.TabIndex = 1;
      this.lblUsername.Text = "账号：";

      // --- 密码标签 ---
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblPassword.Location = new System.Drawing.Point(60, 175);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(90, 20);
      this.lblPassword.TabIndex = 3;
      this.lblPassword.Text = "密码：";

      // --- 确认密码标签 ---
      this.lblConfirmPassword.AutoSize = true;
      this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
      this.lblConfirmPassword.Location = new System.Drawing.Point(60, 240);
      this.lblConfirmPassword.Name = "lblConfirmPassword";
      this.lblConfirmPassword.Size = new System.Drawing.Size(90, 20);
      this.lblConfirmPassword.TabIndex = 5;
      this.lblConfirmPassword.Text = "确认密码：";

      // --- 用户名输入框 ---
      this.txtUsername.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtUsername.Location = new System.Drawing.Point(150, 108);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(240, 29);
      this.txtUsername.TabIndex = 2;

      // --- 密码输入框 ---
      this.txtPassword.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtPassword.Location = new System.Drawing.Point(150, 173);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '●';
      this.txtPassword.Size = new System.Drawing.Size(240, 29);
      this.txtPassword.TabIndex = 4;

      // --- 确认密码输入框 ---
      this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
      this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
      this.txtConfirmPassword.Location = new System.Drawing.Point(150, 238);
      this.txtConfirmPassword.Name = "txtConfirmPassword";
      this.txtConfirmPassword.PasswordChar = '●';
      this.txtConfirmPassword.Size = new System.Drawing.Size(240, 29);
      this.txtConfirmPassword.TabIndex = 6;

      // --- 注册按钮 ---
      this.btnRegister.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
      this.btnRegister.FlatAppearance.BorderSize = 0;
      this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
      this.btnRegister.ForeColor = System.Drawing.Color.White;
      this.btnRegister.Location = new System.Drawing.Point(60, 310);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(140, 45);
      this.btnRegister.TabIndex = 7;
      this.btnRegister.Text = "注册";
      this.btnRegister.UseVisualStyleBackColor = false;
      this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

      // --- 取消按钮 ---
      this.btnCancel.BackColor = System.Drawing.Color.White;
      this.btnCancel.FlatAppearance.BorderSize = 1;
      this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
      this.btnCancel.Location = new System.Drawing.Point(250, 310);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(140, 45);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "取消";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

      // --- 提示信息 ---
      this.lblHint.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.lblHint.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
      this.lblHint.Location = new System.Drawing.Point(30, 380);
      this.lblHint.Name = "lblHint";
      this.lblHint.Size = new System.Drawing.Size(390, 90);
      this.lblHint.TabIndex = 9;
      this.lblHint.Text = "💡 请输入您的账号和密码。密码长度建议不少于6位，两次密码必须一致。";
      this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      // --- 主面板添加控件 ---
      this.panelMain.Controls.Add(this.lblTitle);
      this.panelMain.Controls.Add(this.lblUsername);
      this.panelMain.Controls.Add(this.lblPassword);
      this.panelMain.Controls.Add(this.lblConfirmPassword);
      this.panelMain.Controls.Add(this.txtUsername);
      this.panelMain.Controls.Add(this.txtPassword);
      this.panelMain.Controls.Add(this.txtConfirmPassword);
      this.panelMain.Controls.Add(this.btnRegister);
      this.panelMain.Controls.Add(this.btnCancel);
      this.panelMain.Controls.Add(this.lblHint);

      // --- 窗体设置 ---
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 500);
      this.Controls.Add(this.panelMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RegisterForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "用户注册";

      this.panelMain.ResumeLayout(false);
      this.panelMain.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblConfirmPassword;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblHint;
    private System.Windows.Forms.Panel panelMain;
  }
}