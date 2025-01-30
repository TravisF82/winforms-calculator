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
    public partial class Memory : UserControl
    {
        public Memory()
        {
            InitializeComponent();
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            addMemory();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            Functions.memory.Clear();
            pnlContainer.Controls.Clear();
        }

        public void addMemory()
        {
            pnlContainer.Controls.Clear();
            for (int i = 0; i < Functions.memory.Count; i++)
            {
                Label lblMemory = new Label
                {
                    Text = Functions.memory[i].ToString(),
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
                lblMemory.Location = new Point(10, currentY);
                pnlContainer.Controls.Add(lblMemory);
            }
        }
    }
}
