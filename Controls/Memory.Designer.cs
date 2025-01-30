namespace CalculatorProject.Controls
{
    partial class Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
            btnTrash = new Button();
            pnlContainer = new Panel();
            SuspendLayout();
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
            btnTrash.TabIndex = 2;
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
            pnlContainer.TabIndex = 3;
            // 
            // Memory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(pnlContainer);
            Controls.Add(btnTrash);
            MaximumSize = new Size(370, 340);
            MinimumSize = new Size(370, 0);
            Name = "Memory";
            Size = new Size(370, 340);
            Load += Memory_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTrash;
        private Panel pnlContainer;
    }
}
