namespace CalculatorProject.Forms
{
    partial class Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            txtDisplay = new TextBox();
            btnExecute = new Button();
            btnDelete = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnDivide = new Button();
            lblCalc = new Label();
            btnHistory = new Button();
            btnSideBar = new Button();
            tmrSideBar = new System.Windows.Forms.Timer(components);
            btnAbs = new Button();
            btnRemainder = new Button();
            btnMemoryStore = new Button();
            btnMemoryClear = new Button();
            btnMemoryRead = new Button();
            btnMemoryAdd = new Button();
            btnMemoryView = new Button();
            btnMemorySubtract = new Button();
            btnDegreesRadians = new Button();
            btnNCR = new Button();
            btnSine = new Button();
            btnCosine = new Button();
            btnTangent = new Button();
            btnEuler = new Button();
            btnPi = new Button();
            btnFactorial = new Button();
            btnXPowN = new Button();
            btnTenPow = new Button();
            btnLog = new Button();
            btnNaturalLog = new Button();
            btnReciprocal = new Button();
            btnSquare = new Button();
            btnSqrt = new Button();
            btnFive = new Button();
            btnTwo = new Button();
            btnSeven = new Button();
            btnFour = new Button();
            btnOne = new Button();
            btnThree = new Button();
            btnSix = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnPlusMinus = new Button();
            btnDecimal = new Button();
            btnZero = new Button();
            btnClear = new Button();
            tmrHistory = new System.Windows.Forms.Timer(components);
            tmrMemory = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(2, 74);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(348, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.TabStop = false;
            txtDisplay.Tag = "Secondary";
            txtDisplay.Text = "5678";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.Enter += txtDisplay_Enter;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.FromArgb(243, 128, 100);
            btnExecute.FlatAppearance.BorderSize = 0;
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExecute.ForeColor = Color.Black;
            btnExecute.Location = new Point(282, 455);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(66, 35);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "=";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(50, 50, 50);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(282, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Tag = "Secondary";
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(50, 50, 50);
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(282, 347);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(66, 35);
            btnMultiply.TabIndex = 16;
            btnMultiply.Tag = "Secondary";
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(50, 50, 50);
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.ForeColor = Color.White;
            btnSubtract.Location = new Point(282, 383);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(66, 35);
            btnSubtract.TabIndex = 17;
            btnSubtract.Tag = "Secondary";
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 50, 50);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(282, 419);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 35);
            btnAdd.TabIndex = 18;
            btnAdd.Tag = "Secondary";
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(50, 50, 50);
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(282, 311);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(66, 35);
            btnDivide.TabIndex = 19;
            btnDivide.Tag = "Secondary";
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // lblCalc
            // 
            lblCalc.AutoSize = true;
            lblCalc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalc.ForeColor = Color.White;
            lblCalc.Location = new Point(141, 46);
            lblCalc.Name = "lblCalc";
            lblCalc.Size = new Size(133, 25);
            lblCalc.TabIndex = 22;
            lblCalc.Tag = "Secondary";
            lblCalc.Text = "<Calculation>";
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Location = new Point(307, 17);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(35, 35);
            btnHistory.TabIndex = 24;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnSideBar
            // 
            btnSideBar.FlatAppearance.BorderSize = 0;
            btnSideBar.FlatStyle = FlatStyle.Flat;
            btnSideBar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideBar.ForeColor = Color.White;
            btnSideBar.Location = new Point(12, 5);
            btnSideBar.Name = "btnSideBar";
            btnSideBar.Size = new Size(78, 45);
            btnSideBar.TabIndex = 25;
            btnSideBar.Text = "≡";
            btnSideBar.UseVisualStyleBackColor = true;
            btnSideBar.Click += btnSideBar_Click;
            // 
            // tmrSideBar
            // 
            tmrSideBar.Interval = 10;
            tmrSideBar.Tick += tmrSideBar_Tick;
            // 
            // btnAbs
            // 
            btnAbs.BackColor = Color.FromArgb(50, 50, 50);
            btnAbs.FlatAppearance.BorderSize = 0;
            btnAbs.FlatStyle = FlatStyle.Flat;
            btnAbs.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbs.ForeColor = Color.White;
            btnAbs.Location = new Point(282, 275);
            btnAbs.Name = "btnAbs";
            btnAbs.Size = new Size(66, 35);
            btnAbs.TabIndex = 31;
            btnAbs.Tag = "Secondary";
            btnAbs.Text = "l𝑥l";
            btnAbs.UseVisualStyleBackColor = false;
            btnAbs.Click += btnAbs_Click;
            // 
            // btnRemainder
            // 
            btnRemainder.BackColor = Color.FromArgb(50, 50, 50);
            btnRemainder.FlatAppearance.BorderSize = 0;
            btnRemainder.FlatStyle = FlatStyle.Flat;
            btnRemainder.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemainder.ForeColor = Color.White;
            btnRemainder.Location = new Point(282, 239);
            btnRemainder.Name = "btnRemainder";
            btnRemainder.Size = new Size(66, 35);
            btnRemainder.TabIndex = 38;
            btnRemainder.Tag = "Secondary";
            btnRemainder.Text = "mod";
            btnRemainder.UseVisualStyleBackColor = false;
            btnRemainder.Click += btnRemainder_Click;
            // 
            // btnMemoryStore
            // 
            btnMemoryStore.BackColor = Color.FromArgb(32, 32, 32);
            btnMemoryStore.FlatAppearance.BorderSize = 0;
            btnMemoryStore.FlatStyle = FlatStyle.Flat;
            btnMemoryStore.ForeColor = Color.White;
            btnMemoryStore.Location = new Point(285, 127);
            btnMemoryStore.Name = "btnMemoryStore";
            btnMemoryStore.Size = new Size(65, 30);
            btnMemoryStore.TabIndex = 42;
            btnMemoryStore.Tag = "Secondary";
            btnMemoryStore.Text = "MS";
            btnMemoryStore.UseVisualStyleBackColor = false;
            btnMemoryStore.Click += btnMemoryStore_Click;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.BackColor = Color.FromArgb(32, 32, 32);
            btnMemoryClear.FlatAppearance.BorderSize = 0;
            btnMemoryClear.FlatStyle = FlatStyle.Flat;
            btnMemoryClear.ForeColor = Color.White;
            btnMemoryClear.Location = new Point(6, 127);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(65, 30);
            btnMemoryClear.TabIndex = 78;
            btnMemoryClear.Tag = "Secondary";
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = false;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // btnMemoryRead
            // 
            btnMemoryRead.BackColor = Color.FromArgb(32, 32, 32);
            btnMemoryRead.FlatAppearance.BorderSize = 0;
            btnMemoryRead.FlatStyle = FlatStyle.Flat;
            btnMemoryRead.ForeColor = Color.White;
            btnMemoryRead.Location = new Point(75, 127);
            btnMemoryRead.Name = "btnMemoryRead";
            btnMemoryRead.Size = new Size(65, 30);
            btnMemoryRead.TabIndex = 77;
            btnMemoryRead.Tag = "Secondary";
            btnMemoryRead.Text = "MR";
            btnMemoryRead.UseVisualStyleBackColor = false;
            btnMemoryRead.Click += btnMemoryRead_Click;
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.BackColor = Color.FromArgb(32, 32, 32);
            btnMemoryAdd.FlatAppearance.BorderSize = 0;
            btnMemoryAdd.FlatStyle = FlatStyle.Flat;
            btnMemoryAdd.ForeColor = Color.White;
            btnMemoryAdd.Location = new Point(143, 127);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(65, 30);
            btnMemoryAdd.TabIndex = 76;
            btnMemoryAdd.Tag = "Secondary";
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = false;
            btnMemoryAdd.Click += btnMemoryAdd_Click;
            // 
            // btnMemoryView
            // 
            btnMemoryView.BackColor = Color.FromArgb(32, 32, 32);
            btnMemoryView.FlatAppearance.BorderSize = 0;
            btnMemoryView.FlatStyle = FlatStyle.Flat;
            btnMemoryView.ForeColor = Color.White;
            btnMemoryView.Location = new Point(7, 167);
            btnMemoryView.Name = "btnMemoryView";
            btnMemoryView.Size = new Size(65, 27);
            btnMemoryView.TabIndex = 75;
            btnMemoryView.Tag = "Secondary";
            btnMemoryView.Text = "Mv";
            btnMemoryView.UseVisualStyleBackColor = false;
            btnMemoryView.Click += btnMemoryView_Click;
            // 
            // btnMemorySubtract
            // 
            btnMemorySubtract.BackColor = Color.FromArgb(32, 32, 32);
            btnMemorySubtract.FlatAppearance.BorderSize = 0;
            btnMemorySubtract.FlatStyle = FlatStyle.Flat;
            btnMemorySubtract.ForeColor = Color.White;
            btnMemorySubtract.Location = new Point(210, 127);
            btnMemorySubtract.Name = "btnMemorySubtract";
            btnMemorySubtract.Size = new Size(65, 30);
            btnMemorySubtract.TabIndex = 74;
            btnMemorySubtract.Tag = "Secondary";
            btnMemorySubtract.Text = "M-";
            btnMemorySubtract.UseVisualStyleBackColor = false;
            btnMemorySubtract.Click += btnMemorySubtract_Click;
            // 
            // btnDegreesRadians
            // 
            btnDegreesRadians.BackColor = Color.FromArgb(50, 50, 50);
            btnDegreesRadians.FlatAppearance.BorderSize = 0;
            btnDegreesRadians.FlatStyle = FlatStyle.Flat;
            btnDegreesRadians.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDegreesRadians.ForeColor = Color.White;
            btnDegreesRadians.Location = new Point(134, 198);
            btnDegreesRadians.Name = "btnDegreesRadians";
            btnDegreesRadians.Size = new Size(66, 35);
            btnDegreesRadians.TabIndex = 73;
            btnDegreesRadians.Tag = "Secondary";
            btnDegreesRadians.Text = "deg";
            btnDegreesRadians.UseVisualStyleBackColor = false;
            btnDegreesRadians.Click += btnDegreesRadians_Click;
            // 
            // btnNCR
            // 
            btnNCR.BackColor = Color.FromArgb(50, 50, 50);
            btnNCR.FlatAppearance.BorderSize = 0;
            btnNCR.FlatStyle = FlatStyle.Flat;
            btnNCR.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNCR.ForeColor = Color.White;
            btnNCR.Location = new Point(74, 275);
            btnNCR.Name = "btnNCR";
            btnNCR.Size = new Size(66, 35);
            btnNCR.TabIndex = 72;
            btnNCR.Tag = "Secondary";
            btnNCR.Text = "nCr";
            btnNCR.UseVisualStyleBackColor = false;
            btnNCR.Click += btnNCR_Click;
            // 
            // btnSine
            // 
            btnSine.BackColor = Color.FromArgb(50, 50, 50);
            btnSine.FlatAppearance.BorderSize = 0;
            btnSine.FlatStyle = FlatStyle.Flat;
            btnSine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSine.ForeColor = Color.White;
            btnSine.Location = new Point(74, 239);
            btnSine.Name = "btnSine";
            btnSine.Size = new Size(66, 35);
            btnSine.TabIndex = 71;
            btnSine.Tag = "Secondary";
            btnSine.Text = "sin";
            btnSine.UseVisualStyleBackColor = false;
            btnSine.Click += btnSine_Click;
            // 
            // btnCosine
            // 
            btnCosine.BackColor = Color.FromArgb(50, 50, 50);
            btnCosine.FlatAppearance.BorderSize = 0;
            btnCosine.FlatStyle = FlatStyle.Flat;
            btnCosine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCosine.ForeColor = Color.White;
            btnCosine.Location = new Point(142, 239);
            btnCosine.Name = "btnCosine";
            btnCosine.Size = new Size(66, 35);
            btnCosine.TabIndex = 70;
            btnCosine.Tag = "Secondary";
            btnCosine.Text = "cos";
            btnCosine.UseVisualStyleBackColor = false;
            btnCosine.Click += btnCosine_Click;
            // 
            // btnTangent
            // 
            btnTangent.BackColor = Color.FromArgb(50, 50, 50);
            btnTangent.FlatAppearance.BorderSize = 0;
            btnTangent.FlatStyle = FlatStyle.Flat;
            btnTangent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTangent.ForeColor = Color.White;
            btnTangent.Location = new Point(210, 239);
            btnTangent.Name = "btnTangent";
            btnTangent.Size = new Size(66, 35);
            btnTangent.TabIndex = 69;
            btnTangent.Tag = "Secondary";
            btnTangent.Text = "tan";
            btnTangent.UseVisualStyleBackColor = false;
            btnTangent.Click += btnTangent_Click;
            // 
            // btnEuler
            // 
            btnEuler.BackColor = Color.FromArgb(50, 50, 50);
            btnEuler.FlatAppearance.BorderSize = 0;
            btnEuler.FlatStyle = FlatStyle.Flat;
            btnEuler.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEuler.ForeColor = Color.White;
            btnEuler.Location = new Point(142, 275);
            btnEuler.Name = "btnEuler";
            btnEuler.Size = new Size(66, 35);
            btnEuler.TabIndex = 68;
            btnEuler.Tag = "Secondary";
            btnEuler.Text = "e";
            btnEuler.UseVisualStyleBackColor = false;
            btnEuler.Click += btnEuler_Click;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.FromArgb(50, 50, 50);
            btnPi.FlatAppearance.BorderSize = 0;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPi.ForeColor = Color.White;
            btnPi.Location = new Point(210, 275);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(66, 35);
            btnPi.TabIndex = 67;
            btnPi.Tag = "Secondary";
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += btnPi_Click;
            // 
            // btnFactorial
            // 
            btnFactorial.BackColor = Color.FromArgb(50, 50, 50);
            btnFactorial.FlatAppearance.BorderSize = 0;
            btnFactorial.FlatStyle = FlatStyle.Flat;
            btnFactorial.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFactorial.ForeColor = Color.White;
            btnFactorial.Location = new Point(6, 311);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(66, 35);
            btnFactorial.TabIndex = 66;
            btnFactorial.Tag = "Secondary";
            btnFactorial.Text = "n!";
            btnFactorial.UseVisualStyleBackColor = false;
            btnFactorial.Click += btnFactorial_Click;
            // 
            // btnXPowN
            // 
            btnXPowN.BackColor = Color.FromArgb(50, 50, 50);
            btnXPowN.FlatAppearance.BorderSize = 0;
            btnXPowN.FlatStyle = FlatStyle.Flat;
            btnXPowN.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnXPowN.ForeColor = Color.White;
            btnXPowN.Location = new Point(6, 347);
            btnXPowN.Name = "btnXPowN";
            btnXPowN.Size = new Size(66, 35);
            btnXPowN.TabIndex = 65;
            btnXPowN.Tag = "Secondary";
            btnXPowN.Text = "𝑥ⁿ";
            btnXPowN.UseVisualStyleBackColor = false;
            btnXPowN.Click += btnXPowN_Click;
            // 
            // btnTenPow
            // 
            btnTenPow.BackColor = Color.FromArgb(50, 50, 50);
            btnTenPow.FlatAppearance.BorderSize = 0;
            btnTenPow.FlatStyle = FlatStyle.Flat;
            btnTenPow.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTenPow.ForeColor = Color.White;
            btnTenPow.Location = new Point(6, 383);
            btnTenPow.Name = "btnTenPow";
            btnTenPow.Size = new Size(66, 35);
            btnTenPow.TabIndex = 64;
            btnTenPow.Tag = "Secondary";
            btnTenPow.Text = "10ⁿ";
            btnTenPow.UseVisualStyleBackColor = false;
            btnTenPow.Click += btnTenPow_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(50, 50, 50);
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.ForeColor = Color.White;
            btnLog.Location = new Point(6, 419);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(66, 35);
            btnLog.TabIndex = 63;
            btnLog.Tag = "Secondary";
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnNaturalLog
            // 
            btnNaturalLog.BackColor = Color.FromArgb(50, 50, 50);
            btnNaturalLog.FlatAppearance.BorderSize = 0;
            btnNaturalLog.FlatStyle = FlatStyle.Flat;
            btnNaturalLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNaturalLog.ForeColor = Color.White;
            btnNaturalLog.Location = new Point(6, 455);
            btnNaturalLog.Name = "btnNaturalLog";
            btnNaturalLog.Size = new Size(66, 35);
            btnNaturalLog.TabIndex = 62;
            btnNaturalLog.Tag = "Secondary";
            btnNaturalLog.Text = "ln";
            btnNaturalLog.UseVisualStyleBackColor = false;
            btnNaturalLog.Click += btnNaturalLog_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.BackColor = Color.FromArgb(50, 50, 50);
            btnReciprocal.FlatAppearance.BorderSize = 0;
            btnReciprocal.FlatStyle = FlatStyle.Flat;
            btnReciprocal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReciprocal.ForeColor = Color.White;
            btnReciprocal.Location = new Point(74, 311);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(66, 35);
            btnReciprocal.TabIndex = 61;
            btnReciprocal.Tag = "Secondary";
            btnReciprocal.Text = "¹/𝑥";
            btnReciprocal.UseVisualStyleBackColor = false;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.FromArgb(50, 50, 50);
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSquare.ForeColor = Color.White;
            btnSquare.Location = new Point(142, 311);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(66, 35);
            btnSquare.TabIndex = 60;
            btnSquare.Tag = "Secondary";
            btnSquare.Text = "𝑥²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(50, 50, 50);
            btnSqrt.FlatAppearance.BorderSize = 0;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqrt.ForeColor = Color.White;
            btnSqrt.Location = new Point(210, 311);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(66, 35);
            btnSqrt.TabIndex = 59;
            btnSqrt.Tag = "Secondary";
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.FromArgb(59, 59, 59);
            btnFive.FlatAppearance.BorderSize = 0;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.ForeColor = Color.White;
            btnFive.Location = new Point(142, 383);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(66, 35);
            btnFive.TabIndex = 58;
            btnFive.Tag = "Primary";
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.FromArgb(59, 59, 59);
            btnTwo.FlatAppearance.BorderSize = 0;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.ForeColor = Color.White;
            btnTwo.Location = new Point(142, 419);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(66, 35);
            btnTwo.TabIndex = 57;
            btnTwo.Tag = "Primary";
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.FromArgb(59, 59, 59);
            btnSeven.FlatAppearance.BorderSize = 0;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.ForeColor = Color.White;
            btnSeven.Location = new Point(74, 347);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(66, 35);
            btnSeven.TabIndex = 56;
            btnSeven.Tag = "Primary";
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.FromArgb(59, 59, 59);
            btnFour.FlatAppearance.BorderSize = 0;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.ForeColor = Color.White;
            btnFour.Location = new Point(74, 383);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(66, 35);
            btnFour.TabIndex = 55;
            btnFour.Tag = "Primary";
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.FromArgb(59, 59, 59);
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.ForeColor = Color.White;
            btnOne.Location = new Point(74, 419);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(66, 35);
            btnOne.TabIndex = 54;
            btnOne.Tag = "Primary";
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.FromArgb(59, 59, 59);
            btnThree.FlatAppearance.BorderSize = 0;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.ForeColor = Color.White;
            btnThree.Location = new Point(210, 419);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(66, 35);
            btnThree.TabIndex = 53;
            btnThree.Tag = "Primary";
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.FromArgb(59, 59, 59);
            btnSix.FlatAppearance.BorderSize = 0;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.ForeColor = Color.White;
            btnSix.Location = new Point(210, 383);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(66, 35);
            btnSix.TabIndex = 52;
            btnSix.Tag = "Primary";
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.FromArgb(59, 59, 59);
            btnEight.FlatAppearance.BorderSize = 0;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.ForeColor = Color.White;
            btnEight.Location = new Point(142, 347);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(66, 35);
            btnEight.TabIndex = 51;
            btnEight.Tag = "Primary";
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.FromArgb(59, 59, 59);
            btnNine.FlatAppearance.BorderSize = 0;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.ForeColor = Color.White;
            btnNine.Location = new Point(210, 347);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(66, 35);
            btnNine.TabIndex = 50;
            btnNine.Tag = "Primary";
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.FromArgb(59, 59, 59);
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            btnPlusMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlusMinus.ForeColor = Color.White;
            btnPlusMinus.Location = new Point(74, 455);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(66, 35);
            btnPlusMinus.TabIndex = 49;
            btnPlusMinus.Tag = "Primary";
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(59, 59, 59);
            btnDecimal.FlatAppearance.BorderSize = 0;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimal.ForeColor = Color.White;
            btnDecimal.Location = new Point(142, 455);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(66, 35);
            btnDecimal.TabIndex = 48;
            btnDecimal.Tag = "Primary";
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(59, 59, 59);
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(210, 455);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(66, 35);
            btnZero.TabIndex = 47;
            btnZero.Tag = "Primary";
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(50, 50, 50);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(206, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 35);
            btnClear.TabIndex = 46;
            btnClear.Tag = "Secondary";
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tmrHistory
            // 
            tmrHistory.Interval = 10;
            tmrHistory.Tick += tmrHistory_Tick;
            // 
            // tmrMemory
            // 
            tmrMemory.Interval = 10;
            tmrMemory.Tick += tmrMemory_Tick;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(354, 493);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnMemoryRead);
            Controls.Add(btnMemoryAdd);
            Controls.Add(btnMemoryView);
            Controls.Add(btnMemorySubtract);
            Controls.Add(btnDegreesRadians);
            Controls.Add(btnNCR);
            Controls.Add(btnSine);
            Controls.Add(btnCosine);
            Controls.Add(btnTangent);
            Controls.Add(btnEuler);
            Controls.Add(btnPi);
            Controls.Add(btnFactorial);
            Controls.Add(btnXPowN);
            Controls.Add(btnTenPow);
            Controls.Add(btnLog);
            Controls.Add(btnNaturalLog);
            Controls.Add(btnReciprocal);
            Controls.Add(btnSquare);
            Controls.Add(btnSqrt);
            Controls.Add(btnFive);
            Controls.Add(btnTwo);
            Controls.Add(btnSeven);
            Controls.Add(btnFour);
            Controls.Add(btnOne);
            Controls.Add(btnThree);
            Controls.Add(btnSix);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(btnClear);
            Controls.Add(btnMemoryStore);
            Controls.Add(btnRemainder);
            Controls.Add(btnAbs);
            Controls.Add(btnSideBar);
            Controls.Add(btnHistory);
            Controls.Add(lblCalc);
            Controls.Add(btnDivide);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDelete);
            Controls.Add(btnExecute);
            Controls.Add(txtDisplay);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            FormClosing += Calculator_FormClosing;
            Load += Calculator_Load;
            Click += Calculator_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnExecute;
        private Button btnDelete;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnDivide;
        private Label lblCalc;
        private Button btnHistory;
        private Button btnSideBar;
        private System.Windows.Forms.Timer tmrSideBar;
        private Button btnAbs;
        private Button btnRemainder;
        private Button btnMemoryStore;
        private Button btnMemoryClear;
        private Button btnMemoryRead;
        private Button btnMemoryAdd;
        private Button btnMemoryView;
        private Button btnMemorySubtract;
        private Button btnDegreesRadians;
        private Button btnNCR;
        private Button btnSine;
        private Button btnCosine;
        private Button btnTangent;
        private Button btnEuler;
        private Button btnPi;
        private Button btnFactorial;
        private Button btnXPowN;
        private Button btnTenPow;
        private Button btnLog;
        private Button btnNaturalLog;
        private Button btnReciprocal;
        private Button btnSquare;
        private Button btnSqrt;
        private Button btnFive;
        private Button btnTwo;
        private Button btnSeven;
        private Button btnFour;
        private Button btnOne;
        private Button btnThree;
        private Button btnSix;
        private Button btnEight;
        private Button btnNine;
        private Button btnPlusMinus;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnClear;
        private System.Windows.Forms.Timer tmrHistory;
        private System.Windows.Forms.Timer tmrMemory;
    }
}