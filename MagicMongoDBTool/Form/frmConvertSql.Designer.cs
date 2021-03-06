﻿namespace MagicMongoDBTool
{
    partial class frmConvertSql
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
            this.txtSql = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblAttentionSelectOnly = new System.Windows.Forms.Label();
            this.Icon = Module.GetSystemIcon.ConvertImgToIcon(MagicMongoDBTool.Properties.Resources.Sql);
            this.SuspendLayout();
            // 
            // txtSql
            // 
            this.txtSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSql.Location = new System.Drawing.Point(23, 22);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(497, 193);
            this.txtSql.TabIndex = 5;
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Transparent;
            this.cmdOK.Location = new System.Drawing.Point(314, 257);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(117, 37);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "Cancel";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Transparent;
            this.cmdSave.Location = new System.Drawing.Point(119, 257);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(117, 37);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblAttentionSelectOnly
            // 
            this.lblAttentionSelectOnly.AutoSize = true;
            this.lblAttentionSelectOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttentionSelectOnly.ForeColor = System.Drawing.Color.Red;
            this.lblAttentionSelectOnly.Location = new System.Drawing.Point(20, 230);
            this.lblAttentionSelectOnly.Name = "lblAttentionSelectOnly";
            this.lblAttentionSelectOnly.Size = new System.Drawing.Size(230, 13);
            this.lblAttentionSelectOnly.TabIndex = 44;
            this.lblAttentionSelectOnly.Text = "Now,Select Sentence is only supported";
            // 
            // frmConvertSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 307);
            this.Controls.Add(this.lblAttentionSelectOnly);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtSql);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConvertSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRunSql";
            this.Load += new System.EventHandler(this.frmRunSql_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblAttentionSelectOnly;
    }
}