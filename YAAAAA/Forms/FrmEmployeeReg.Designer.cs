﻿namespace YAAAAA.Forms
{
    partial class FrmEmployeeReg
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbArea = new System.Windows.Forms.ComboBox();
            this.TbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpHiringDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.TbLastNames = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbPhoneNumber = new System.Windows.Forms.TextBox();
            this.TbIdNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbNames = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeeRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(579, 410);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(106, 30);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(126, 414);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(106, 30);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbArea);
            this.groupBox2.Controls.Add(this.TbID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DtpHiringDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información laboral";
            // 
            // CbArea
            // 
            this.CbArea.FormattingEnabled = true;
            this.CbArea.Location = new System.Drawing.Point(318, 32);
            this.CbArea.Name = "CbArea";
            this.CbArea.Size = new System.Drawing.Size(118, 21);
            this.CbArea.TabIndex = 4;
            // 
            // TbID
            // 
            this.TbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbID.Location = new System.Drawing.Point(90, 27);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(83, 22);
            this.TbID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Área:";
            // 
            // DtpHiringDate
            // 
            this.DtpHiringDate.Location = new System.Drawing.Point(236, 70);
            this.DtpHiringDate.Name = "DtpHiringDate";
            this.DtpHiringDate.Size = new System.Drawing.Size(200, 20);
            this.DtpHiringDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de contratación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbAddress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DtpBirthdate);
            this.groupBox1.Controls.Add(this.TbLastNames);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbEmail);
            this.groupBox1.Controls.Add(this.TbPhoneNumber);
            this.groupBox1.Controls.Add(this.TbIdNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TbNames);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 211);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información personal";
            // 
            // TbAddress
            // 
            this.TbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddress.Location = new System.Drawing.Point(90, 169);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(655, 22);
            this.TbAddress.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dirección:";
            // 
            // DtpBirthdate
            // 
            this.DtpBirthdate.Location = new System.Drawing.Point(545, 81);
            this.DtpBirthdate.Name = "DtpBirthdate";
            this.DtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.DtpBirthdate.TabIndex = 5;
            // 
            // TbLastNames
            // 
            this.TbLastNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLastNames.Location = new System.Drawing.Point(520, 27);
            this.TbLastNames.Name = "TbLastNames";
            this.TbLastNames.Size = new System.Drawing.Size(224, 22);
            this.TbLastNames.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombres:";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(442, 128);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(303, 22);
            this.TbEmail.TabIndex = 4;
            // 
            // TbPhoneNumber
            // 
            this.TbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPhoneNumber.Location = new System.Drawing.Point(141, 128);
            this.TbPhoneNumber.Name = "TbPhoneNumber";
            this.TbPhoneNumber.Size = new System.Drawing.Size(173, 22);
            this.TbPhoneNumber.TabIndex = 4;
            // 
            // TbIdNumber
            // 
            this.TbIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdNumber.Location = new System.Drawing.Point(126, 78);
            this.TbIdNumber.Name = "TbIdNumber";
            this.TbIdNumber.Size = new System.Drawing.Size(224, 22);
            this.TbIdNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Correo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nº de Teléfono:";
            // 
            // TbNames
            // 
            this.TbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNames.Location = new System.Drawing.Point(99, 29);
            this.TbNames.Name = "TbNames";
            this.TbNames.Size = new System.Drawing.Size(224, 22);
            this.TbNames.TabIndex = 4;
            this.TbNames.TextChanged += new System.EventHandler(this.TbNames_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nº de Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRegister,
            this.MnuSeeRegister});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuRegister
            // 
            this.MnuRegister.Name = "MnuRegister";
            this.MnuRegister.Size = new System.Drawing.Size(126, 20);
            this.MnuRegister.Text = "Registrar empleados";
            // 
            // MnuSeeRegister
            // 
            this.MnuSeeRegister.Name = "MnuSeeRegister";
            this.MnuSeeRegister.Size = new System.Drawing.Size(78, 20);
            this.MnuSeeRegister.Text = "Ver registro";
            this.MnuSeeRegister.Click += new System.EventHandler(this.MnuSeeRegister_Click);
            // 
            // FrmEmployeeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmEmployeeReg";
            this.Text = "FrmEmployeeReg";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox CbArea;
        public System.Windows.Forms.TextBox TbID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker DtpHiringDate;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TbAddress;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.DateTimePicker DtpBirthdate;
        public System.Windows.Forms.TextBox TbLastNames;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TbEmail;
        public System.Windows.Forms.TextBox TbPhoneNumber;
        public System.Windows.Forms.TextBox TbIdNumber;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TbNames;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem MnuRegister;
        public System.Windows.Forms.ToolStripMenuItem MnuSeeRegister;
    }
}