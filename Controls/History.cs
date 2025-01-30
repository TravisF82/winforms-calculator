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
    public partial class History : UserControl
    {
        public delegate void LoadHistory();
        public event LoadHistory HistoryLoaded;

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (Functions.history.Count == 0)
            {
                lblTitle.Text = "There's no history yet.";
            }
            else if (Functions.history.Count > 0)
            {
                lblTitle.Text = "History:";
                addHistory();
            }
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            Functions.history.Clear();
            pnlContainer.Controls.Clear();
            lblTitle.ForeColor = Color.White;
            pnlContainer.Controls.Add(lblTitle);
            lblTitle.Text = "There's no history yet.";
        }

        public void addHistory()
        {
            pnlContainer.Controls.Clear();
            for (int i = 0; i < Functions.history.Count; i++)
            {
                string[] parts = Functions.history[i].Split(':');
                Label lblCalculation = new Label
                {
                    Text = parts[0],
                    Font = new Font("Arial", 11, FontStyle.Regular),
                    AutoSize = true,
                    ForeColor = Color.Gray
                };

                Label lblAnswer = new Label
                {
                    Text = parts[1],
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.White
                };
                int currentY = 0;
                if (pnlContainer.Controls.Count > 0)
                {
                    currentY = pnlContainer.Controls[pnlContainer.Controls.Count - 1].Bottom + 10;
                }
                else
                {
                    currentY = 10;
                }

                lblCalculation.Location = new Point(10, currentY);
                lblAnswer.Location = new Point(10, lblCalculation.Bottom + 3);

                pnlContainer.Controls.Add(lblCalculation);
                pnlContainer.Controls.Add(lblAnswer);
            }
        }
    }
}
