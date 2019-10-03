namespace ChatClient
{
    partial class FormClient1
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
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelHostClient1 = new System.Windows.Forms.Label();
            this.labelPortClient1 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChatName = new System.Windows.Forms.TextBox();
            this.richTextBoxWrite = new System.Windows.Forms.RichTextBox();
            this.richTextBoxList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWrite.Location = new System.Drawing.Point(78, 748);
            this.textBoxWrite.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWrite.Multiline = true;
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(724, 83);
            this.textBoxWrite.TabIndex = 1;
            this.textBoxWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWrite_KeyDown);
           
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSend.Location = new System.Drawing.Point(818, 748);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(270, 83);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonConnect.Location = new System.Drawing.Point(788, 23);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(300, 56);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect to Server";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHost.Location = new System.Drawing.Point(168, 98);
            this.textBoxHost.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(196, 37);
            this.textBoxHost.TabIndex = 4;
            this.textBoxHost.Text = "localhost";
            this.textBoxHost.TextChanged += new System.EventHandler(this.textBoxHost_TextChanged);
            // 
            // labelHostClient1
            // 
            this.labelHostClient1.AutoSize = true;
            this.labelHostClient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostClient1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHostClient1.Location = new System.Drawing.Point(72, 100);
            this.labelHostClient1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHostClient1.Name = "labelHostClient1";
            this.labelHostClient1.Size = new System.Drawing.Size(92, 31);
            this.labelHostClient1.TabIndex = 5;
            this.labelHostClient1.Text = "Host :";
            // 
            // labelPortClient1
            // 
            this.labelPortClient1.AutoSize = true;
            this.labelPortClient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortClient1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPortClient1.Location = new System.Drawing.Point(408, 100);
            this.labelPortClient1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPortClient1.Name = "labelPortClient1";
            this.labelPortClient1.Size = new System.Drawing.Size(85, 31);
            this.labelPortClient1.TabIndex = 6;
            this.labelPortClient1.Text = "Port :";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(492, 98);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(148, 37);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.Text = "2018";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonClose.Location = new System.Drawing.Point(788, 100);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(300, 56);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "End Chat";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chat Name :";
            // 
            // textBoxChatName
            // 
            this.textBoxChatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChatName.Location = new System.Drawing.Point(246, 33);
            this.textBoxChatName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxChatName.Name = "textBoxChatName";
            this.textBoxChatName.Size = new System.Drawing.Size(276, 37);
            this.textBoxChatName.TabIndex = 11;
            this.textBoxChatName.Text = "Client";
            // 
            // richTextBoxWrite
            // 
            this.richTextBoxWrite.Location = new System.Drawing.Point(78, 263);
            this.richTextBoxWrite.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxWrite.Name = "richTextBoxWrite";
            this.richTextBoxWrite.Size = new System.Drawing.Size(724, 435);
            this.richTextBoxWrite.TabIndex = 12;
            this.richTextBoxWrite.Text = "";
            this.richTextBoxWrite.TextChanged += new System.EventHandler(this.richTextBoxWrite_TextChanged);
            // 
            // richTextBoxList
            // 
            this.richTextBoxList.Location = new System.Drawing.Point(820, 263);
            this.richTextBoxList.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxList.Name = "richTextBoxList";
            this.richTextBoxList.Size = new System.Drawing.Size(264, 435);
            this.richTextBoxList.TabIndex = 13;
            this.richTextBoxList.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(625, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chat Context";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(953, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "User List";
            // 
            // FormClient1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1188, 931);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxList);
            this.Controls.Add(this.richTextBoxWrite);
            this.Controls.Add(this.textBoxChatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPortClient1);
            this.Controls.Add(this.labelHostClient1);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormClient1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Client 1";
            this.Load += new System.EventHandler(this.FormClient1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelHostClient1;
        private System.Windows.Forms.Label labelPortClient1;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChatName;
        private System.Windows.Forms.RichTextBox richTextBoxWrite;
        private System.Windows.Forms.RichTextBox richTextBoxList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

