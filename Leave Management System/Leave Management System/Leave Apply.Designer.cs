namespace Leave_Management_System
{
    partial class Leave_Apply
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
            this.LeaveRequestForm = new System.Windows.Forms.Label();
            this.casualBalance = new System.Windows.Forms.TextBox();
            this.NICNo = new System.Windows.Forms.Button();
            this.annualBalance = new System.Windows.Forms.TextBox();
            this.LeaveBA = new System.Windows.Forms.Button();
            this.Annual = new System.Windows.Forms.TextBox();
            this.CoveringPerson = new System.Windows.Forms.Button();
            this.FDate = new System.Windows.Forms.TextBox();
            this.FromDate = new System.Windows.Forms.Button();
            this.Casual = new System.Windows.Forms.TextBox();
            this.ToDate = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.CoverP = new System.Windows.Forms.TextBox();
            this.LeaveRD = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.LeaveID = new System.Windows.Forms.Button();
            this.TDate = new System.Windows.Forms.TextBox();
            this.ReasonLeave = new System.Windows.Forms.Button();
            this.shortBalance = new System.Windows.Forms.TextBox();
            this.LeaveBC = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Reason = new System.Windows.Forms.RichTextBox();
            this.NoCasaulL = new System.Windows.Forms.Button();
            this.NoShortL = new System.Windows.Forms.Button();
            this.NoAnnualL = new System.Windows.Forms.Button();
            this.Short = new System.Windows.Forms.TextBox();
            this.EmployeeReg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Can = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ReqDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeReg)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaveRequestForm
            // 
            this.LeaveRequestForm.AutoSize = true;
            this.LeaveRequestForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveRequestForm.Location = new System.Drawing.Point(243, 9);
            this.LeaveRequestForm.Name = "LeaveRequestForm";
            this.LeaveRequestForm.Size = new System.Drawing.Size(308, 36);
            this.LeaveRequestForm.TabIndex = 23;
            this.LeaveRequestForm.Text = "Leave Request Form";
            // 
            // casualBalance
            // 
            this.casualBalance.Location = new System.Drawing.Point(454, 74);
            this.casualBalance.Name = "casualBalance";
            this.casualBalance.Size = new System.Drawing.Size(49, 22);
            this.casualBalance.TabIndex = 72;
            this.casualBalance.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // NICNo
            // 
            this.NICNo.Location = new System.Drawing.Point(509, 74);
            this.NICNo.Name = "NICNo";
            this.NICNo.Size = new System.Drawing.Size(170, 23);
            this.NICNo.TabIndex = 71;
            this.NICNo.Text = "Leave Balance Short";
            this.NICNo.UseVisualStyleBackColor = true;
            this.NICNo.Click += new System.EventHandler(this.NICNo_Click);
            // 
            // annualBalance
            // 
            this.annualBalance.HideSelection = false;
            this.annualBalance.Location = new System.Drawing.Point(223, 74);
            this.annualBalance.Name = "annualBalance";
            this.annualBalance.Size = new System.Drawing.Size(49, 22);
            this.annualBalance.TabIndex = 70;
            this.annualBalance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LeaveBA
            // 
            this.LeaveBA.Location = new System.Drawing.Point(47, 73);
            this.LeaveBA.Name = "LeaveBA";
            this.LeaveBA.Size = new System.Drawing.Size(170, 23);
            this.LeaveBA.TabIndex = 69;
            this.LeaveBA.Text = "Leave Balance Annual";
            this.LeaveBA.UseVisualStyleBackColor = true;
            this.LeaveBA.Click += new System.EventHandler(this.LeaveBA_Click);
            // 
            // Annual
            // 
            this.Annual.Location = new System.Drawing.Point(584, 168);
            this.Annual.Name = "Annual";
            this.Annual.Size = new System.Drawing.Size(100, 22);
            this.Annual.TabIndex = 76;
            // 
            // CoveringPerson
            // 
            this.CoveringPerson.Location = new System.Drawing.Point(12, 252);
            this.CoveringPerson.Name = "CoveringPerson";
            this.CoveringPerson.Size = new System.Drawing.Size(115, 23);
            this.CoveringPerson.TabIndex = 75;
            this.CoveringPerson.Text = "Covering Person";
            this.CoveringPerson.UseVisualStyleBackColor = true;
            // 
            // FDate
            // 
            this.FDate.Location = new System.Drawing.Point(188, 195);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(100, 22);
            this.FDate.TabIndex = 74;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(12, 194);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(115, 23);
            this.FromDate.TabIndex = 73;
            this.FromDate.Text = "From Date";
            this.FromDate.UseVisualStyleBackColor = true;
            // 
            // Casual
            // 
            this.Casual.Location = new System.Drawing.Point(584, 205);
            this.Casual.Name = "Casual";
            this.Casual.Size = new System.Drawing.Size(100, 22);
            this.Casual.TabIndex = 80;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(12, 223);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(115, 23);
            this.ToDate.TabIndex = 79;
            this.ToDate.Text = "To Date";
            this.ToDate.UseVisualStyleBackColor = true;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(451, 118);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(100, 22);
            this.EmployeeID.TabIndex = 78;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 77;
            this.button4.Text = "Employee ID";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CoverP
            // 
            this.CoverP.Location = new System.Drawing.Point(188, 253);
            this.CoverP.Name = "CoverP";
            this.CoverP.Size = new System.Drawing.Size(100, 22);
            this.CoverP.TabIndex = 84;
            // 
            // LeaveRD
            // 
            this.LeaveRD.Location = new System.Drawing.Point(12, 151);
            this.LeaveRD.Name = "LeaveRD";
            this.LeaveRD.Size = new System.Drawing.Size(152, 23);
            this.LeaveRD.TabIndex = 83;
            this.LeaveRD.Text = "Leave Request Date";
            this.LeaveRD.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(188, 118);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 82;
            // 
            // LeaveID
            // 
            this.LeaveID.Location = new System.Drawing.Point(12, 117);
            this.LeaveID.Name = "LeaveID";
            this.LeaveID.Size = new System.Drawing.Size(115, 23);
            this.LeaveID.TabIndex = 81;
            this.LeaveID.Text = "Leave ID";
            this.LeaveID.UseVisualStyleBackColor = true;
            // 
            // TDate
            // 
            this.TDate.Location = new System.Drawing.Point(188, 224);
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(100, 22);
            this.TDate.TabIndex = 88;
            // 
            // ReasonLeave
            // 
            this.ReasonLeave.Location = new System.Drawing.Point(12, 296);
            this.ReasonLeave.Name = "ReasonLeave";
            this.ReasonLeave.Size = new System.Drawing.Size(115, 23);
            this.ReasonLeave.TabIndex = 87;
            this.ReasonLeave.Text = "Reason";
            this.ReasonLeave.UseVisualStyleBackColor = true;
            // 
            // shortBalance
            // 
            this.shortBalance.Location = new System.Drawing.Point(685, 73);
            this.shortBalance.Name = "shortBalance";
            this.shortBalance.Size = new System.Drawing.Size(49, 22);
            this.shortBalance.TabIndex = 86;
            this.shortBalance.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // LeaveBC
            // 
            this.LeaveBC.Location = new System.Drawing.Point(278, 73);
            this.LeaveBC.Name = "LeaveBC";
            this.LeaveBC.Size = new System.Drawing.Size(170, 23);
            this.LeaveBC.TabIndex = 85;
            this.LeaveBC.Text = "Leave Balance Casual";
            this.LeaveBC.UseVisualStyleBackColor = true;
            this.LeaveBC.Click += new System.EventHandler(this.LeaveBC_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(584, 106);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(115, 46);
            this.Search.TabIndex = 89;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Reason
            // 
            this.Reason.Location = new System.Drawing.Point(155, 281);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(579, 64);
            this.Reason.TabIndex = 94;
            this.Reason.Text = "";
            this.Reason.TextChanged += new System.EventHandler(this.Reason_TextChanged);
            // 
            // NoCasaulL
            // 
            this.NoCasaulL.Location = new System.Drawing.Point(451, 204);
            this.NoCasaulL.Name = "NoCasaulL";
            this.NoCasaulL.Size = new System.Drawing.Size(115, 23);
            this.NoCasaulL.TabIndex = 97;
            this.NoCasaulL.Text = "No of Casual Leave";
            this.NoCasaulL.UseVisualStyleBackColor = true;
            // 
            // NoShortL
            // 
            this.NoShortL.Location = new System.Drawing.Point(451, 242);
            this.NoShortL.Name = "NoShortL";
            this.NoShortL.Size = new System.Drawing.Size(115, 23);
            this.NoShortL.TabIndex = 96;
            this.NoShortL.Text = "No of Short Leave";
            this.NoShortL.UseVisualStyleBackColor = true;
            // 
            // NoAnnualL
            // 
            this.NoAnnualL.Location = new System.Drawing.Point(451, 167);
            this.NoAnnualL.Name = "NoAnnualL";
            this.NoAnnualL.Size = new System.Drawing.Size(115, 23);
            this.NoAnnualL.TabIndex = 95;
            this.NoAnnualL.Text = "No of Annaul Leave";
            this.NoAnnualL.UseVisualStyleBackColor = true;
            // 
            // Short
            // 
            this.Short.Location = new System.Drawing.Point(584, 242);
            this.Short.Name = "Short";
            this.Short.Size = new System.Drawing.Size(100, 22);
            this.Short.TabIndex = 98;
            // 
            // EmployeeReg
            // 
            this.EmployeeReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeReg.Location = new System.Drawing.Point(28, 430);
            this.EmployeeReg.Name = "EmployeeReg";
            this.EmployeeReg.RowHeadersWidth = 51;
            this.EmployeeReg.RowTemplate.Height = 24;
            this.EmployeeReg.Size = new System.Drawing.Size(739, 150);
            this.EmployeeReg.TabIndex = 99;
            this.EmployeeReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeReg_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 71;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(382, 268);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(115, 46);
            this.Cancel.TabIndex = 50;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(660, 268);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 46);
            this.Add.TabIndex = 48;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 46);
            this.button2.TabIndex = 102;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Can
            // 
            this.Can.Location = new System.Drawing.Point(60, 366);
            this.Can.Name = "Can";
            this.Can.Size = new System.Drawing.Size(115, 46);
            this.Can.TabIndex = 101;
            this.Can.Text = "Cancel";
            this.Can.UseVisualStyleBackColor = true;
            this.Can.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(388, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 46);
            this.button5.TabIndex = 100;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReqDate
            // 
            this.ReqDate.Location = new System.Drawing.Point(188, 152);
            this.ReqDate.Name = "ReqDate";
            this.ReqDate.Size = new System.Drawing.Size(200, 22);
            this.ReqDate.TabIndex = 103;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(552, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 46);
            this.button6.TabIndex = 104;
            this.button6.Text = "Submit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Leave_Apply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ReqDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Can);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.EmployeeReg);
            this.Controls.Add(this.Short);
            this.Controls.Add(this.NoCasaulL);
            this.Controls.Add(this.NoShortL);
            this.Controls.Add(this.NoAnnualL);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TDate);
            this.Controls.Add(this.ReasonLeave);
            this.Controls.Add(this.shortBalance);
            this.Controls.Add(this.LeaveBC);
            this.Controls.Add(this.CoverP);
            this.Controls.Add(this.LeaveRD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.LeaveID);
            this.Controls.Add(this.Casual);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Annual);
            this.Controls.Add(this.CoveringPerson);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.casualBalance);
            this.Controls.Add(this.NICNo);
            this.Controls.Add(this.annualBalance);
            this.Controls.Add(this.LeaveBA);
            this.Controls.Add(this.LeaveRequestForm);
            this.Name = "Leave_Apply";
            this.Text = "Leave_Apply";
            this.Load += new System.EventHandler(this.Leave_Apply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeaveRequestForm;
        private System.Windows.Forms.TextBox casualBalance;
        private System.Windows.Forms.Button NICNo;
        private System.Windows.Forms.TextBox annualBalance;
        private System.Windows.Forms.Button LeaveBA;
        private System.Windows.Forms.TextBox Annual;
        private System.Windows.Forms.Button CoveringPerson;
        private System.Windows.Forms.TextBox FDate;
        private System.Windows.Forms.Button FromDate;
        private System.Windows.Forms.TextBox Casual;
        private System.Windows.Forms.Button ToDate;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CoverP;
        private System.Windows.Forms.Button LeaveRD;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button LeaveID;
        private System.Windows.Forms.TextBox TDate;
        private System.Windows.Forms.Button ReasonLeave;
        private System.Windows.Forms.TextBox shortBalance;
        private System.Windows.Forms.Button LeaveBC;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox Reason;
        private System.Windows.Forms.Button NoCasaulL;
        private System.Windows.Forms.Button NoShortL;
        private System.Windows.Forms.Button NoAnnualL;
        private System.Windows.Forms.TextBox Short;
        private System.Windows.Forms.DataGridView EmployeeReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Can;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker ReqDate;
        private System.Windows.Forms.Button button6;
    }
}