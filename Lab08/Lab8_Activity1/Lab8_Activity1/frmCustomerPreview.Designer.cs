﻿namespace Lab8_Activity1
{
    partial class frmCustomerPreview
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelName = new Label();
            labelCountry = new Label();
            labelGender = new Label();
            labelHobbies = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 44);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Country : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 148);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Gender : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 238);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Status : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 191);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 3;
            label5.Text = "Hobbies : ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(308, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 20);
            labelName.TabIndex = 5;
            labelName.Text = "labelName";
            labelName.Click += label6_Click;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(308, 92);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(93, 20);
            labelCountry.TabIndex = 6;
            labelCountry.Text = "labelCountry";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(308, 148);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(90, 20);
            labelGender.TabIndex = 7;
            labelGender.Text = "labelGender";
            labelGender.Click += label8_Click;
            // 
            // labelHobbies
            // 
            labelHobbies.AutoSize = true;
            labelHobbies.Location = new Point(308, 191);
            labelHobbies.Name = "labelHobbies";
            labelHobbies.Size = new Size(98, 20);
            labelHobbies.TabIndex = 8;
            labelHobbies.Text = "labelHobbies";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(308, 238);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(82, 20);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "labelStatus";
            // 
            // frmCustomerPreview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(labelStatus);
            Controls.Add(labelHobbies);
            Controls.Add(labelGender);
            Controls.Add(labelCountry);
            Controls.Add(labelName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCustomerPreview";
            Text = "frmCustomerPreview";
            Load += frmCustomerPreview_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelName;
        private Label labelCountry;
        private Label labelGender;
        private Label labelHobbies;
        private Label labelStatus;
    }
}