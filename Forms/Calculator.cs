using CalculatorProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using System.Text.Json.Nodes;
using CalculatorProject.Controls;

namespace CalculatorProject.Forms
{
    public partial class Calculator : Form
    {
        private SideBar sidebar;

        private Settings settingsScreen;
        private History historyScreen;
        private Memory memoryScreen;
        private Currency currencyScreen;

        public Calculator()
        {
            InitializeComponent();
            txtDisplay.BackColor = System.Drawing.ColorTranslator.FromHtml("#202020");
            btnExecute.BackColor = System.Drawing.ColorTranslator.FromHtml("#f38064");
            txtDisplay.Location = new System.Drawing.Point((this.ClientSize.Width - txtDisplay.Width) / 2, 74);
            lblCalc.Text = "";

            sidebar = new SideBar();
            sidebar.Dock = DockStyle.Left;
            sidebar.Size = sidebar.MinimumSize;
            sidebar.StandardModeSet += setStandardMode;
            sidebar.ScientificModeSet += setScientificMode;
            sidebar.SettingsModeSet += setSettingsMode;
            sidebar.SideBarToggled += expandSideBar;
            sidebar.CurrencyModeSet += setCurrencyMode;
            sidebar.BringToFront();
            this.Controls.Add(sidebar);

            settingsScreen = new Settings();
            settingsScreen.Width = this.Width;
            settingsScreen.Height = this.Height;
            settingsScreen.Visible = false;
            settingsScreen.AppAppearanceChanged += appAppearanceChanged;
            settingsScreen.SideBarToggled += expandSideBar;
            this.Controls.Add(settingsScreen);

            currencyScreen = new Currency();
            currencyScreen.Width = this.Width;
            currencyScreen.Height = this.Height;
            currencyScreen.Visible = false;
            currencyScreen.SideBarToggled += expandSideBar;
            this.Controls.Add(currencyScreen);

            historyScreen = new History();
            historyScreen.Size = new Size(historyScreen.Width, 0);
            historyScreen.Dock = DockStyle.Bottom;

            memoryScreen = new Memory();
            memoryScreen.Size = new Size(memoryScreen.Width, 0);
            memoryScreen.Dock = DockStyle.Bottom;
        }

        private void setSettingsMode()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.Visible = false;
            }
            sidebar.Visible = true;
            settingsScreen.Visible = true;
        }

        private void appAppearanceChanged()
        {
            applyUserTheme();
        }

        private void setDarkTheme()
        {
            this.BackColor = ColorTranslator.FromHtml("#202020");
            btnDecimal.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnZero.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnPlusMinus.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnOne.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnTwo.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnThree.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnFour.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnFive.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnSix.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnSeven.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnEight.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnNine.BackColor = ColorTranslator.FromHtml("#3b3b3b");

            btnAdd.BackColor = ColorTranslator.FromHtml("#323232");
            btnSubtract.BackColor = ColorTranslator.FromHtml("#323232");
            btnMultiply.BackColor = ColorTranslator.FromHtml("#323232");
            btnDivide.BackColor = ColorTranslator.FromHtml("#323232");
            btnSqrt.BackColor = ColorTranslator.FromHtml("#323232");
            btnSquare.BackColor = ColorTranslator.FromHtml("#323232");
            btnReciprocal.BackColor = ColorTranslator.FromHtml("#323232");
            btnDelete.BackColor = ColorTranslator.FromHtml("#323232");
            btnClear.BackColor = ColorTranslator.FromHtml("#323232");
            btnNaturalLog.BackColor = ColorTranslator.FromHtml("#323232");
            btnLog.BackColor = ColorTranslator.FromHtml("#323232");
            btnTenPow.BackColor = ColorTranslator.FromHtml("#323232");
            btnXPowN.BackColor = ColorTranslator.FromHtml("#323232");
            btnPi.BackColor = ColorTranslator.FromHtml("#323232");
            btnEuler.BackColor = ColorTranslator.FromHtml("#323232");
            btnFactorial.BackColor = ColorTranslator.FromHtml("#323232");
            btnSine.BackColor = ColorTranslator.FromHtml("#323232");
            btnCosine.BackColor = ColorTranslator.FromHtml("#323232");
            btnTangent.BackColor = ColorTranslator.FromHtml("#323232");
            txtDisplay.BackColor = ColorTranslator.FromHtml("#202020");
            btnAbs.BackColor = ColorTranslator.FromHtml("#323232");
            btnDegreesRadians.BackColor = ColorTranslator.FromHtml("#323232");
            btnNCR.BackColor = ColorTranslator.FromHtml("#323232");
            btnMemoryAdd.BackColor = ColorTranslator.FromHtml("#202020");
            btnMemoryClear.BackColor = ColorTranslator.FromHtml("#202020");
            btnMemoryRead.BackColor = ColorTranslator.FromHtml("#202020");
            btnMemoryStore.BackColor = ColorTranslator.FromHtml("#202020");
            btnMemorySubtract.BackColor = ColorTranslator.FromHtml("#202020");
            btnMemoryView.BackColor = ColorTranslator.FromHtml("#202020");
            btnSideBar.BackColor = ColorTranslator.FromHtml("#202020");

            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.ForeColor = Color.White;
            }

            btnHistory.Image = Properties.Resources.history_icon_white;
            sidebar.setDarkMode();
        }

        private void setLightTheme()
        {
            this.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnDecimal.BackColor = Color.White;
            btnZero.BackColor = Color.White;
            btnPlusMinus.BackColor = Color.White;
            btnOne.BackColor = Color.White;
            btnTwo.BackColor = Color.White;
            btnThree.BackColor = Color.White;
            btnFour.BackColor = Color.White;
            btnFive.BackColor = Color.White;
            btnSix.BackColor = Color.White;
            btnSeven.BackColor = Color.White;
            btnEight.BackColor = Color.White;
            btnNine.BackColor = Color.White;

            btnAdd.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnSubtract.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMultiply.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnDivide.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnSqrt.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnSquare.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnReciprocal.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnDelete.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnClear.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnNaturalLog.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnLog.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnTenPow.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnXPowN.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnPi.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnEuler.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnFactorial.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnSine.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnCosine.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnTangent.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            txtDisplay.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMemoryAdd.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMemoryClear.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMemoryRead.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMemoryStore.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMemorySubtract.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnMemoryView.BackColor = ColorTranslator.FromHtml("#f9f9f9");
            btnSideBar.BackColor = ColorTranslator.FromHtml("#f9f9f9");

            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.ForeColor = Color.Black;
            }
            btnExecute.ForeColor = Color.White;

            btnHistory.Image = Properties.Resources.history_icon_black;
            sidebar.setLightMode();
        }

        private void loadConfig()
        {
            switch (UserConfig.Mode)
            {
                case "standard":
                    setStandardMode();
                    break;
                case "scientific":
                    setScientificMode();
                    break;
                default:
                    setStandardMode();
                    break;
            }
            applyUserTheme();
        }

        private void applyUserTheme()
        {
            switch (UserConfig.Theme)
            {
                case "light":
                    setLightTheme();
                    break;
                case "dark":
                    setDarkTheme();
                    break;
                case "system":
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
                default:
                    setLightTheme();
                    break;
            }
        }

        private void setStandardMode()
        {
            btnExecute.Location = new Point(255, 437);
            btnExecute.Size = new Size(77, 56);
            btnDecimal.Location = new Point(177, 437);
            btnDecimal.Size = new Size(77, 56);
            btnZero.Location = new Point(99, 437);
            btnZero.Size = new Size(77, 56);
            btnPlusMinus.Location = new Point(21, 437);
            btnPlusMinus.Size = new Size(77, 56);
            btnAdd.Location = new Point(255, 381);
            btnAdd.Size = new Size(77, 56);
            btnThree.Location = new Point(177, 381);
            btnThree.Size = new Size(77, 56);
            btnTwo.Location = new Point(99, 381);
            btnTwo.Size = new Size(77, 56);
            btnOne.Location = new Point(21, 381);
            btnOne.Size = new Size(77, 56);
            btnSubtract.Location = new Point(255, 325);
            btnSubtract.Size = new Size(77, 56);
            btnSix.Location = new Point(177, 325);
            btnSix.Size = new Size(77, 56);
            btnFive.Location = new Point(99, 325);
            btnFive.Size = new Size(77, 56);
            btnFour.Location = new Point(21, 325);
            btnFour.Size = new Size(77, 56);
            btnMultiply.Location = new Point(255, 269);
            btnMultiply.Size = new Size(77, 56);
            btnNine.Location = new Point(177, 269);
            btnNine.Size = new Size(77, 56);
            btnEight.Location = new Point(99, 269);
            btnEight.Size = new Size(77, 56);
            btnSeven.Location = new Point(21, 269);
            btnSeven.Size = new Size(77, 56);
            btnDivide.Location = new Point(255, 213);
            btnDivide.Size = new Size(77, 56);
            btnSqrt.Location = new Point(177, 213);
            btnSqrt.Size = new Size(77, 56);
            btnSquare.Location = new Point(99, 213);
            btnSquare.Size = new Size(77, 56);
            btnReciprocal.Location = new Point(21, 213);
            btnReciprocal.Size = new Size(77, 56);
            btnDelete.Location = new Point(255, 157);
            btnDelete.Size = new Size(77, 56);
            btnClear.Location = new Point(177, 157);
            btnClear.Size = new Size(77, 56);

            btnSideBar.Visible = true;
            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFour.Visible = true;
            btnFive.Visible = true;
            btnSix.Visible = true;
            btnSeven.Visible = true;
            btnEight.Visible = true;
            btnNine.Visible = true;
            btnZero.Visible = true;
            btnAdd.Visible = true;
            btnSubtract.Visible = true;
            btnMultiply.Visible = true;
            btnDivide.Visible = true;
            btnExecute.Visible = true;
            btnPlusMinus.Visible = true;
            btnDecimal.Visible = true;
            btnDelete.Visible = true;
            btnClear.Visible = true;
            btnMemoryAdd.Visible = true;
            btnMemorySubtract.Visible = true;
            btnMemoryRead.Visible = true;
            btnMemoryStore.Visible = true;
            btnMemoryView.Visible = true;
            btnSquare.Visible = true;
            btnReciprocal.Visible = true;
            btnSqrt.Visible = true;
            txtDisplay.Visible = true;
            lblCalc.Visible = true;

            btnNaturalLog.Visible = false;
            btnLog.Visible = false;
            btnTenPow.Visible = false;
            btnXPowN.Visible = false;
            btnFactorial.Visible = false;
            btnAbs.Visible = false;
            btnPi.Visible = false;
            btnEuler.Visible = false;
            btnNCR.Visible = false;
            btnRemainder.Visible = false;
            btnTangent.Visible = false;
            btnCosine.Visible = false;
            btnSine.Visible = false;
            btnDegreesRadians.Visible = false;

            settingsScreen.Visible = false;
            currencyScreen.Visible = false;

            foreach (System.Windows.Forms.Control button in this.Controls)
            {
                if (button is Button)
                {
                    button.Font = new Font(button.Font.FontFamily, 24);
                }
                btnMemoryAdd.Font = new Font(btnMemoryAdd.Font.FontFamily, 12);
                btnMemoryClear.Font = new Font(btnMemoryClear.Font.FontFamily, 12);
                btnMemoryRead.Font = new Font(btnMemoryRead.Font.FontFamily, 12);
                btnMemoryStore.Font = new Font(btnMemoryStore.Font.FontFamily, 12);
                btnMemorySubtract.Font = new Font(btnMemorySubtract.Font.FontFamily, 12);
                btnMemoryView.Font = new Font(btnMemoryView.Font.FontFamily, 12);
            }
        }

        private void setScientificMode()
        {
            btnExecute.Location = new Point(282, 455);
            btnExecute.Size = new Size(66, 35);
            btnExecute.Font = new Font(btnExecute.Font.FontFamily, 18);
            btnDecimal.Location = new Point(146, 455);
            btnDecimal.Size = new Size(75, 40);
            btnDecimal.Font = new Font(btnDecimal.Font.FontFamily, 18);
            btnZero.Location = new Point(214, 455);
            btnZero.Size = new Size(75, 40);
            btnZero.Font = new Font(btnZero.Font.FontFamily, 18);
            btnPlusMinus.Location = new Point(78, 455);
            btnPlusMinus.Size = new Size(75, 40);
            btnPlusMinus.Font = new Font(btnPlusMinus.Font.FontFamily, 18);
            btnAdd.Location = new Point(282, 419);
            btnAdd.Size = new Size(75, 40);
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, 18);
            btnThree.Location = new Point(214, 419);
            btnThree.Size = new Size(75, 40);
            btnThree.Font = new Font(btnThree.Font.FontFamily, 18);
            btnTwo.Location = new Point(146, 419);
            btnTwo.Size = new Size(75, 40);
            btnTwo.Font = new Font(btnTwo.Font.FontFamily, 18);
            btnOne.Location = new Point(78, 419);
            btnOne.Size = new Size(75, 40);
            btnOne.Font = new Font(btnOne.Font.FontFamily, 18);
            btnSubtract.Location = new Point(282, 383);
            btnSubtract.Size = new Size(75, 40);
            btnSubtract.Font = new Font(btnSubtract.Font.FontFamily, 18);
            btnSix.Location = new Point(214, 383);
            btnSix.Size = new Size(75, 40);
            btnSix.Font = new Font(btnSix.Font.FontFamily, 18);
            btnFive.Location = new Point(146, 383);
            btnFive.Size = new Size(75, 40);
            btnFive.Font = new Font(btnFive.Font.FontFamily, 18);
            btnFour.Location = new Point(78, 383);
            btnFour.Size = new Size(75, 40);
            btnFour.Font = new Font(btnFour.Font.FontFamily, 18);
            btnMultiply.Location = new Point(282, 347);
            btnMultiply.Size = new Size(75, 40);
            btnMultiply.Font = new Font(btnMultiply.Font.FontFamily, 18);
            btnNine.Location = new Point(214, 347);
            btnNine.Size = new Size(75, 40);
            btnNine.Font = new Font(btnNine.Font.FontFamily, 18);
            btnEight.Location = new Point(146, 347);
            btnEight.Size = new Size(75, 40);
            btnEight.Font = new Font(btnEight.Font.FontFamily, 18);
            btnSeven.Location = new Point(78, 347);
            btnSeven.Size = new Size(75, 40);
            btnSeven.Font = new Font(btnSeven.Font.FontFamily, 18);
            btnDivide.Location = new Point(282, 311);
            btnDivide.Size = new Size(75, 40);
            btnDivide.Font = new Font(btnDivide.Font.FontFamily, 18);
            btnSqrt.Location = new Point(214, 311);
            btnSqrt.Size = new Size(75, 40);
            btnSqrt.Font = new Font(btnSqrt.Font.FontFamily, 18);
            btnSquare.Location = new Point(146, 311);
            btnSquare.Size = new Size(75, 40);
            btnSquare.Font = new Font(btnSquare.Font.FontFamily, 18);
            btnReciprocal.Location = new Point(78, 311);
            btnReciprocal.Size = new Size(75, 40);
            btnReciprocal.Font = new Font(btnReciprocal.Font.FontFamily, 18);
            btnDelete.Location = new Point(255, 157);
            btnDelete.Size = new Size(75, 40);
            btnDelete.Font = new Font(btnDelete.Font.FontFamily, 18);
            btnClear.Location = new Point(177, 157);
            btnClear.Size = new Size(75, 40);
            btnClear.Font = new Font(btnClear.Font.FontFamily, 18);
            btnNaturalLog.Location = new Point(10, 455);
            btnNaturalLog.Font = new Font(btnNaturalLog.Font.FontFamily, 18);
            btnLog.Location = new Point(10, 419);
            btnLog.Font = new Font(btnLog.Font.FontFamily, 18);
            btnTenPow.Location = new Point(10, 383);
            btnTenPow.Font = new Font(btnTenPow.Font.FontFamily, 18);
            btnXPowN.Location = new Point(10, 347);
            btnXPowN.Font = new Font(btnXPowN.Font.FontFamily, 18);
            btnFactorial.Location = new Point(10, 311);
            btnFactorial.Font = new Font(btnFactorial.Font.FontFamily, 18);
            btnAbs.Location = new Point(282, 275);
            btnAbs.Font = new Font(btnAbs.Font.FontFamily, 18);
            btnPi.Location = new Point(214, 275);
            btnPi.Font = new Font(btnPi.Font.FontFamily, 18);
            btnEuler.Location = new Point(146, 275);
            btnEuler.Font = new Font(btnEuler.Font.FontFamily, 18);
            btnNCR.Location = new Point(78, 275);
            btnNCR.Font = new Font(btnNCR.Font.FontFamily, 18);
            btnRemainder.Location = new Point(282, 239);
            btnRemainder.Font = new Font(btnRemainder.Font.FontFamily, 18);
            btnTangent.Location = new Point(214, 239);
            btnTangent.Font = new Font(btnTangent.Font.FontFamily, 18);
            btnCosine.Location = new Point(146, 239);
            btnCosine.Font = new Font(btnCosine.Font.FontFamily, 18);
            btnSine.Location = new Point(78, 239);
            btnSine.Font = new Font(btnSine.Font.FontFamily, 18);
            btnDegreesRadians.Font = new Font(btnDegreesRadians.Font.FontFamily, 17);

            btnSideBar.Visible = true;
            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFour.Visible = true;
            btnFive.Visible = true;
            btnSix.Visible = true;
            btnSeven.Visible = true;
            btnEight.Visible = true;
            btnNine.Visible = true;
            btnZero.Visible = true;
            btnAdd.Visible = true;
            btnSubtract.Visible = true;
            btnMultiply.Visible = true;
            btnDivide.Visible = true;
            btnExecute.Visible = true;
            btnPlusMinus.Visible = true;
            btnDecimal.Visible = true;
            btnDelete.Visible = true;
            btnClear.Visible = true;
            btnMemoryAdd.Visible = true;
            btnMemorySubtract.Visible = true;
            btnMemoryRead.Visible = true;
            btnMemoryStore.Visible = true;
            btnMemoryView.Visible = true;
            btnSquare.Visible = true;
            btnReciprocal.Visible = true;
            btnSqrt.Visible = true;
            txtDisplay.Visible = true;
            lblCalc.Visible = true;

            btnNaturalLog.Visible = true;
            btnLog.Visible = true;
            btnTenPow.Visible = true;
            btnXPowN.Visible = true;
            btnFactorial.Visible = true;
            btnAbs.Visible = true;
            btnPi.Visible = true;
            btnEuler.Visible = true;
            btnNCR.Visible = true;
            btnRemainder.Visible = true;
            btnTangent.Visible = true;
            btnCosine.Visible = true;
            btnSine.Visible = true;
            btnDegreesRadians.Visible = true;

            settingsScreen.Visible = false;
            currencyScreen.Visible = false;

            foreach (System.Windows.Forms.Control button in this.Controls)
            {
                if (button is Button)
                {
                    button.Font = new Font(button.Font.FontFamily, 16);
                }
            }
            btnMemoryAdd.Font = new Font(btnMemoryAdd.Font.FontFamily, 12);
            btnMemoryClear.Font = new Font(btnMemoryClear.Font.FontFamily, 12);
            btnMemoryRead.Font = new Font(btnMemoryRead.Font.FontFamily, 12);
            btnMemoryStore.Font = new Font(btnMemoryStore.Font.FontFamily, 12);
            btnMemorySubtract.Font = new Font(btnMemorySubtract.Font.FontFamily, 12);
            btnMemoryView.Font = new Font(btnMemoryView.Font.FontFamily, 12);
        }

        private void setCurrencyMode()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.Visible = false;
            }
            sidebar.Visible = true;
            currencyScreen.Visible = true;
        }

        private bool isPositive = true;
        private bool add = false;
        private bool subtract = false;
        private bool multiply = false;
        private bool divide = false;
        private bool exp = false;
        private bool nCr = false;
        private bool remainder = false;
        private bool inDegrees = true;
        private bool secondInput = false;
        private bool errorMsg = false;
        private bool sideBarExpand = false;
        private bool historyExpanded = false;
        private bool memoryExpanded = false;
        private double num;
        private double memorynum;


        private void Calculator_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            btnMemoryClear.Enabled = false;
            btnMemoryClear.ForeColor = ColorTranslator.FromHtml("#666666");
            btnMemoryRead.Enabled = false;
            btnMemoryRead.ForeColor = ColorTranslator.FromHtml("#666666");
            btnMemoryView.Enabled = false;
            Functions.readConfig();
            loadConfig();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1 && !errorMsg)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            else if (txtDisplay.Text.Length == 1)
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
            txtDisplay.Text = "0";
            lblCalc.Text = "";
            add = false;
            subtract = false;
            multiply = false;
            divide = false;
            exp = false;
            remainder = false;
            isPositive = true;
            errorMsg = false;
            num = 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains('.') && !errorMsg)
            {
                txtDisplay.Text += ".";
            }
            else if (errorMsg)
            {
                txtDisplay.Text = "0.";
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, txtDisplay.Font.Size, FontStyle.Bold);
                errorMsg = false;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "0";
                lblCalc.Text = "";
                secondInput = false;
                return;
            }

            if (txtDisplay.Text[0] != '0')
            {
                txtDisplay.Text += "0";
            }
            else if (txtDisplay.Text.Length >= 2)
            {
                txtDisplay.Text += "0";
            }
            lblCalc.Text = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            char minus = '-';
            if (txtDisplay.Text != "0" && isPositive)
            {
                txtDisplay.Text = minus + txtDisplay.Text;
                isPositive = false;
            }
            else if (txtDisplay.Text != "0" && !isPositive)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(1, txtDisplay.Text.Length - 1);
                isPositive = true;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "1";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "1";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "2";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "2";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "3";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "3";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "4";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "4";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "5";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "5";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "6";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "6";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "7";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "7";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "8";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "8";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (secondInput)
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 28, FontStyle.Bold);
                txtDisplay.Text = "9";
                lblCalc.Text = "";
                secondInput = false;
                errorMsg = false;
                return;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "9";
            }
            errorMsg = false;
            lblCalc.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            subtract = false;
            multiply = false;
            divide = false;
            exp = false;
            secondInput = true;

            if (!errorMsg)
            {
                num = Convert.ToDouble(txtDisplay.Text);
                lblCalc.Text = $"{num} +";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            subtract = true;
            add = false;
            multiply = false;
            divide = false;
            exp = false;
            secondInput = true;

            if (!errorMsg)
            {
                num = Convert.ToDouble(txtDisplay.Text);
                lblCalc.Text = $"{num} -";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            multiply = true;
            add = false;
            subtract = false;
            divide = false;
            exp = false;
            secondInput = true;

            if (!errorMsg)
            {
                num = Convert.ToDouble(txtDisplay.Text);
                lblCalc.Text = $"{num} x";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            divide = true;
            add = false;
            subtract = false;
            multiply = false;
            exp = false;
            secondInput = true;

            if (!errorMsg)
            {
                num = Convert.ToDouble(txtDisplay.Text);
                lblCalc.Text = $"{num} ÷";
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (add && !errorMsg)
            {
                lblCalc.Text = $"{num} + {txtDisplay.Text} =";
                txtDisplay.Text = (num + Convert.ToDouble(txtDisplay.Text)).ToString("N");
            }
            else if (subtract && !errorMsg)
            {
                lblCalc.Text = $"{num} - {txtDisplay.Text} =";
                txtDisplay.Text = (num - Convert.ToDouble(txtDisplay.Text)).ToString("N");
            }
            else if (multiply && !errorMsg)
            {
                lblCalc.Text = $"{num} x {txtDisplay.Text} =";
                txtDisplay.Text = (num * Convert.ToDouble(txtDisplay.Text)).ToString("N");
            }
            else if (divide && !errorMsg)
            {
                if (txtDisplay.Text != "0")
                {
                    lblCalc.Text = $"{num} ÷ {txtDisplay.Text} =";
                    txtDisplay.Text = (num / Convert.ToDouble(txtDisplay.Text)).ToString("N");
                }
                else
                {
                    txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 24);
                    txtDisplay.Text = "Cannot divide by zero";
                    errorMsg = true;
                }
            }
            else if (exp && !errorMsg)
            {
                lblCalc.Text = $"{num} ^ {txtDisplay.Text} =";
                txtDisplay.Text = Math.Pow(num, Convert.ToDouble(txtDisplay.Text)).ToString();
            }
            //else if (nCr && !errorMsg)
            //{
            //    txtDisplay.Text = Functions.nCr(int.Parse(num), int.Parse(txtDisplay.Text)).ToString();
            //}
            else if (remainder && !errorMsg)
            {
                lblCalc.Text = $"{num}mod{txtDisplay.Text}=";
                txtDisplay.Text = (num % Convert.ToDouble(txtDisplay.Text)).ToString();
            }
            else
            {
                if (errorMsg)
                {
                    txtDisplay.Text = txtDisplay.Text;
                }
                else
                {
                    lblCalc.Text = $"{txtDisplay.Text} =";
                    txtDisplay.Text = txtDisplay.Text;
                }
            }
            secondInput = true;
            string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
            Functions.history.Add(historyText);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (isPositive && !errorMsg)
            {
                lblCalc.Text = $"√({txtDisplay.Text})=";
                txtDisplay.Text = Math.Sqrt(Convert.ToDouble(txtDisplay.Text)).ToString("N");
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                txtDisplay.Text = "Invalid input";
                isPositive = true;
                errorMsg = true;
            }

            secondInput = true;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (!errorMsg)
            {
                lblCalc.Text = $"sqr({txtDisplay.Text})=";
                txtDisplay.Text = Math.Pow(Convert.ToDouble(txtDisplay.Text), 2).ToString("N");
                isPositive = true;
                secondInput = true;
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text;
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0" && !errorMsg)
            {
                lblCalc.Text = $"1/{txtDisplay.Text}=";
                txtDisplay.Text = (1 / Convert.ToDouble(txtDisplay.Text)).ToString("N");
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 24);
                txtDisplay.Text = "Cannot divide by zero";
                errorMsg = true;
            }
            secondInput = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(historyScreen))
            {
                this.Controls.Add(historyScreen);
            }
            historyScreen.Visible = true;
            historyScreen.BringToFront();
            historyScreen.addHistory();
            setButtonsToBackground();
            tmrHistory.Start();
        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            expandSideBar();
            setButtonsToBackground();
        }

        private void setButtonsToBackground()
        {
            txtDisplay.SendToBack();
            btnDecimal.SendToBack();
            btnZero.SendToBack();
            btnPlusMinus.SendToBack();
            btnOne.SendToBack();
            btnTwo.SendToBack();
            btnThree.SendToBack();
            btnFour.SendToBack();
            btnFive.SendToBack();
            btnSix.SendToBack();
            btnSeven.SendToBack();
            btnEight.SendToBack();
            btnNine.SendToBack();
            btnSqrt.SendToBack();
            btnSquare.SendToBack();
            btnReciprocal.SendToBack();
            btnClear.SendToBack();
            btnExecute.SendToBack();
            btnAdd.SendToBack();
            btnSubtract.SendToBack();
            btnMultiply.SendToBack();
            btnDivide.SendToBack();
            btnDelete.SendToBack();
            lblCalc.SendToBack();
            btnNaturalLog.SendToBack();
            btnLog.SendToBack();
            btnTenPow.SendToBack();
            btnXPowN.SendToBack();
            btnFactorial.SendToBack();
            btnAbs.SendToBack();
            btnPi.SendToBack();
            btnEuler.SendToBack();
            btnNCR.SendToBack();
            btnRemainder.SendToBack();
            btnTangent.SendToBack();
            btnCosine.SendToBack();
            btnSine.SendToBack();
            btnDegreesRadians.SendToBack();
            btnMemoryAdd.SendToBack();
            btnMemoryClear.SendToBack();
            btnMemoryRead.SendToBack();
            btnMemoryStore.SendToBack();
            btnMemorySubtract.SendToBack();
            btnMemoryView.SendToBack();
            settingsScreen.SendToBack();
        }

        private void expandSideBar()
        {
            tmrSideBar.Start();
        }

        private void tmrSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    tmrSideBar.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    tmrSideBar.Stop();
                }
            }
        }

        private void btnNaturalLog_Click(object sender, EventArgs e)
        {
            if (isPositive && txtDisplay.Text != "0")
            {
                lblCalc.Text = $"ln({txtDisplay.Text})=";
                txtDisplay.Text = Math.Log(Convert.ToDouble(txtDisplay.Text)).ToString();
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                lblCalc.Text = "Invalid input";
                errorMsg = true;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (isPositive && !errorMsg)
            {
                lblCalc.Text = $"log({txtDisplay.Text})=";
                txtDisplay.Text = Math.Log10(Convert.ToDouble(txtDisplay.Text)).ToString();
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                txtDisplay.Text = "Invalid input";
                errorMsg = true;
            }
        }

        private void btnTenPow_Click(object sender, EventArgs e)
        {
            if (!errorMsg)
            {
                lblCalc.Text = $"10 ^ {txtDisplay.Text}";
                txtDisplay.Text = Math.Pow(10, Convert.ToDouble(txtDisplay.Text)).ToString();
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text;
            }
        }

        private void btnXPowN_Click(object sender, EventArgs e)
        {
            exp = true;
            add = false;
            subtract = false;
            multiply = false;
            divide = false;
            secondInput = true;

            num = Convert.ToDouble(txtDisplay.Text);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            lblCalc.Text = $"{txtDisplay.Text}!=";
            num = Convert.ToDouble(txtDisplay.Text);
            if (isPositive && !errorMsg)
            {
                if (num == (int)num && num >= 0)
                {
                    txtDisplay.Text = Functions.Factorial((int)num).ToString();
                }
                else
                {
                    txtDisplay.Text = SpecialFunctions.Gamma(num + 1).ToString();
                }
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
            else
            {
                txtDisplay.Text = "Undefined";
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            if (!errorMsg)
            {
                lblCalc.Text = $"abs({txtDisplay.Text})=";
                txtDisplay.Text = (Math.Abs(Convert.ToDouble(txtDisplay.Text))).ToString();
                string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                Functions.history.Add(historyText);
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            lblCalc.Text = $"π=";
            txtDisplay.Text = Math.PI.ToString();
            string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
            Functions.history.Add(historyText);
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            lblCalc.Text = $"e=";
            txtDisplay.Text = Math.E.ToString();
            string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
            Functions.history.Add(historyText);
        }

        private void btnNCR_Click(object sender, EventArgs e)
        {
            lblCalc.Text = $"{txtDisplay.Text}C";
            txtDisplay.Text = $"{txtDisplay.Text}C";
            nCr = true;
            num = Convert.ToDouble(txtDisplay.Text);
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            remainder = true;
            secondInput = true;
            num = Convert.ToDouble(txtDisplay.Text);
        }

        private void btnTangent_Click(object sender, EventArgs e)
        {
            if (!errorMsg)
            {
                if (inDegrees)
                {
                    double inputToDegrees = Functions.ConvertToRadians(Convert.ToDouble(txtDisplay.Text));
                    lblCalc.Text = $"tan({txtDisplay.Text})=";
                    txtDisplay.Text = Math.Tan(Convert.ToDouble(txtDisplay.Text)).ToString();
                    string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                    Functions.history.Add(historyText);
                }
                else if (!inDegrees)
                {
                    lblCalc.Text = $"tan({txtDisplay.Text})=";
                    txtDisplay.Text = Math.Tan(Convert.ToDouble(txtDisplay.Text)).ToString();
                    string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                    Functions.history.Add(historyText);
                }
            }
        }

        private void btnCosine_Click(object sender, EventArgs e)
        {
            if (!errorMsg)
            {
                if (inDegrees)
                {
                    double inputToDegrees = Functions.ConvertToRadians(Convert.ToDouble(txtDisplay.Text));
                    lblCalc.Text = $"cos({txtDisplay.Text})=";
                    txtDisplay.Text = Math.Cos(Convert.ToDouble(txtDisplay.Text)).ToString();
                    string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                    Functions.history.Add(historyText);
                }
                else if (!inDegrees)
                {
                    lblCalc.Text = $"cos({txtDisplay.Text})=";
                    txtDisplay.Text = Math.Cos(Convert.ToDouble(txtDisplay.Text)).ToString();
                    string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                    Functions.history.Add(historyText);
                }
            }
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            if (!errorMsg)
            {
                if (inDegrees)
                {
                    double inputToDegrees = Functions.ConvertToRadians(Convert.ToDouble(txtDisplay.Text));
                    lblCalc.Text = $"sin({txtDisplay.Text})=";
                    txtDisplay.Text = Math.Sin(inputToDegrees).ToString();
                    string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                    Functions.history.Add(historyText);
                }
                else if (!inDegrees)
                {
                    lblCalc.Text = $"sin({txtDisplay.Text})=";
                    txtDisplay.Text = Math.Sin(Convert.ToDouble(txtDisplay.Text)).ToString();
                    string historyText = $"{lblCalc.Text}:{txtDisplay.Text}";
                    Functions.history.Add(historyText);
                }
            }
        }

        private void btnDegreesRadians_Click(object sender, EventArgs e)
        {
            if (inDegrees)
            {
                inDegrees = false;
                btnDegreesRadians.Text = "rad";
            }
            else if (!inDegrees)
            {
                inDegrees = true;
                btnDegreesRadians.Text = "deg";
            }
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.saveConfig();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memorynum = 0;
            btnMemoryClear.Enabled = false;
            btnMemoryClear.ForeColor = ColorTranslator.FromHtml("#666666");
            btnMemoryRead.Enabled = false;
            btnMemoryRead.ForeColor = ColorTranslator.FromHtml("#666666");
            Functions.memory.Clear();
            memoryScreen.addMemory();
        }

        private void btnMemoryRead_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memorynum.ToString();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            memorynum += Convert.ToDouble(txtDisplay.Text);
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            memorynum -= Convert.ToDouble(txtDisplay.Text);
        }

        private void btnMemoryStore_Click(object sender, EventArgs e)
        {
            memorynum = Convert.ToDouble(txtDisplay.Text);
            Functions.memory.Add(memorynum);
            btnMemoryClear.Enabled = true;
            btnMemoryRead.Enabled = true;
            btnMemoryView.Enabled = true;
        }

        private void btnMemoryView_Click(object sender, EventArgs e)
        {
            if (btnMemoryView.Enabled)
            {
                tmrMemory.Start();
                memoryScreen.Visible = true;
                if (!this.Controls.Contains(memoryScreen))
                {
                    this.Controls.Add(memoryScreen);
                }
                memoryScreen.BringToFront();
                setButtonsToBackground();
                memoryScreen.addMemory();
            }
        }

        private void tmrHistory_Tick(object sender, EventArgs e)
        {
            if (historyExpanded)
            {
                historyScreen.Height -= 10;
                if (historyScreen.Height == historyScreen.MinimumSize.Height)
                {
                    historyExpanded = false;
                    tmrHistory.Stop();
                }
            }
            else
            {
                historyScreen.Height += 10;
                if (historyScreen.Height == historyScreen.MaximumSize.Height)
                {
                    historyExpanded = true;
                    tmrHistory.Stop();
                }
            }
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Point mousePosition = this.PointToClient(Cursor.Position);

            if (!historyScreen.Bounds.Contains(mousePosition) && historyScreen.Height == historyScreen.MaximumSize.Height)
            {
                tmrHistory.Start();
            }
            else if (!memoryScreen.Bounds.Contains(mousePosition) && memoryScreen.Height == memoryScreen.MaximumSize.Height)
            {
                tmrMemory.Start();
            }
            else if (!sidebar.Bounds.Contains(mousePosition) && sidebar.Width == sidebar.MaximumSize.Width)
            {
                tmrSideBar.Start();
            }
        }

        private void txtDisplay_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void tmrMemory_Tick(object sender, EventArgs e)
        {
            if (memoryExpanded)
            {
                memoryScreen.Height -= 10;
                if (memoryScreen.Height == memoryScreen.MinimumSize.Height)
                {
                    memoryExpanded = false;
                    tmrMemory.Stop();
                }
            }
            else
            {
                memoryScreen.Height += 10;
                if (memoryScreen.Height == memoryScreen.MaximumSize.Height)
                {
                    memoryExpanded = true;
                    tmrMemory.Stop();
                }
            }
        }
    }
}
