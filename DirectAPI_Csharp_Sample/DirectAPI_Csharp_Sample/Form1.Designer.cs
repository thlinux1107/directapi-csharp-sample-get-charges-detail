namespace DirectAPI_Csharp_Sample
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
            this.btProcess = new System.Windows.Forms.Button();
            this.txtJSONResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRespExpDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespPayTypeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btProcess
            // 
            this.btProcess.Location = new System.Drawing.Point(11, 236);
            this.btProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(125, 28);
            this.btProcess.TabIndex = 1;
            this.btProcess.Text = "Retrieve Reference";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // txtJSONResponse
            // 
            this.txtJSONResponse.Location = new System.Drawing.Point(195, 23);
            this.txtJSONResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJSONResponse.Multiline = true;
            this.txtJSONResponse.Name = "txtJSONResponse";
            this.txtJSONResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJSONResponse.Size = new System.Drawing.Size(352, 245);
            this.txtJSONResponse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Response";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(11, 23);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(162, 20);
            this.txtReference.TabIndex = 6;
            this.txtReference.Text = "DC6GFbyDO0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Reference Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Card Number";
            // 
            // txtRespCard
            // 
            this.txtRespCard.Location = new System.Drawing.Point(561, 23);
            this.txtRespCard.Name = "txtRespCard";
            this.txtRespCard.Size = new System.Drawing.Size(162, 20);
            this.txtRespCard.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expiration Date";
            // 
            // txtRespExpDate
            // 
            this.txtRespExpDate.Location = new System.Drawing.Point(561, 66);
            this.txtRespExpDate.Name = "txtRespExpDate";
            this.txtRespExpDate.Size = new System.Drawing.Size(162, 20);
            this.txtRespExpDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Payment Type ID";
            // 
            // txtRespPayTypeID
            // 
            this.txtRespPayTypeID.Location = new System.Drawing.Point(561, 111);
            this.txtRespPayTypeID.Name = "txtRespPayTypeID";
            this.txtRespPayTypeID.Size = new System.Drawing.Size(162, 20);
            this.txtRespPayTypeID.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRespPayTypeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRespExpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRespCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJSONResponse);
            this.Controls.Add(this.btProcess);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Direct API C# Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.TextBox txtJSONResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRespExpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRespPayTypeID;
    }
}

