using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UHFReader.Common;

namespace UHFReader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // 显示登录窗体
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // 登录成功，显示主窗体
                MainForm mainForm = new MainForm();
                while (mainForm.ShowDialog() == DialogResult.OK)
                {
                    // 退出登录，重新显示登录窗体
                    CurrentUser.User = null;
                    loginForm = new LoginForm();
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                    mainForm = new MainForm();
                }
            }
        }
    }
}
