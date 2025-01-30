using CalculatorProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject.Controls
{
    public partial class SideBar : UserControl
    {
        public delegate void StandardModeHandler();
        public event StandardModeHandler StandardModeSet;

        public delegate void SettingsModeHandler();
        public event SettingsModeHandler SettingsModeSet;

        public delegate void ScientificModeHandler();
        public event ScientificModeHandler ScientificModeSet;

        public delegate void SideBarToggledHandler();
        public event SideBarToggledHandler SideBarToggled;

        public delegate void CurrencyModeHandler();
        public event CurrencyModeHandler CurrencyModeSet;

        private Color darkBackground = ColorTranslator.FromHtml("#202020");

        public SideBar()
        {
            InitializeComponent();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            switch (UserConfig.Theme)
            {
                case "light":
                    setLightMode();
                    break;
                case "dark":
                    setDarkMode();
                    break;
                case "system":
                    var theme = Functions.getUserSystemTheme();
                    if (theme == "Light")
                    {
                        setLightMode();
                    }
                    else if (theme == "Dark")
                    {
                        setDarkMode();
                    }
                    break;
            }
        }

        public void setLightMode()
        {
            this.BackColor = Color.White;
            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }
        }

        public void setDarkMode()
        {
            this.BackColor = darkBackground;
            foreach (Control control in this.Controls)
            {
                control.BackColor = darkBackground;
                control.ForeColor = Color.White;
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            StandardModeSet?.Invoke();
            SideBarToggled?.Invoke();
        }

        private void btnScientific_Click(object sender, EventArgs e)
        {
            ScientificModeSet?.Invoke();
            SideBarToggled?.Invoke();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsModeSet?.Invoke();
            SideBarToggled?.Invoke();
        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            SideBarToggled?.Invoke();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            CurrencyModeSet?.Invoke();
            SideBarToggled?.Invoke();
        }
    }
}
