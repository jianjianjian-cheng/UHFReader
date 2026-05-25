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
      this.panelLoginBox = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblSubtitle = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblUsernameIcon = new System.Windows.Forms.Label();
      this.lblPasswordIcon = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.panelMain.SuspendLayout();
      this.panelLoginBox.SuspendLayout();
      this.SuspendLayout();

      this.panelMain.BackColor = System.Drawing.Color.FromArgb(45, 55, 75);
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(0, 0);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(800, 600);
      this.panelMain.TabIndex = 0;

      this.panelLoginBox.BackColor = System.Drawing.Color.FromArgb(55, 65, 90);
      this.panelLoginBox.Location = new System.Drawing.Point(200, 100);
      this.panelLoginBox.Name = "panelLoginBox";
      this.panelLoginBox.Size = new System.Drawing.Size(400, 400);
      this.panelLoginBox.TabIndex = 1;

      this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(0, 40);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(400, 50);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "🏥 RFID药品管理系统";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      this.lblSubtitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(150, 160, 180);
      this.lblSubtitle.Location = new System.Drawing.Point(0, 95);
      this.lblSubtitle.Name = "lblSubtitle";
      this.lblSubtitle.Size = new System.Drawing.Size(400, 25);
      this.lblSubtitle.TabIndex = 1;
      this.lblSubtitle.Text = "医药仓储RFID智能管理系统";
      this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      this.lblUsernameIcon.AutoSize = false;
      this.lblUsernameIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
      this.lblUsernameIcon.ForeColor = System.Drawing.Color.FromArgb(150, 160, 180);
      this.lblUsernameIcon.Location = new System.Drawing.Point(40, 150);
      this.lblUsernameIcon.Name = "lblUsernameIcon";
      this.lblUsernameIcon.Size = new System.Drawing.Size(40, 40);
      this.lblUsernameIcon.TabIndex = 2;
      this.lblUsernameIcon.Text = "👤";
      this.lblUsernameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      this.txtUsername.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
      this.txtUsername.ForeColor = System.Drawing.Color.White;
      this.txtUsername.Location = new System.Drawing.Point(85, 155);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(275, 29);
      this.txtUsername.TabIndex = 3;
      this.txtUsername.Text = "admin";
      this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);


      System.Windows.Forms.Panel panelUsernameLine = new System.Windows.Forms.Panel();
      panelUsernameLine.BackColor = System.Drawing.Color.FromArgb(90, 100, 130);
      panelUsernameLine.Location = new System.Drawing.Point(40, 190);
      panelUsernameLine.Name = "panelUsernameLine";
      panelUsernameLine.Size = new System.Drawing.Size(320, 1);
      panelUsernameLine.TabIndex = 4;

      this.lblPasswordIcon.AutoSize = false;
      this.lblPasswordIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
      this.lblPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(150, 160, 180);
      this.lblPasswordIcon.Location = new System.Drawing.Point(40, 210);
      this.lblPasswordIcon.Name = "lblPasswordIcon";
      this.lblPasswordIcon.Size = new System.Drawing.Size(40, 40);
      this.lblPasswordIcon.TabIndex = 5;
      this.lblPasswordIcon.Text = "🔒";
      this.lblPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      this.txtPassword.BackColor = System.Drawing.Color.FromArgb(70, 80, 110);
      this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
      this.txtPassword.ForeColor = System.Drawing.Color.White;
      this.txtPassword.Location = new System.Drawing.Point(85, 215);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '●';
      this.txtPassword.Size = new System.Drawing.Size(275, 29);
      this.txtPassword.TabIndex = 6;
      this.txtPassword.Text = "admin";
      this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);

      System.Windows.Forms.Panel panelPasswordLine = new System.Windows.Forms.Panel();
      panelPasswordLine.BackColor = System.Drawing.Color.FromArgb(90, 100, 130);
      panelPasswordLine.Location = new System.Drawing.Point(40, 250);
      panelPasswordLine.Name = "panelPasswordLine";
      panelPasswordLine.Size = new System.Drawing.Size(320, 1);
      panelPasswordLine.TabIndex = 7;

      this.btnLogin.BackColor = System.Drawing.Color.FromArgb(70, 130, 200);
      this.btnLogin.FlatAppearance.BorderSize = 0;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(40, 290);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(320, 45);
      this.btnLogin.TabIndex = 8;
      this.btnLogin.Text = "登 录";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(230, 80, 80);
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(40, 345);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(320, 35);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "退 出";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

      this.panelLoginBox.Controls.Add(this.lblTitle);
      this.panelLoginBox.Controls.Add(this.lblSubtitle);
      this.panelLoginBox.Controls.Add(this.lblUsernameIcon);
      this.panelLoginBox.Controls.Add(this.txtUsername);
      this.panelLoginBox.Controls.Add(panelUsernameLine);
      this.panelLoginBox.Controls.Add(this.lblPasswordIcon);
      this.panelLoginBox.Controls.Add(this.txtPassword);
      this.panelLoginBox.Controls.Add(panelPasswordLine);
      this.panelLoginBox.Controls.Add(this.btnLogin);
      this.panelLoginBox.Controls.Add(this.btnCancel);

      this.lblDescription.AutoSize = false;
      this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
      this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
      this.lblDescription.Location = new System.Drawing.Point(50, 520);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(700, 60);
      this.lblDescription.TabIndex = 10;
      this.lblDescription.Text = "📋 系统功能：\r\n" +
        "• 药品管理：添加、编辑、删除药品信息\r\n" +
        "• 标签绑定：将RFID标签与药品信息绑定\r\n" +
        "• 出入库管理：记录药品入库和出库操作\r\n" +
        "• 库存查询：实时查看药品库存数量\r\n" +
        "• 记录查询：追溯所有出入库历史记录\r\n" +
        "• RFID读写：支持标签扫描、读取和写入";
      this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;

      this.panelMain.Controls.Add(this.panelLoginBox);
      this.panelMain.Controls.Add(this.lblDescription);

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
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblDescription;
  }
}