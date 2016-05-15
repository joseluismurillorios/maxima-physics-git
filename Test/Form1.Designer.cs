namespace Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUI = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUICartesian = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlCartesian = new System.Windows.Forms.Panel();
            this.pnlUIEntry = new System.Windows.Forms.Panel();
            this.pnlKinematic = new System.Windows.Forms.Panel();
            this.tlpKinematic = new System.Windows.Forms.TableLayoutPanel();
            this.lblResKin2 = new System.Windows.Forms.RichTextBox();
            this.lblResKin = new System.Windows.Forms.RichTextBox();
            this.txtSeconds2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSolveEQ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcceleration = new System.Windows.Forms.TextBox();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEQ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResKin0 = new System.Windows.Forms.RichTextBox();
            this.pnlEntries = new System.Windows.Forms.Panel();
            this.tlpEntry = new System.Windows.Forms.TableLayoutPanel();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtSumY = new System.Windows.Forms.TextBox();
            this.txtSumX = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.tlpTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnCartV = new System.Windows.Forms.Button();
            this.btnCartRight = new System.Windows.Forms.Button();
            this.btnCartUp = new System.Windows.Forms.Button();
            this.btnCartCenter = new System.Windows.Forms.Button();
            this.btnCartLeft = new System.Windows.Forms.Button();
            this.btnCartH = new System.Windows.Forms.Button();
            this.btnCartDown = new System.Windows.Forms.Button();
            this.tlpSelected = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKinematic = new System.Windows.Forms.Button();
            this.btnEquilib = new System.Windows.Forms.Button();
            this.btnResultant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            this.tlpUI.SuspendLayout();
            this.pnlUICartesian.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlUIEntry.SuspendLayout();
            this.pnlKinematic.SuspendLayout();
            this.tlpKinematic.SuspendLayout();
            this.pnlEntries.SuspendLayout();
            this.tlpEntry.SuspendLayout();
            this.tlpTools.SuspendLayout();
            this.tlpSelected.SuspendLayout();
            this.tlpNav.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.Controls.Add(this.tlpUI, 2, 1);
            this.tlpMain.Controls.Add(this.tlpTools, 3, 1);
            this.tlpMain.Controls.Add(this.tlpSelected, 0, 1);
            this.tlpMain.Controls.Add(this.lblTitle, 2, 0);
            this.tlpMain.Controls.Add(this.tlpNav, 1, 1);
            this.tlpMain.Controls.Add(this.panel1, 0, 0);
            this.tlpMain.Controls.Add(this.panel2, 1, 0);
            this.tlpMain.Controls.Add(this.panel3, 3, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(952, 496);
            this.tlpMain.TabIndex = 5;
            // 
            // tlpUI
            // 
            this.tlpUI.BackColor = System.Drawing.Color.Gainsboro;
            this.tlpUI.ColumnCount = 2;
            this.tlpUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpUI.Controls.Add(this.pnlUICartesian, 1, 0);
            this.tlpUI.Controls.Add(this.pnlUIEntry, 0, 0);
            this.tlpUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUI.Location = new System.Drawing.Point(104, 60);
            this.tlpUI.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUI.Name = "tlpUI";
            this.tlpUI.RowCount = 1;
            this.tlpUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 436F));
            this.tlpUI.Size = new System.Drawing.Size(812, 436);
            this.tlpUI.TabIndex = 0;
            // 
            // pnlUICartesian
            // 
            this.pnlUICartesian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUICartesian.Controls.Add(this.pnlCart);
            this.pnlUICartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUICartesian.Location = new System.Drawing.Point(325, 0);
            this.pnlUICartesian.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlUICartesian.Name = "pnlUICartesian";
            this.pnlUICartesian.Size = new System.Drawing.Size(487, 436);
            this.pnlUICartesian.TabIndex = 5;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCart.Controls.Add(this.pnlCartesian);
            this.pnlCart.Location = new System.Drawing.Point(29, 2);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCart.MinimumSize = new System.Drawing.Size(402, 402);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(1);
            this.pnlCart.Size = new System.Drawing.Size(402, 402);
            this.pnlCart.TabIndex = 3;
            // 
            // pnlCartesian
            // 
            this.pnlCartesian.BackColor = System.Drawing.Color.White;
            this.pnlCartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartesian.Location = new System.Drawing.Point(1, 1);
            this.pnlCartesian.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCartesian.MaximumSize = new System.Drawing.Size(400, 400);
            this.pnlCartesian.Name = "pnlCartesian";
            this.pnlCartesian.Size = new System.Drawing.Size(400, 400);
            this.pnlCartesian.TabIndex = 2;
            this.pnlCartesian.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCartesian_Paint);
            // 
            // pnlUIEntry
            // 
            this.pnlUIEntry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUIEntry.Controls.Add(this.pnlKinematic);
            this.pnlUIEntry.Controls.Add(this.pnlEntries);
            this.pnlUIEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUIEntry.Location = new System.Drawing.Point(0, 0);
            this.pnlUIEntry.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUIEntry.Name = "pnlUIEntry";
            this.pnlUIEntry.Size = new System.Drawing.Size(324, 436);
            this.pnlUIEntry.TabIndex = 6;
            // 
            // pnlKinematic
            // 
            this.pnlKinematic.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlKinematic.Controls.Add(this.tlpKinematic);
            this.pnlKinematic.Location = new System.Drawing.Point(163, 1);
            this.pnlKinematic.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKinematic.Name = "pnlKinematic";
            this.pnlKinematic.Padding = new System.Windows.Forms.Padding(1);
            this.pnlKinematic.Size = new System.Drawing.Size(133, 314);
            this.pnlKinematic.TabIndex = 8;
            // 
            // tlpKinematic
            // 
            this.tlpKinematic.BackColor = System.Drawing.Color.White;
            this.tlpKinematic.ColumnCount = 2;
            this.tlpKinematic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKinematic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKinematic.Controls.Add(this.lblResKin2, 1, 11);
            this.tlpKinematic.Controls.Add(this.lblResKin, 0, 11);
            this.tlpKinematic.Controls.Add(this.txtSeconds2, 1, 3);
            this.tlpKinematic.Controls.Add(this.label1, 1, 2);
            this.tlpKinematic.Controls.Add(this.btnClear, 1, 14);
            this.tlpKinematic.Controls.Add(this.btnSolveEQ, 0, 14);
            this.tlpKinematic.Controls.Add(this.label3, 0, 0);
            this.tlpKinematic.Controls.Add(this.txtAcceleration, 0, 7);
            this.tlpKinematic.Controls.Add(this.txtVelocity, 0, 5);
            this.tlpKinematic.Controls.Add(this.label5, 0, 6);
            this.tlpKinematic.Controls.Add(this.txtEQ, 0, 1);
            this.tlpKinematic.Controls.Add(this.label8, 0, 2);
            this.tlpKinematic.Controls.Add(this.txtSeconds, 0, 3);
            this.tlpKinematic.Controls.Add(this.label9, 0, 4);
            this.tlpKinematic.Controls.Add(this.lblResKin0, 0, 8);
            this.tlpKinematic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKinematic.Location = new System.Drawing.Point(1, 1);
            this.tlpKinematic.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKinematic.Name = "tlpKinematic";
            this.tlpKinematic.RowCount = 16;
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpKinematic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpKinematic.Size = new System.Drawing.Size(131, 312);
            this.tlpKinematic.TabIndex = 6;
            // 
            // lblResKin2
            // 
            this.lblResKin2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResKin2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblResKin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResKin2.Font = new System.Drawing.Font("Lato", 8.25F);
            this.lblResKin2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblResKin2.Location = new System.Drawing.Point(68, 212);
            this.lblResKin2.Name = "lblResKin2";
            this.lblResKin2.ReadOnly = true;
            this.tlpKinematic.SetRowSpan(this.lblResKin2, 2);
            this.lblResKin2.Size = new System.Drawing.Size(60, 32);
            this.lblResKin2.TabIndex = 50;
            this.lblResKin2.TabStop = false;
            this.lblResKin2.Text = "";
            // 
            // lblResKin
            // 
            this.lblResKin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResKin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblResKin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResKin.Font = new System.Drawing.Font("Lato", 8.25F);
            this.lblResKin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblResKin.Location = new System.Drawing.Point(3, 212);
            this.lblResKin.Name = "lblResKin";
            this.lblResKin.ReadOnly = true;
            this.tlpKinematic.SetRowSpan(this.lblResKin, 2);
            this.lblResKin.Size = new System.Drawing.Size(59, 32);
            this.lblResKin.TabIndex = 49;
            this.lblResKin.TabStop = false;
            this.lblResKin.Text = "";
            // 
            // txtSeconds2
            // 
            this.txtSeconds2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSeconds2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeconds2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtSeconds2.Location = new System.Drawing.Point(75, 57);
            this.txtSeconds2.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.txtSeconds2.Name = "txtSeconds2";
            this.txtSeconds2.Size = new System.Drawing.Size(36, 14);
            this.txtSeconds2.TabIndex = 2;
            this.txtSeconds2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "SECONDS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(75, 267);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 1, 20, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 17);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSolveEQ
            // 
            this.btnSolveEQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnSolveEQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSolveEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolveEQ.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolveEQ.ForeColor = System.Drawing.Color.White;
            this.btnSolveEQ.Location = new System.Drawing.Point(20, 267);
            this.btnSolveEQ.Margin = new System.Windows.Forms.Padding(20, 1, 10, 1);
            this.btnSolveEQ.Name = "btnSolveEQ";
            this.btnSolveEQ.Size = new System.Drawing.Size(35, 17);
            this.btnSolveEQ.TabIndex = 3;
            this.btnSolveEQ.Text = "SOLVE";
            this.btnSolveEQ.UseVisualStyleBackColor = false;
            this.btnSolveEQ.Click += new System.EventHandler(this.btnSolveEQ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tlpKinematic.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "EQUATION:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAcceleration
            // 
            this.txtAcceleration.BackColor = System.Drawing.Color.White;
            this.txtAcceleration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpKinematic.SetColumnSpan(this.txtAcceleration, 2);
            this.txtAcceleration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAcceleration.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcceleration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtAcceleration.Location = new System.Drawing.Point(20, 133);
            this.txtAcceleration.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAcceleration.Name = "txtAcceleration";
            this.txtAcceleration.Size = new System.Drawing.Size(91, 14);
            this.txtAcceleration.TabIndex = 43;
            this.txtAcceleration.TabStop = false;
            this.txtAcceleration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVelocity
            // 
            this.txtVelocity.BackColor = System.Drawing.Color.White;
            this.txtVelocity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpKinematic.SetColumnSpan(this.txtVelocity, 2);
            this.txtVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVelocity.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtVelocity.Location = new System.Drawing.Point(20, 95);
            this.txtVelocity.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.ReadOnly = true;
            this.txtVelocity.Size = new System.Drawing.Size(91, 14);
            this.txtVelocity.TabIndex = 42;
            this.txtVelocity.TabStop = false;
            this.txtVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tlpKinematic.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "ACCELERATION FUNCTION:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEQ
            // 
            this.txtEQ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpKinematic.SetColumnSpan(this.txtEQ, 2);
            this.txtEQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEQ.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtEQ.Location = new System.Drawing.Point(20, 19);
            this.txtEQ.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtEQ.Name = "txtEQ";
            this.txtEQ.Size = new System.Drawing.Size(91, 14);
            this.txtEQ.TabIndex = 0;
            this.txtEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "SECONDS:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeconds.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtSeconds.Location = new System.Drawing.Point(20, 57);
            this.txtSeconds.Margin = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(35, 14);
            this.txtSeconds.TabIndex = 1;
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tlpKinematic.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(3, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "VELOCITY FUNCTION:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResKin0
            // 
            this.lblResKin0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResKin0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpKinematic.SetColumnSpan(this.lblResKin0, 2);
            this.lblResKin0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResKin0.Font = new System.Drawing.Font("Lato", 8.25F);
            this.lblResKin0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblResKin0.Location = new System.Drawing.Point(3, 155);
            this.lblResKin0.Name = "lblResKin0";
            this.lblResKin0.ReadOnly = true;
            this.tlpKinematic.SetRowSpan(this.lblResKin0, 3);
            this.lblResKin0.Size = new System.Drawing.Size(125, 51);
            this.lblResKin0.TabIndex = 48;
            this.lblResKin0.TabStop = false;
            this.lblResKin0.Text = "";
            // 
            // pnlEntries
            // 
            this.pnlEntries.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlEntries.Controls.Add(this.tlpEntry);
            this.pnlEntries.Location = new System.Drawing.Point(0, 0);
            this.pnlEntries.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEntries.Name = "pnlEntries";
            this.pnlEntries.Padding = new System.Windows.Forms.Padding(1);
            this.pnlEntries.Size = new System.Drawing.Size(164, 316);
            this.pnlEntries.TabIndex = 7;
            // 
            // tlpEntry
            // 
            this.tlpEntry.BackColor = System.Drawing.Color.White;
            this.tlpEntry.ColumnCount = 2;
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntry.Controls.Add(this.lblResult2, 1, 8);
            this.tlpEntry.Controls.Add(this.lblResult, 0, 8);
            this.tlpEntry.Controls.Add(this.btnNew, 1, 11);
            this.tlpEntry.Controls.Add(this.btnRes, 1, 9);
            this.tlpEntry.Controls.Add(this.btnMode, 0, 11);
            this.tlpEntry.Controls.Add(this.txtAngulo, 1, 7);
            this.tlpEntry.Controls.Add(this.btnDraw, 0, 9);
            this.tlpEntry.Controls.Add(this.lblA, 0, 0);
            this.tlpEntry.Controls.Add(this.lblH, 1, 6);
            this.tlpEntry.Controls.Add(this.txtRes, 0, 7);
            this.tlpEntry.Controls.Add(this.txtSumY, 1, 5);
            this.tlpEntry.Controls.Add(this.txtSumX, 0, 5);
            this.tlpEntry.Controls.Add(this.lblG, 0, 6);
            this.tlpEntry.Controls.Add(this.txtMagnitud, 0, 1);
            this.tlpEntry.Controls.Add(this.lblF, 1, 4);
            this.tlpEntry.Controls.Add(this.txtY, 1, 3);
            this.tlpEntry.Controls.Add(this.lblB, 1, 0);
            this.tlpEntry.Controls.Add(this.txtAlfa, 1, 1);
            this.tlpEntry.Controls.Add(this.lblC, 0, 2);
            this.tlpEntry.Controls.Add(this.txtX, 0, 3);
            this.tlpEntry.Controls.Add(this.lblE, 0, 4);
            this.tlpEntry.Controls.Add(this.lblD, 1, 2);
            this.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEntry.Location = new System.Drawing.Point(1, 1);
            this.tlpEntry.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEntry.Name = "tlpEntry";
            this.tlpEntry.RowCount = 13;
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEntry.Size = new System.Drawing.Size(162, 314);
            this.tlpEntry.TabIndex = 6;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResult2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblResult2.Location = new System.Drawing.Point(81, 152);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblResult2.Size = new System.Drawing.Size(81, 72);
            this.lblResult2.TabIndex = 21;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblResult.Location = new System.Drawing.Point(0, 152);
            this.lblResult.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblResult.Size = new System.Drawing.Size(81, 72);
            this.lblResult.TabIndex = 20;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(91, 269);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 1, 20, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(51, 17);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.White;
            this.btnRes.Location = new System.Drawing.Point(91, 231);
            this.btnRes.Margin = new System.Windows.Forms.Padding(10, 1, 20, 1);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(51, 17);
            this.btnRes.TabIndex = 17;
            this.btnRes.Text = "SOLVE";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.White;
            this.btnMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnMode.Location = new System.Drawing.Point(20, 269);
            this.btnMode.Margin = new System.Windows.Forms.Padding(20, 1, 10, 1);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(51, 17);
            this.btnMode.TabIndex = 16;
            this.btnMode.Text = "F    |    A";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // txtAngulo
            // 
            this.txtAngulo.BackColor = System.Drawing.Color.White;
            this.txtAngulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAngulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAngulo.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtAngulo.Location = new System.Drawing.Point(101, 133);
            this.txtAngulo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.ReadOnly = true;
            this.txtAngulo.Size = new System.Drawing.Size(41, 14);
            this.txtAngulo.TabIndex = 19;
            this.txtAngulo.TabStop = false;
            this.txtAngulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.White;
            this.btnDraw.Location = new System.Drawing.Point(20, 231);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(20, 1, 10, 1);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(51, 17);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "ADD";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblA.Location = new System.Drawing.Point(3, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(75, 19);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "FORCE:";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblH.Location = new System.Drawing.Point(84, 114);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(75, 19);
            this.lblH.TabIndex = 18;
            this.lblH.Text = "THETA:";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.White;
            this.txtRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRes.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtRes.Location = new System.Drawing.Point(20, 133);
            this.txtRes.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(41, 14);
            this.txtRes.TabIndex = 14;
            this.txtRes.TabStop = false;
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSumY
            // 
            this.txtSumY.BackColor = System.Drawing.Color.White;
            this.txtSumY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSumY.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtSumY.Location = new System.Drawing.Point(101, 95);
            this.txtSumY.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtSumY.Name = "txtSumY";
            this.txtSumY.ReadOnly = true;
            this.txtSumY.Size = new System.Drawing.Size(41, 14);
            this.txtSumY.TabIndex = 11;
            this.txtSumY.TabStop = false;
            this.txtSumY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSumX
            // 
            this.txtSumX.BackColor = System.Drawing.Color.White;
            this.txtSumX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSumX.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtSumX.Location = new System.Drawing.Point(20, 95);
            this.txtSumX.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtSumX.Name = "txtSumX";
            this.txtSumX.ReadOnly = true;
            this.txtSumX.Size = new System.Drawing.Size(41, 14);
            this.txtSumX.TabIndex = 9;
            this.txtSumX.TabStop = false;
            this.txtSumX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblG.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblG.Location = new System.Drawing.Point(3, 114);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(75, 19);
            this.lblG.TabIndex = 15;
            this.lblG.Text = "RESULTANT:";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMagnitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMagnitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMagnitud.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMagnitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtMagnitud.Location = new System.Drawing.Point(20, 19);
            this.txtMagnitud.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(41, 14);
            this.txtMagnitud.TabIndex = 0;
            this.txtMagnitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblF.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblF.Location = new System.Drawing.Point(84, 76);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(75, 19);
            this.lblF.TabIndex = 12;
            this.lblF.Text = "SUM Y:";
            this.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtY
            // 
            this.txtY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtY.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtY.Location = new System.Drawing.Point(101, 57);
            this.txtY.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(41, 14);
            this.txtY.TabIndex = 5;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblB.Location = new System.Drawing.Point(84, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(75, 19);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "ALFA:";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlfa
            // 
            this.txtAlfa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlfa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlfa.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtAlfa.Location = new System.Drawing.Point(101, 19);
            this.txtAlfa.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(41, 14);
            this.txtAlfa.TabIndex = 1;
            this.txtAlfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblC.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblC.Location = new System.Drawing.Point(3, 38);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(75, 19);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "COMP X:";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtX.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtX.Location = new System.Drawing.Point(20, 57);
            this.txtX.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(41, 14);
            this.txtX.TabIndex = 4;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblE.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblE.Location = new System.Drawing.Point(3, 76);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(75, 19);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "SUM X:";
            this.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblD.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblD.Location = new System.Drawing.Point(84, 38);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(75, 19);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "COMP Y:";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTools
            // 
            this.tlpTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(181)))), ((int)(((byte)(132)))));
            this.tlpTools.ColumnCount = 1;
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTools.Controls.Add(this.btnSave, 0, 0);
            this.tlpTools.Controls.Add(this.btnPlot, 0, 12);
            this.tlpTools.Controls.Add(this.btnCartV, 0, 9);
            this.tlpTools.Controls.Add(this.btnCartRight, 0, 4);
            this.tlpTools.Controls.Add(this.btnCartUp, 0, 8);
            this.tlpTools.Controls.Add(this.btnCartCenter, 0, 6);
            this.tlpTools.Controls.Add(this.btnCartLeft, 0, 2);
            this.tlpTools.Controls.Add(this.btnCartH, 0, 3);
            this.tlpTools.Controls.Add(this.btnCartDown, 0, 10);
            this.tlpTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTools.Location = new System.Drawing.Point(916, 60);
            this.tlpTools.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTools.Name = "tlpTools";
            this.tlpTools.RowCount = 13;
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTools.Size = new System.Drawing.Size(36, 436);
            this.tlpTools.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnPlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlot.BackgroundImage")));
            this.btnPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlot.FlatAppearance.BorderSize = 0;
            this.btnPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlot.ForeColor = System.Drawing.Color.White;
            this.btnPlot.Location = new System.Drawing.Point(0, 400);
            this.btnPlot.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlot.Size = new System.Drawing.Size(36, 36);
            this.btnPlot.TabIndex = 7;
            this.btnPlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlot.UseVisualStyleBackColor = false;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnCartV
            // 
            this.btnCartV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartV.BackgroundImage")));
            this.btnCartV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartV.FlatAppearance.BorderSize = 0;
            this.btnCartV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartV.ForeColor = System.Drawing.Color.White;
            this.btnCartV.Location = new System.Drawing.Point(0, 300);
            this.btnCartV.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartV.Name = "btnCartV";
            this.btnCartV.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCartV.Size = new System.Drawing.Size(36, 36);
            this.btnCartV.TabIndex = 6;
            this.btnCartV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartV.UseVisualStyleBackColor = false;
            this.btnCartV.Click += new System.EventHandler(this.btnCartV_Click);
            // 
            // btnCartRight
            // 
            this.btnCartRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartRight.BackgroundImage")));
            this.btnCartRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartRight.FlatAppearance.BorderSize = 0;
            this.btnCartRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartRight.ForeColor = System.Drawing.Color.White;
            this.btnCartRight.Location = new System.Drawing.Point(0, 136);
            this.btnCartRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartRight.Name = "btnCartRight";
            this.btnCartRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCartRight.Size = new System.Drawing.Size(36, 36);
            this.btnCartRight.TabIndex = 6;
            this.btnCartRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartRight.UseVisualStyleBackColor = false;
            this.btnCartRight.Click += new System.EventHandler(this.btnCartRight_Click);
            // 
            // btnCartUp
            // 
            this.btnCartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartUp.BackgroundImage")));
            this.btnCartUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartUp.FlatAppearance.BorderSize = 0;
            this.btnCartUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartUp.ForeColor = System.Drawing.Color.White;
            this.btnCartUp.Location = new System.Drawing.Point(0, 264);
            this.btnCartUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartUp.Name = "btnCartUp";
            this.btnCartUp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCartUp.Size = new System.Drawing.Size(36, 36);
            this.btnCartUp.TabIndex = 5;
            this.btnCartUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartUp.UseVisualStyleBackColor = false;
            this.btnCartUp.Click += new System.EventHandler(this.btnCartUp_Click);
            // 
            // btnCartCenter
            // 
            this.btnCartCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartCenter.BackgroundImage")));
            this.btnCartCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartCenter.FlatAppearance.BorderSize = 0;
            this.btnCartCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartCenter.ForeColor = System.Drawing.Color.White;
            this.btnCartCenter.Location = new System.Drawing.Point(0, 200);
            this.btnCartCenter.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartCenter.Name = "btnCartCenter";
            this.btnCartCenter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCartCenter.Size = new System.Drawing.Size(36, 36);
            this.btnCartCenter.TabIndex = 1;
            this.btnCartCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartCenter.UseVisualStyleBackColor = false;
            this.btnCartCenter.Click += new System.EventHandler(this.btnCartCenter_Click);
            // 
            // btnCartLeft
            // 
            this.btnCartLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartLeft.BackgroundImage")));
            this.btnCartLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartLeft.FlatAppearance.BorderSize = 0;
            this.btnCartLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartLeft.ForeColor = System.Drawing.Color.White;
            this.btnCartLeft.Location = new System.Drawing.Point(0, 64);
            this.btnCartLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartLeft.Name = "btnCartLeft";
            this.btnCartLeft.Size = new System.Drawing.Size(36, 36);
            this.btnCartLeft.TabIndex = 3;
            this.btnCartLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartLeft.UseVisualStyleBackColor = false;
            this.btnCartLeft.Click += new System.EventHandler(this.btnCartLeft_Click);
            // 
            // btnCartH
            // 
            this.btnCartH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartH.BackgroundImage")));
            this.btnCartH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartH.FlatAppearance.BorderSize = 0;
            this.btnCartH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartH.ForeColor = System.Drawing.Color.White;
            this.btnCartH.Location = new System.Drawing.Point(0, 100);
            this.btnCartH.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartH.Name = "btnCartH";
            this.btnCartH.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCartH.Size = new System.Drawing.Size(36, 36);
            this.btnCartH.TabIndex = 4;
            this.btnCartH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartH.UseVisualStyleBackColor = false;
            this.btnCartH.Click += new System.EventHandler(this.btnCartH_Click);
            // 
            // btnCartDown
            // 
            this.btnCartDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(165)))), ((int)(((byte)(112)))));
            this.btnCartDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartDown.BackgroundImage")));
            this.btnCartDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCartDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCartDown.FlatAppearance.BorderSize = 0;
            this.btnCartDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartDown.ForeColor = System.Drawing.Color.White;
            this.btnCartDown.Location = new System.Drawing.Point(0, 336);
            this.btnCartDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnCartDown.Name = "btnCartDown";
            this.btnCartDown.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCartDown.Size = new System.Drawing.Size(36, 36);
            this.btnCartDown.TabIndex = 2;
            this.btnCartDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartDown.UseVisualStyleBackColor = false;
            this.btnCartDown.Click += new System.EventHandler(this.btnCartDown_Click);
            // 
            // tlpSelected
            // 
            this.tlpSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.tlpSelected.ColumnCount = 1;
            this.tlpSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSelected.Controls.Add(this.pnlSelect, 0, 0);
            this.tlpSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelected.Location = new System.Drawing.Point(0, 60);
            this.tlpSelected.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSelected.Name = "tlpSelected";
            this.tlpSelected.RowCount = 8;
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSelected.Size = new System.Drawing.Size(4, 436);
            this.tlpSelected.TabIndex = 2;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(133)))));
            this.pnlSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlSelect.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(8, 60);
            this.pnlSelect.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(104, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(812, 59);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpNav
            // 
            this.tlpNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.tlpNav.ColumnCount = 1;
            this.tlpNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNav.Controls.Add(this.btnExit, 0, 7);
            this.tlpNav.Controls.Add(this.button4, 0, 3);
            this.tlpNav.Controls.Add(this.btnKinematic, 0, 2);
            this.tlpNav.Controls.Add(this.btnEquilib, 0, 1);
            this.tlpNav.Controls.Add(this.btnResultant, 0, 0);
            this.tlpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNav.Location = new System.Drawing.Point(4, 60);
            this.tlpNav.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNav.Name = "tlpNav";
            this.tlpNav.RowCount = 8;
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNav.Size = new System.Drawing.Size(100, 436);
            this.tlpNav.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 376);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 60);
            this.btnExit.TabIndex = 34;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 180);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 33;
            this.button4.Text = "Reserved";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnKinematic
            // 
            this.btnKinematic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnKinematic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKinematic.FlatAppearance.BorderSize = 0;
            this.btnKinematic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKinematic.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKinematic.ForeColor = System.Drawing.Color.White;
            this.btnKinematic.Location = new System.Drawing.Point(0, 120);
            this.btnKinematic.Margin = new System.Windows.Forms.Padding(0);
            this.btnKinematic.Name = "btnKinematic";
            this.btnKinematic.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnKinematic.Size = new System.Drawing.Size(100, 60);
            this.btnKinematic.TabIndex = 32;
            this.btnKinematic.Text = "KINEMATIC";
            this.btnKinematic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKinematic.UseVisualStyleBackColor = false;
            this.btnKinematic.Click += new System.EventHandler(this.btnKinematic_Click);
            // 
            // btnEquilib
            // 
            this.btnEquilib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnEquilib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquilib.FlatAppearance.BorderSize = 0;
            this.btnEquilib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquilib.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilib.ForeColor = System.Drawing.Color.White;
            this.btnEquilib.Location = new System.Drawing.Point(0, 60);
            this.btnEquilib.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquilib.Name = "btnEquilib";
            this.btnEquilib.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEquilib.Size = new System.Drawing.Size(100, 60);
            this.btnEquilib.TabIndex = 31;
            this.btnEquilib.Text = "EQUILIBRANT";
            this.btnEquilib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquilib.UseVisualStyleBackColor = false;
            this.btnEquilib.Click += new System.EventHandler(this.btnEquilib_Click);
            // 
            // btnResultant
            // 
            this.btnResultant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnResultant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResultant.FlatAppearance.BorderSize = 0;
            this.btnResultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultant.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultant.ForeColor = System.Drawing.Color.White;
            this.btnResultant.Location = new System.Drawing.Point(0, 0);
            this.btnResultant.Margin = new System.Windows.Forms.Padding(0);
            this.btnResultant.Name = "btnResultant";
            this.btnResultant.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnResultant.Size = new System.Drawing.Size(100, 60);
            this.btnResultant.TabIndex = 30;
            this.btnResultant.Text = "RESULTANT";
            this.btnResultant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultant.UseVisualStyleBackColor = false;
            this.btnResultant.Click += new System.EventHandler(this.btnResultant_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 60);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.pbxLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 60);
            this.panel2.TabIndex = 22;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(100, 60);
            this.pbxLogo.TabIndex = 6;
            this.pbxLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(181)))), ((int)(((byte)(132)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(916, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 60);
            this.panel3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 496);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(916, 534);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpUI.ResumeLayout(false);
            this.pnlUICartesian.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlUIEntry.ResumeLayout(false);
            this.pnlKinematic.ResumeLayout(false);
            this.tlpKinematic.ResumeLayout(false);
            this.tlpKinematic.PerformLayout();
            this.pnlEntries.ResumeLayout(false);
            this.tlpEntry.ResumeLayout(false);
            this.tlpEntry.PerformLayout();
            this.tlpTools.ResumeLayout(false);
            this.tlpSelected.ResumeLayout(false);
            this.tlpNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpNav;
        private System.Windows.Forms.Button btnResultant;
        private System.Windows.Forms.Button btnEquilib;
        private System.Windows.Forms.TableLayoutPanel tlpSelected;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnKinematic;
        private System.Windows.Forms.TableLayoutPanel tlpTools;
        private System.Windows.Forms.Button btnCartH;
        private System.Windows.Forms.Button btnCartLeft;
        private System.Windows.Forms.Button btnCartDown;
        private System.Windows.Forms.Button btnCartCenter;
        private System.Windows.Forms.TableLayoutPanel tlpUI;
        private System.Windows.Forms.Panel pnlCartesian;
        private System.Windows.Forms.TableLayoutPanel tlpEntry;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.TextBox txtSumY;
        private System.Windows.Forms.TextBox txtSumX;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlUICartesian;
        private System.Windows.Forms.Panel pnlUIEntry;
        private System.Windows.Forms.Panel pnlEntries;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Button btnCartV;
        private System.Windows.Forms.Button btnCartRight;
        private System.Windows.Forms.Button btnCartUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlKinematic;
        private System.Windows.Forms.TableLayoutPanel tlpKinematic;
        private System.Windows.Forms.Button btnSolveEQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcceleration;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSeconds2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox lblResKin0;
        private System.Windows.Forms.RichTextBox lblResKin;
        private System.Windows.Forms.RichTextBox lblResKin2;
    }
}

