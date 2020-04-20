﻿namespace BankingProject
{
    partial class TransferForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransferFrom = new System.Windows.Forms.TextBox();
            this.txtTransferDestination = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTransfer = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Днешна дата";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(179, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Превод от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Име";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Моментна сума";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дестинация на превода";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Сума на превода";
            // 
            // txtTransferFrom
            // 
            this.txtTransferFrom.Location = new System.Drawing.Point(165, 77);
            this.txtTransferFrom.Name = "txtTransferFrom";
            this.txtTransferFrom.Size = new System.Drawing.Size(100, 20);
            this.txtTransferFrom.TabIndex = 7;
            // 
            // txtTransferDestination
            // 
            this.txtTransferDestination.Location = new System.Drawing.Point(165, 165);
            this.txtTransferDestination.Name = "txtTransferDestination";
            this.txtTransferDestination.Size = new System.Drawing.Size(100, 20);
            this.txtTransferDestination.TabIndex = 8;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.Location = new System.Drawing.Point(165, 139);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentAmount.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtTransfer
            // 
            this.txtTransfer.Location = new System.Drawing.Point(165, 193);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(100, 20);
            this.txtTransfer.TabIndex = 11;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(33, 249);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(111, 37);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Text = "Преведи сумата";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(298, 68);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(89, 37);
            this.btnDetails.TabIndex = 13;
            this.btnDetails.Text = "Детайли";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransfer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCurrentAmount);
            this.Controls.Add(this.txtTransferDestination);
            this.Controls.Add(this.txtTransferFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransferFrom;
        private System.Windows.Forms.TextBox txtTransferDestination;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTransfer;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDetails;
    }
}