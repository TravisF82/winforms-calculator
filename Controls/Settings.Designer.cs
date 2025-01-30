namespace CalculatorProject.Controls
{
    partial class Settings
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
            cmbThemes = new ComboBox();
            lblAppearance = new Label();
            lblSettings = new Label();
            lblGitHubLink = new Label();
            lblGitHubDescription = new Label();
            btnSideBar = new Button();
            SuspendLayout();
            // 
            // cmbThemes
            // 
            cmbThemes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbThemes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbThemes.FormattingEnabled = true;
            cmbThemes.Items.AddRange(new object[] { "Light", "Dark", "Blue", "System" });
            cmbThemes.Location = new Point(43, 110);
            cmbThemes.Name = "cmbThemes";
            cmbThemes.Size = new Size(163, 33);
            cmbThemes.TabIndex = 0;
            cmbThemes.SelectedIndexChanged += cmbThemes_SelectedIndexChanged;
            // 
            // lblAppearance
            // 
            lblAppearance.AutoSize = true;
            lblAppearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppearance.ForeColor = Color.White;
            lblAppearance.Location = new Point(43, 87);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(123, 20);
            lblAppearance.TabIndex = 1;
            lblAppearance.Text = "App Appearance";
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSettings.ForeColor = Color.White;
            lblSettings.Location = new Point(98, 9);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(84, 25);
            lblSettings.TabIndex = 2;
            lblSettings.Text = "Settings";
            // 
            // lblGitHubLink
            // 
            lblGitHubLink.AutoSize = true;
            lblGitHubLink.Cursor = Cursors.Hand;
            lblGitHubLink.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGitHubLink.ForeColor = Color.Coral;
            lblGitHubLink.Location = new Point(208, 271);
            lblGitHubLink.Name = "lblGitHubLink";
            lblGitHubLink.Size = new Size(62, 21);
            lblGitHubLink.TabIndex = 3;
            lblGitHubLink.Text = "GitHub";
            lblGitHubLink.Click += lblGitHubLink_Click;
            // 
            // lblGitHubDescription
            // 
            lblGitHubDescription.AutoSize = true;
            lblGitHubDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGitHubDescription.ForeColor = Color.White;
            lblGitHubDescription.Location = new Point(0, 229);
            lblGitHubDescription.Name = "lblGitHubDescription";
            lblGitHubDescription.Size = new Size(280, 42);
            lblGitHubDescription.TabIndex = 4;
            lblGitHubDescription.Text = "Thanks for checking out this project! \r\nTo see more, click here -->\r\n";
            // 
            // btnSideBar
            // 
            btnSideBar.FlatAppearance.BorderSize = 0;
            btnSideBar.FlatStyle = FlatStyle.Flat;
            btnSideBar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideBar.ForeColor = Color.White;
            btnSideBar.Location = new Point(14, 9);
            btnSideBar.Name = "btnSideBar";
            btnSideBar.Size = new Size(78, 45);
            btnSideBar.TabIndex = 27;
            btnSideBar.Text = "≡";
            btnSideBar.UseVisualStyleBackColor = true;
            btnSideBar.Click += btnSideBar_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(btnSideBar);
            Controls.Add(lblGitHubDescription);
            Controls.Add(lblGitHubLink);
            Controls.Add(lblSettings);
            Controls.Add(lblAppearance);
            Controls.Add(cmbThemes);
            Name = "Settings";
            Size = new Size(300, 346);
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbThemes;
        private Label lblAppearance;
        private Label lblSettings;
        private Label lblGitHubLink;
        private Label lblGitHubDescription;
        private Button btnSideBar;
    }
}
