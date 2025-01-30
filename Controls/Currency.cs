using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using CalculatorProject.Classes;

namespace CalculatorProject.Controls
{
    public partial class Currency : UserControl
    {
        public delegate void SideBarToggledHandler();
        public event SideBarToggledHandler SideBarToggled;

        public Currency()
        {
            InitializeComponent();
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            populateCurrencyBoxes();
            cmbFromCurrency.SelectedIndexChanged -= cmbFromCurrency_SelectedIndexChanged;
            cmbToCurrency.SelectedIndexChanged -= cmbToCurrency_SelectedIndexChanged;
            cmbFromCurrency.SelectedItem = "GBP";
            cmbToCurrency.SelectedItem = "USD";
            cmbFromCurrency.SelectedIndexChanged += cmbFromCurrency_SelectedIndexChanged;
            cmbToCurrency.SelectedIndexChanged += cmbToCurrency_SelectedIndexChanged;
            getSavedTheme();
            lblLastUpdated.Text = $"";

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

        private void setLightMode()
        {
            this.BackColor = Color.White;
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.ForeColor = Color.Black;
            }
        }

        private void setDarkMode()
        {
            this.BackColor = ColorTranslator.FromHtml("#202020");
            btnDecimal.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnZero.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnOne.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnTwo.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnThree.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnFour.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnFive.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnSix.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnSeven.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnEight.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnNine.BackColor = ColorTranslator.FromHtml("#3b3b3b");
            btnDelete.BackColor = ColorTranslator.FromHtml("#323232");
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                control.ForeColor = Color.White;
            }
        }

        private double GetCurrencyExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;
            string apikey = "b1614f9562950df7874fda5a";

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://v6.exchangerate-api.com/v6/{apikey}/latest/{fromCurrency}");
            }

            var data = JObject.Parse(json);
            var rate = (double)data["conversion_rates"][toCurrency];
            string lastUpdated = data["time_last_update_utc"].ToString();
            lblLastUpdated.Text = $"Last updated: {lastUpdated}";
            return rate;
        }

        private void convert()
        {
            string fromCurrency = cmbFromCurrency.SelectedItem.ToString();
            string toCurrency = cmbToCurrency.SelectedItem.ToString();

            double amount;

            if (!double.TryParse(txtAmountToConvert.Text, out amount))
            {
                MessageBox.Show("bad 1");
            }

            double exchangeRate = 0;
            try
            {
                exchangeRate = GetCurrencyExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("bad 2");
            }

            double convertedAmount = amount * exchangeRate;
            txtAmountConverted.Text = $"{convertedAmount.ToString("c")}";
            lblConversionRate.Text = $"Conversion Rate: 1{fromCurrency} = {1 * exchangeRate}{toCurrency}";
        }

        private void populateCurrencyBoxes()
        {
            string json;
            string apikey = "b1614f9562950df7874fda5a";

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://v6.exchangerate-api.com/v6/{apikey}/latest/USD");
            }

            var data = JObject.Parse(json);
            var currencyCodes = data["conversion_rates"].Children<JProperty>().Select(c => c.Name).ToList();

            cmbFromCurrency.Items.AddRange(currencyCodes.ToArray());
            cmbToCurrency.Items.AddRange(currencyCodes.ToArray());
        }

        private void updateDisplay()
        {
            convert();
        }

        private void setLightTheme()
        {
            this.BackColor = Color.White;
            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.White;
            }
        }

        private void setDarkTheme()
        {
            this.BackColor = ColorTranslator.FromHtml($"#202020");
            foreach (Control control in this.Controls)
            {
                control.BackColor = ColorTranslator.FromHtml($"#202020");
            }
        }

        private void getSavedTheme()
        {
            switch (UserConfig.Theme)
            {
                case "light":
                    setLightTheme();
                    break;
                case "dark":
                    setDarkTheme();
                    break;
                case "blue":

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

                    break;
            }
        }

        private void txtAmountToConvert_TextChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            SideBarToggled?.Invoke();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtAmountToConvert.Text.Contains('.'))
            {
                txtAmountToConvert.Text += '.';
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text != "0")
            {
                txtAmountToConvert.Text += '0';
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "1";
            }
            else
            {
                txtAmountToConvert.Text += '1';
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "2";
            }
            else
            {
                txtAmountToConvert.Text += '2';
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "3";
            }
            else
            {
                txtAmountToConvert.Text += '3';
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "4";
            }
            else
            {
                txtAmountToConvert.Text += '4';
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "5";
            }
            else
            {
                txtAmountToConvert.Text += '5';
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "6";
            }
            else
            {
                txtAmountToConvert.Text += '6';
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "7";
            }
            else
            {
                txtAmountToConvert.Text += '7';
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "8";
            }
            else
            {
                txtAmountToConvert.Text += '8';
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text == "0")
            {
                txtAmountToConvert.Text = "9";
            }
            else
            {
                txtAmountToConvert.Text += '9';
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAmountToConvert.Text.Length > 1)
            {
                txtAmountToConvert.Text = txtAmountToConvert.Text.Remove(txtAmountToConvert.Text.Length - 1);
            }
            else if (txtAmountToConvert.Text.Length == 1)
            {
                txtAmountToConvert.Text = "0";
            }
        }

        private void cmbToCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void cmbFromCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
