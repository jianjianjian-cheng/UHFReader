using System;
using System.Drawing;
using System.Windows.Forms;

namespace UHFReader.Common
{
    public static class DesignHelper
    {
        public static readonly Color PrimaryDark = Color.FromArgb(45, 55, 75);
        public static readonly Color SecondaryDark = Color.FromArgb(55, 65, 90);
        public static readonly Color SidebarDark = Color.FromArgb(35, 45, 65);
        public static readonly Color ContentDark = Color.FromArgb(50, 60, 85);
        public static readonly Color ButtonBlue = Color.FromArgb(70, 130, 200);
        public static readonly Color ButtonRed = Color.FromArgb(230, 80, 80);
        public static readonly Color TextLight = Color.FromArgb(180, 190, 210);
        public static readonly Color TextMuted = Color.FromArgb(150, 160, 180);
        public static readonly Color InputBg = Color.FromArgb(70, 80, 110);
        public static readonly Color LineColor = Color.FromArgb(90, 100, 130);
        public static readonly Font TitleFont = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
        public static readonly Font ButtonFont = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
        public static readonly Font LabelFont = new Font("Microsoft YaHei UI", 9F);
        public static readonly Font InputFont = new Font("Microsoft YaHei UI", 10F);

        public static void ApplyModernStyle(Form form)
        {
            form.BackColor = PrimaryDark;
            form.ForeColor = TextLight;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
        }

        public static Panel CreateTopPanel()
        {
            var panel = new Panel
            {
                BackColor = PrimaryDark,
                Dock = DockStyle.Top,
                Height = 70
            };
            return panel;
        }

        public static Panel CreateSidebarPanel()
        {
            var panel = new Panel
            {
                BackColor = SidebarDark,
                Dock = DockStyle.Left,
                Width = 220
            };
            return panel;
        }

        public static Panel CreateContentPanel()
        {
            var panel = new Panel
            {
                BackColor = ContentDark,
                Dock = DockStyle.Fill
            };
            return panel;
        }

        public static Label CreateTitle(string text, Point location)
        {
            return new Label
            {
                Text = text,
                Font = TitleFont,
                ForeColor = Color.White,
                Location = location,
                AutoSize = true
            };
        }

        public static Label CreateWelcomeLabel(string text, Point location)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Microsoft YaHei UI", 11F),
                ForeColor = TextMuted,
                Location = location,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleRight
            };
        }

        public static Button CreateModernButton(string text, Point location, Size size, Color? backColor = null)
        {
            var btn = new Button
            {
                Text = text,
                Font = ButtonFont,
                ForeColor = Color.White,
                Location = location,
                Size = size,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor ?? ButtonBlue;
            return btn;
        }

        public static TextBox CreateModernTextBox(Point location, Size size, string placeholder = "")
        {
            return new TextBox
            {
                Location = location,
                Size = size,
                Font = InputFont,
                BackColor = InputBg,
                ForeColor = TextLight,
                BorderStyle = BorderStyle.None,
                Text = placeholder
            };
        }

        public static Panel CreateInputLine(Point location, int width)
        {
            return new Panel
            {
                Location = location,
                Size = new Size(width, 1),
                BackColor = LineColor
            };
        }

        public static DataGridView CreateModernDataGrid(Point location, Size size)
        {
            var dgv = new DataGridView
            {
                Location = location,
                Size = size,
                BackgroundColor = SecondaryDark,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = PrimaryDark,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = SecondaryDark,
                    ForeColor = TextLight,
                    Font = InputFont,
                    SelectionBackColor = ButtonBlue,
                    SelectionForeColor = Color.White
                },
                EnableHeadersVisualStyles = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeight = 40,
                RowTemplate = { Height = 35 }
            };
            return dgv;
        }

        public static GroupBox CreateModernGroupBox(string text, Point location, Size size)
        {
            return new GroupBox
            {
                Text = text,
                Location = location,
                Size = size,
                Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold),
                ForeColor = TextLight,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat
            };
        }

        public static Label CreateLabel(string text, Point location, Font font = null, Color? foreColor = null)
        {
            return new Label
            {
                Text = text,
                Location = location,
                Font = font ?? LabelFont,
                ForeColor = foreColor ?? TextLight,
                AutoSize = true
            };
        }
    }
}