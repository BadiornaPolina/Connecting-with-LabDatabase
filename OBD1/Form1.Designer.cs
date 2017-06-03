using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OBD1

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
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.textSel1 = new System.Windows.Forms.TextBox();
            this.textSel2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(599, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 38);
            label2.TabIndex = 5;
            label2.Text = "For Select";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(594, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(13, 51);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1356, 39);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // textSel1
            // 
            this.textSel1.Location = new System.Drawing.Point(12, 136);
            this.textSel1.Multiline = true;
            this.textSel1.Name = "textSel1";
            this.textSel1.Size = new System.Drawing.Size(1355, 43);
            this.textSel1.TabIndex = 2;
            this.textSel1.TextChanged += new System.EventHandler(this.textSel1_TextChanged);
            // 
            // textSel2
            // 
            this.textSel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSel2.Location = new System.Drawing.Point(14, 185);
            this.textSel2.Multiline = true;
            this.textSel2.Name = "textSel2";
            this.textSel2.Size = new System.Drawing.Size(1355, 472);
            this.textSel2.TabIndex = 3;
            this.textSel2.TextChanged += new System.EventHandler(this.textSel2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "For Insert,Delete,Update";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 703);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSel2);
            this.Controls.Add(this.textSel1);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Connecting with LabDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtQuery;
        private TextBox textSel1;
        private TextBox textSel2;
        private Label label1;
    }
}

