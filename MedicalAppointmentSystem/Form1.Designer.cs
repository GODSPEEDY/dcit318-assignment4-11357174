using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MedicalAppointmentSystem.Models;

namespace MedicalAppointmentSystem
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
        /// Method required for Windows Forms designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestDb
            // 
            this.btnTestDb.Location = new System.Drawing.Point(317, 155);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(75, 23);
            this.btnTestDb.TabIndex = 0;
            this.btnTestDb.Text = "Test DB";
            this.btnTestDb.UseVisualStyleBackColor = true;
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestDb);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTestDb;
    }
}
