namespace TableSeatingDesktop
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numTables = new System.Windows.Forms.NumericUpDown();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.lblNumSeats = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.listAttendees = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMeals = new System.Windows.Forms.NumericUpDown();
            this.btnImportAttendees = new System.Windows.Forms.Button();
            this.btnAddAttendee = new System.Windows.Forms.Button();
            this.btnRemoveAttendee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // numTables
            // 
            this.numTables.Location = new System.Drawing.Point(154, 26);
            this.numTables.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTables.Name = "numTables";
            this.numTables.Size = new System.Drawing.Size(120, 23);
            this.numTables.TabIndex = 0;
            this.numTables.ValueChanged += new System.EventHandler(this.numTables_ValueChanged);
            // 
            // lblTableNum
            // 
            this.lblTableNum.AutoSize = true;
            this.lblTableNum.Location = new System.Drawing.Point(17, 28);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(86, 15);
            this.lblTableNum.TabIndex = 1;
            this.lblTableNum.Text = "Num of Tables:";
            // 
            // lblNumSeats
            // 
            this.lblNumSeats.AutoSize = true;
            this.lblNumSeats.Location = new System.Drawing.Point(17, 57);
            this.lblNumSeats.Name = "lblNumSeats";
            this.lblNumSeats.Size = new System.Drawing.Size(131, 15);
            this.lblNumSeats.TabIndex = 3;
            this.lblNumSeats.Text = "Num of Seats per Table:";
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(154, 55);
            this.numSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(120, 23);
            this.numSeats.TabIndex = 2;
            this.numSeats.ValueChanged += new System.EventHandler(this.numSeats_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Seats per Meal:";
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Location = new System.Drawing.Point(154, 116);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(0, 15);
            this.lblTotalSeats.TabIndex = 5;
            // 
            // listAttendees
            // 
            this.listAttendees.FormattingEnabled = true;
            this.listAttendees.ItemHeight = 15;
            this.listAttendees.Location = new System.Drawing.Point(17, 183);
            this.listAttendees.Name = "listAttendees";
            this.listAttendees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAttendees.Size = new System.Drawing.Size(265, 289);
            this.listAttendees.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attendees to be Seated:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Num of Meals:";
            // 
            // numMeals
            // 
            this.numMeals.Location = new System.Drawing.Point(154, 84);
            this.numMeals.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMeals.Name = "numMeals";
            this.numMeals.Size = new System.Drawing.Size(120, 23);
            this.numMeals.TabIndex = 8;
            // 
            // btnImportAttendees
            // 
            this.btnImportAttendees.Location = new System.Drawing.Point(218, 154);
            this.btnImportAttendees.Name = "btnImportAttendees";
            this.btnImportAttendees.Size = new System.Drawing.Size(64, 23);
            this.btnImportAttendees.TabIndex = 10;
            this.btnImportAttendees.Text = "Import";
            this.btnImportAttendees.UseVisualStyleBackColor = true;
            // 
            // btnAddAttendee
            // 
            this.btnAddAttendee.BackgroundImage = global::TableSeatingDesktop.Properties.Resources.plus;
            this.btnAddAttendee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAttendee.Location = new System.Drawing.Point(156, 154);
            this.btnAddAttendee.Name = "btnAddAttendee";
            this.btnAddAttendee.Size = new System.Drawing.Size(25, 23);
            this.btnAddAttendee.TabIndex = 11;
            this.btnAddAttendee.UseVisualStyleBackColor = true;
            this.btnAddAttendee.Click += new System.EventHandler(this.btnAddAttendee_Click);
            // 
            // btnRemoveAttendee
            // 
            this.btnRemoveAttendee.BackgroundImage = global::TableSeatingDesktop.Properties.Resources.error;
            this.btnRemoveAttendee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveAttendee.Location = new System.Drawing.Point(187, 154);
            this.btnRemoveAttendee.Name = "btnRemoveAttendee";
            this.btnRemoveAttendee.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveAttendee.TabIndex = 12;
            this.btnRemoveAttendee.UseVisualStyleBackColor = true;
            this.btnRemoveAttendee.Click += new System.EventHandler(this.btnRemoveAttendee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 493);
            this.Controls.Add(this.btnRemoveAttendee);
            this.Controls.Add(this.btnAddAttendee);
            this.Controls.Add(this.btnImportAttendees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMeals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAttendees);
            this.Controls.Add(this.lblTotalSeats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumSeats);
            this.Controls.Add(this.numSeats);
            this.Controls.Add(this.lblTableNum);
            this.Controls.Add(this.numTables);
            this.Name = "frmMain";
            this.Text = "Table Seating Arrangement";
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numTables;
        private Label lblTableNum;
        private Label lblNumSeats;
        private NumericUpDown numSeats;
        private Label label1;
        private Label lblTotalSeats;
        private ListBox listAttendees;
        private Label label2;
        private Label label3;
        private NumericUpDown numMeals;
        private Button btnImportAttendees;
        private Button btnAddAttendee;
        private Button btnRemoveAttendee;
    }
}