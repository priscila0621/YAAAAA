﻿namespace YAAAAA.Forms
{
    partial class FrmPayrollRegister
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
            this.DgvPayrollRegister = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuPayroll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPayrollRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPayrollRegister)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPayrollRegister
            // 
            this.DgvPayrollRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPayrollRegister.Location = new System.Drawing.Point(26, 58);
            this.DgvPayrollRegister.Name = "DgvPayrollRegister";
            this.DgvPayrollRegister.Size = new System.Drawing.Size(730, 354);
            this.DgvPayrollRegister.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPayroll,
            this.MnuPayrollRegister});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuPayroll
            // 
            this.MnuPayroll.Name = "MnuPayroll";
            this.MnuPayroll.Size = new System.Drawing.Size(121, 20);
            this.MnuPayroll.Text = "Gestión de Nómina";
            this.MnuPayroll.Click += new System.EventHandler(this.MnuPayroll_Click);
            // 
            // MnuPayrollRegister
            // 
            this.MnuPayrollRegister.Name = "MnuPayrollRegister";
            this.MnuPayrollRegister.Size = new System.Drawing.Size(129, 20);
            this.MnuPayrollRegister.Text = "Registros de Nómina";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(571, 0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(681, 0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmPayrollRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.DgvPayrollRegister);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPayrollRegister";
            this.Text = "FrmPayrollRegister";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPayrollRegister)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPayrollRegister;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuPayroll;
        private System.Windows.Forms.ToolStripMenuItem MnuPayrollRegister;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
    }
}