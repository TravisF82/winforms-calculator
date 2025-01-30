using CalculatorProject.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject.Controls
{
    public partial class Settings : UserControl
    {
        private Color dark = ColorTranslator.FromHtml("#202020");

        public delegate void AppAppearanceHandler();
        public event AppAppearanceHandler AppAppearanceChanged;

        public delegate void SideBarToggledHandler();
        public event SideBarToggledHandler SideBarToggled;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            getSavedTheme();
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbThemes.SelectedIndex)
            {
                case 0:
                    UserConfig.Theme = "light";
                    setLightTheme();
                    break;
                case 1:
                    UserConfig.Theme = "dark";
                    setDarkTheme();
                    break;
                case 2:
                    UserConfig.Theme = "blue";
                    break;
                case 3:
                    UserConfig.Theme = "system";
                    var theme = Functions.getUserSystemTheme();
                    if (theme == "Light")
                    {
                        setLightTheme();
                    }
                    else if (theme == "Dark")
                    {
                        setDarkTheme();
                    }
                    break;
            }
            AppAppearanceChanged?.Invoke();
        }

        private void getSavedTheme()
        {
            switch (UserConfig.Theme)
            {
                case "light":
                    cmbThemes.SelectedIndex = 0;
                    setLightTheme();
                    break;
                case "dark":
                    cmbThemes.SelectedIndex = 1;
                    setDarkTheme();
                    break;
                case "blue":
                    cmbThemes.SelectedIndex = 2;
                    break;
                case "system":
                    cmbThemes.SelectedIndex = 3;
                    break;
                default:
                    cmbThemes.SelectedIndex = 0;
                    break;
            }
        }

        private void setLightTheme()
        {
            this.BackColor = Color.White;
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.ForeColor = Color.Black;
            }
            lblGitHubLink.ForeColor = Color.Coral;
        }

        private void setDarkTheme()
        {
            this.BackColor = ColorTranslator.FromHtml("#202020");
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.ForeColor = Color.White;
            }
            cmbThemes.ForeColor = Color.Black;
            lblGitHubLink.ForeColor = Color.Coral;
        }

        private void lblGitHubLink_Click(object sender, EventArgs e)
        {
            string page = "https://github.com/TravisF82/winforms-calculator";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = page,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open page");
            }
        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            SideBarToggled?.Invoke();
        }
    }
}
