using System;

namespace MedicalAppointmentSystem
{
    partial class AppointmentForm
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

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(101, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(349, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Book a New Appointment";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(100, 72);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(50, 16);
            this.lblDoctor.TabIndex = 1;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(100, 112);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(51, 16);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Patient:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(100, 152);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Select Date:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(100, 192);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 16);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notes:";
            // 
            // cbDoctor
            // 
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(200, 70);
            this.cbDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(250, 24);
            this.cbDoctor.TabIndex = 2;
            // 
            // cbPatient
            // 
            this.cbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(200, 110);
            this.cbPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(250, 24);
            this.cbPatient.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(200, 150);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(200, 190);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(250, 65);
            this.txtNotes.TabIndex = 8;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(200, 272);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(250, 32);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 336);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cbPatient);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Booking";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNotes;

        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnBook;
    }
}
