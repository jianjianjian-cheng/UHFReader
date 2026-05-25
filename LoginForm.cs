using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using UHFReader.BLL;
using UHFReader.Common;
using UHFReader.Models;

namespace UHFReader
{
  public partial class LoginForm : Form
  {
    private UserBll _userBll = new UserBll();
    private List<string> _savedAccounts = new List<string>();
    private string _savedAccountsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saved_accounts.xml");

    public LoginForm()
    {
      InitializeComponent();
      LoadSavedAccounts();
      CenterLoginPanel();
      this.SizeChanged += LoginForm_SizeChanged;
    }

    private void LoginForm_SizeChanged(object sender, EventArgs e)
    {
      CenterLoginPanel();
    }

    private void CenterLoginPanel()
    {
      int x = (this.ClientSize.Width - panelLoginBox.Width) / 2;
      int y = (this.ClientSize.Height - panelLoginBox.Height) / 2 - 20;
      if (x < 0) x = 0;
      if (y < 0) y = 0;
      panelLoginBox.Location = new System.Drawing.Point(x, y);
    }

    private void LoadSavedAccounts()
    {
      try
      {
        if (File.Exists(_savedAccountsFile))
        {
          XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
          using (FileStream fs = new FileStream(_savedAccountsFile, FileMode.Open))
          {
            _savedAccounts = (List<string>)serializer.Deserialize(fs) ?? new List<string>();
          }
        }
      }
      catch
      {
        _savedAccounts = new List<string>();
      }
      UpdateComboBox();
    }

    private void SaveSavedAccounts()
    {
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
        using (FileStream fs = new FileStream(_savedAccountsFile, FileMode.Create))
        {
          serializer.Serialize(fs, _savedAccounts);
        }
      }
      catch { }
    }

    private void UpdateComboBox()
    {
      cmbSavedAccounts.Items.Clear();
      cmbSavedAccounts.Items.Add("-- 选择账号 --");
      foreach (string account in _savedAccounts)
      {
        cmbSavedAccounts.Items.Add(account);
      }
      cmbSavedAccounts.SelectedIndex = 0;
    }

    private void cmbSavedAccounts_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbSavedAccounts.SelectedIndex > 0)
      {
        txtUsername.Text = cmbSavedAccounts.SelectedItem.ToString();
        txtPassword.Focus();
      }
    }

    private void btnClearHistory_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("确定要清除所有保存的账号吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        _savedAccounts.Clear();
        SaveSavedAccounts();
        UpdateComboBox();
      }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      string username = txtUsername.Text.Trim();
      string password = txtPassword.Text;

      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
      {
        MessageBox.Show("用户名和密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      var user = _userBll.Login(username, password);
      if (user != null)
      {
        CurrentUser.User = user;
        SaveAccount(username);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SaveAccount(string username)
    {
      if (!_savedAccounts.Contains(username))
      {
        _savedAccounts.Insert(0, username);
        if (_savedAccounts.Count > 10)
        {
          _savedAccounts.RemoveAt(_savedAccounts.Count - 1);
        }
        SaveSavedAccounts();
        UpdateComboBox();
      }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      using (RegisterForm registerForm = new RegisterForm())
      {
        if (registerForm.ShowDialog() == DialogResult.OK)
        {
          MessageBox.Show("注册成功！请使用新账号登录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
