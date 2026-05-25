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
      this.panelMain = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblUsername = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblConfirmPassword = new System.Windows.Forms.Label();
      this.txtConfirmPassword = new System.Windows.Forms.TextBox();
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.panelMain.SuspendLayout();
      this.SuspendLayout();

      this.panelMain.BackColor = System.Drawing.Color.FromArgb(45, 55, 75);
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(0, 0);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(400, 350);
      this.panelMain.TabIndex = 0;

      this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(0, 25);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(400, 40);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "📝 用户注册";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      int labelX = 40;
      int inputX = 130;
      int labelWidth = 90;
      int inputWidth = 230;
      int labelY = 85;
      int inputY = 85;
      int spacing = 60;

      this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblUsername.Location = new System.Drawing.Point(labelX, labelY);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(labelWidth, 25);
      this.lblUsername.TabIndex = 1;
      this.lblUsername.Text = "用户名：";

      this.txtUsername.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
      this.txtUsername.ForeColor = System.Drawing.Color.White;
      this.txtUsername.Location = new System.Drawing.Point(inputX, inputY);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(inputWidth, 29);
      this.txtUsername.TabIndex = 2;

      System.Windows.Forms.Panel usernameLine = new System.Windows.Forms.Panel();
      usernameLine.BackColor = System.Drawing.Color.FromArgb(90, 100, 130);
      usernameLine.Location = new System.Drawing.Point(inputX, inputY + 32);
      usernameLine.Name = "usernameLine";
      usernameLine.Size = new System.Drawing.Size(inputWidth, 1);
      usernameLine.TabIndex = 3;

      labelY += spacing;
      inputY += spacing;
      this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblPassword.Location = new System.Drawing.Point(labelX, labelY);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(labelWidth, 25);
      this.lblPassword.TabIndex = 4;
      this.lblPassword.Text = "密码：";

      this.txtPassword.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
      this.txtPassword.ForeColor = System.Drawing.Color.White;
      this.txtPassword.Location = new System.Drawing.Point(inputX, inputY);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '●';
      this.txtPassword.Size = new System.Drawing.Size(inputWidth, 29);
      this.txtPassword.TabIndex = 5;

      System.Windows.Forms.Panel passwordLine = new System.Windows.Forms.Panel();
      passwordLine.BackColor = System.Drawing.Color.FromArgb(90, 100, 130);
      passwordLine.Location = new System.Drawing.Point(inputX, inputY + 32);
      passwordLine.Name = "passwordLine";
      passwordLine.Size = new System.Drawing.Size(inputWidth, 1);
      passwordLine.TabIndex = 6;

      labelY += spacing;
      inputY += spacing;
      this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
      this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
      this.lblConfirmPassword.Location = new System.Drawing.Point(labelX, labelY);
      this.lblConfirmPassword.Name = "lblConfirmPassword";
      this.lblConfirmPassword.Size = new System.Drawing.Size(labelWidth + 40, 25);
      this.lblConfirmPassword.TabIndex = 7;
      this.lblConfirmPassword.Text = "确认密码：";

      this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
      this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
      this.txtConfirmPassword.Location = new System.Drawing.Point(inputX, inputY);
      this.txtConfirmPassword.Name = "txtConfirmPassword";
      this.txtConfirmPassword.PasswordChar = '●';
      this.txtConfirmPassword.Size = new System.Drawing.Size(inputWidth, 29);
      this.txtConfirmPassword.TabIndex = 8;

      System.Windows.Forms.Panel confirmLine = new System.Windows.Forms.Panel();
      confirmLine.BackColor = System.Drawing.Color.FromArgb(90, 100, 130);
      confirmLine.Location = new System.Drawing.Point(inputX, inputY + 32);
      confirmLine.Name = "confirmLine";
      confirmLine.Size = new System.Drawing.Size(inputWidth, 1);
      confirmLine.TabIndex = 9;

      int btnY = 255;
      int btnWidth = 135;
      int btnHeight = 40;

      this.btnRegister.BackColor = System.Drawing.Color.FromArgb(100, 180, 100);
      this.btnRegister.FlatAppearance.BorderSize = 0;
      this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
      this.btnRegister.ForeColor = System.Drawing.Color.White;
      this.btnRegister.Location = new System.Drawing.Point(50, btnY);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnRegister.TabIndex = 10;
      this.btnRegister.Text = "注 册";
      this.btnRegister.UseVisualStyleBackColor = false;
      this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(230, 80, 80);
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(215, btnY);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(btnWidth, btnHeight);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "取 消";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

      this.panelMain.Controls.Add(this.lblTitle);
      this.panelMain.Controls.Add(this.lblUsername);
      this.panelMain.Controls.Add(this.txtUsername);
      this.panelMain.Controls.Add(usernameLine);
      this.panelMain.Controls.Add(this.lblPassword);
      this.panelMain.Controls.Add(this.txtPassword);
      this.panelMain.Controls.Add(passwordLine);
      this.panelMain.Controls.Add(this.lblConfirmPassword);
      this.panelMain.Controls.Add(this.txtConfirmPassword);
      this.panelMain.Controls.Add(confirmLine);
      this.panelMain.Controls.Add(this.btnRegister);
      this.panelMain.Controls.Add(this.btnCancel);

      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(400, 350);
      this.Controls.Add(this.panelMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RegisterForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "用户注册";
      this.panelMain.ResumeLayout(false);
      this.panelMain.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblConfirmPassword;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnCancel;
  }
}