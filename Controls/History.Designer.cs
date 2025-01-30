namespace CalculatorProject.Controls
{
    partial class History
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            lblTitle = new Label();
            btnTrash = new Button();
            pnlContainer = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(35, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(122, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "There's no history yet.";
            // 
            // btnTrash
            // 
            btnTrash.Dock = DockStyle.Bottom;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Image = (Image)resources.GetObject("btnTrash.Image");
            btnTrash.Location = new Point(0, 293);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(370, 47);
            btnTrash.TabIndex = 1;
            btnTrash.UseVisualStyleBackColor = false;
            btnTrash.Click += btnTrash_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.BackColor = Color.FromArgb(32, 32, 32);
            pnlContainer.Dock = DockStyle.Bottom;
            pnlContainer.Location = new Point(0, 45);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(370, 248);
            pnlContainer.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 39);
            panel2.TabIndex = 3;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(panel2);
            Controls.Add(pnlContainer);
            Controls.Add(btnTrash);
            MaximumSize = new Size(370, 340);
            MinimumSize = new Size(370, 0);
            Name = "History";
            Size = new Size(370, 340);
            Load += History_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnTrash;
        private Panel pnlContainer;
        private Panel panel2;
    }
}
