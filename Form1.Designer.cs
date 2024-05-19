namespace CalculatorAssignment
{
    partial class frmCalculator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInputOutput = new System.Windows.Forms.Label();
            this.btnHistoryToggle = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSignSwitch = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 22, 22, 22);
            this.splitContainer1.Size = new System.Drawing.Size(504, 307);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtInputOutput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHistoryToggle, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquareRoot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPower, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReciprocal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClearEntry, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBackspace, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiplication, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtraction, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAddition, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSignSwitch, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 267);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtInputOutput
            // 
            this.txtInputOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.txtInputOutput, 3);
            this.txtInputOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputOutput.Location = new System.Drawing.Point(2, 2);
            this.txtInputOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInputOutput.Name = "txtInputOutput";
            this.txtInputOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInputOutput.Size = new System.Drawing.Size(209, 22);
            this.txtInputOutput.TabIndex = 26;
            this.txtInputOutput.Text = "0";
            this.txtInputOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHistoryToggle
            // 
            this.btnHistoryToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistoryToggle.Location = new System.Drawing.Point(215, 2);
            this.btnHistoryToggle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistoryToggle.Name = "btnHistoryToggle";
            this.btnHistoryToggle.Size = new System.Drawing.Size(69, 22);
            this.btnHistoryToggle.TabIndex = 1;
            this.btnHistoryToggle.Text = "History";
            this.btnHistoryToggle.UseVisualStyleBackColor = true;
            this.btnHistoryToggle.Click += new System.EventHandler(this.btnHistoryToggle_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquareRoot.Location = new System.Drawing.Point(2, 28);
            this.btnSquareRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(67, 36);
            this.btnSquareRoot.TabIndex = 2;
            this.btnSquareRoot.Text = "Sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.Location = new System.Drawing.Point(73, 28);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(67, 36);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnPower
            // 
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.Location = new System.Drawing.Point(144, 28);
            this.btnPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(67, 36);
            this.btnPower.TabIndex = 4;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReciprocal.Location = new System.Drawing.Point(215, 28);
            this.btnReciprocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(69, 36);
            this.btnReciprocal.TabIndex = 5;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEntry.Location = new System.Drawing.Point(2, 68);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(67, 36);
            this.btnClearEntry.TabIndex = 6;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearAll.Location = new System.Drawing.Point(73, 68);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(67, 36);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "CA";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.Location = new System.Drawing.Point(144, 68);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(67, 36);
            this.btnBackspace.TabIndex = 8;
            this.btnBackspace.Text = "Del";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Location = new System.Drawing.Point(215, 68);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(69, 36);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.Location = new System.Drawing.Point(2, 108);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(67, 36);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.Location = new System.Drawing.Point(73, 108);
            this.btnEight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(67, 36);
            this.btnEight.TabIndex = 11;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.Location = new System.Drawing.Point(144, 108);
            this.btnNine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(67, 36);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiplication.Location = new System.Drawing.Point(215, 108);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(69, 36);
            this.btnMultiplication.TabIndex = 13;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Location = new System.Drawing.Point(2, 148);
            this.btnFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(67, 36);
            this.btnFour.TabIndex = 14;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.Location = new System.Drawing.Point(73, 148);
            this.btnFive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(67, 36);
            this.btnFive.TabIndex = 15;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.Location = new System.Drawing.Point(144, 148);
            this.btnSix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(67, 36);
            this.btnSix.TabIndex = 16;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtraction.Location = new System.Drawing.Point(215, 148);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(69, 36);
            this.btnSubtraction.TabIndex = 17;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Location = new System.Drawing.Point(2, 188);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(67, 36);
            this.btnOne.TabIndex = 18;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Location = new System.Drawing.Point(73, 188);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(67, 36);
            this.btnTwo.TabIndex = 19;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Location = new System.Drawing.Point(144, 188);
            this.btnThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(67, 36);
            this.btnThree.TabIndex = 20;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddition.Location = new System.Drawing.Point(215, 188);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(69, 36);
            this.btnAddition.TabIndex = 21;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSignSwitch
            // 
            this.btnSignSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignSwitch.Location = new System.Drawing.Point(2, 228);
            this.btnSignSwitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignSwitch.Name = "btnSignSwitch";
            this.btnSignSwitch.Size = new System.Drawing.Size(67, 37);
            this.btnSignSwitch.TabIndex = 22;
            this.btnSignSwitch.Text = "+/-";
            this.btnSignSwitch.UseVisualStyleBackColor = true;
            this.btnSignSwitch.Click += new System.EventHandler(this.btnSignSwitch_Click);
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Location = new System.Drawing.Point(73, 228);
            this.btnZero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(67, 37);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Location = new System.Drawing.Point(144, 228);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(67, 37);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Location = new System.Drawing.Point(215, 228);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(69, 37);
            this.btnEquals.TabIndex = 25;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 22);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(152, 263);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            this.columnHeader1.Width = 100;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 307);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnHistoryToggle;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnSignSwitch;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label txtInputOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

