namespace WindowsFormsApp2
{
    partial class system
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
            this.Trains = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dtime = new System.Windows.Forms.TextBox();
            this.Totalfare = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.SeatID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TicketID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Trains
            // 
            this.Trains.FormattingEnabled = true;
            this.Trains.Location = new System.Drawing.Point(110, 170);
            this.Trains.Name = "Trains";
            this.Trains.Size = new System.Drawing.Size(144, 24);
            this.Trains.TabIndex = 0;
            this.Trains.SelectedIndexChanged += new System.EventHandler(this.Trains_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trains";
            // 
            // Source
            // 
            this.Source.Location = new System.Drawing.Point(110, 34);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(100, 24);
            this.Source.TabIndex = 2;
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(110, 77);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(100, 24);
            this.Destination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dtime
            // 
            this.Dtime.Location = new System.Drawing.Point(110, 217);
            this.Dtime.Name = "Dtime";
            this.Dtime.Size = new System.Drawing.Size(100, 24);
            this.Dtime.TabIndex = 7;
            // 
            // Totalfare
            // 
            this.Totalfare.Location = new System.Drawing.Point(593, 109);
            this.Totalfare.Name = "Totalfare";
            this.Totalfare.Size = new System.Drawing.Size(100, 24);
            this.Totalfare.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(110, 290);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 24);
            this.Date.TabIndex = 9;
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "Economic",
            "VIP"});
            this.Class.Location = new System.Drawing.Point(591, 38);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 24);
            this.Class.TabIndex = 10;
            this.Class.SelectedIndexChanged += new System.EventHandler(this.Class_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departure \r\nTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Fee";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(618, 294);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 15;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // SeatID
            // 
            this.SeatID.Location = new System.Drawing.Point(593, 170);
            this.SeatID.Name = "SeatID";
            this.SeatID.Size = new System.Drawing.Size(100, 24);
            this.SeatID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Seat ID";
            // 
            // TicketID
            // 
            this.TicketID.Location = new System.Drawing.Point(593, 241);
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(100, 24);
            this.TicketID.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ticket ID";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(110, 354);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 24);
            this.Count.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 34);
            this.label10.TabIndex = 21;
            this.label10.Text = "Available\r\nSeats";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SeatID);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Totalfare);
            this.Controls.Add(this.Dtime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trains);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Trains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Dtime;
        private System.Windows.Forms.TextBox Totalfare;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox SeatID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TicketID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label10;
    }
}