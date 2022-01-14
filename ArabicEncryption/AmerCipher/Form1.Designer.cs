namespace AmerCipher
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
            this.components = new System.ComponentModel.Container();
            this.BTNRemove1 = new System.Windows.Forms.Button();
            this.BTNSaveUtf = new System.Windows.Forms.Button();
            this.BTNDecryptFileUtf = new System.Windows.Forms.Button();
            this.BTNDecryptFile = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer4 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.BTNSave = new System.Windows.Forms.Button();
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.BTNAdd4 = new System.Windows.Forms.Button();
            this.BTNAdd3 = new System.Windows.Forms.Button();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BTNDecrypt = new System.Windows.Forms.Button();
            this.BTNEncrypt = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTNAdd2 = new System.Windows.Forms.Button();
            this.BTNAdd1 = new System.Windows.Forms.Button();
            this.BTNOpen = new System.Windows.Forms.Button();
            this.TXTData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEncPerc = new System.Windows.Forms.Label();
            this.lblEncSize = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNRemove1
            // 
            this.BTNRemove1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNRemove1.Location = new System.Drawing.Point(727, 578);
            this.BTNRemove1.Name = "BTNRemove1";
            this.BTNRemove1.Size = new System.Drawing.Size(167, 30);
            this.BTNRemove1.TabIndex = 25;
            this.BTNRemove1.Text = "Remove from Dictionary";
            this.BTNRemove1.UseVisualStyleBackColor = true;
            this.BTNRemove1.Click += new System.EventHandler(this.BTNRemove1_Click);
            // 
            // BTNSaveUtf
            // 
            this.BTNSaveUtf.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNSaveUtf.Location = new System.Drawing.Point(262, 12);
            this.BTNSaveUtf.Name = "BTNSaveUtf";
            this.BTNSaveUtf.Size = new System.Drawing.Size(137, 30);
            this.BTNSaveUtf.TabIndex = 24;
            this.BTNSaveUtf.Text = "Save File (Unicode)";
            this.BTNSaveUtf.UseVisualStyleBackColor = true;
            this.BTNSaveUtf.Click += new System.EventHandler(this.BTNSaveUtf_Click);
            // 
            // BTNDecryptFileUtf
            // 
            this.BTNDecryptFileUtf.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNDecryptFileUtf.Location = new System.Drawing.Point(565, 542);
            this.BTNDecryptFileUtf.Name = "BTNDecryptFileUtf";
            this.BTNDecryptFileUtf.Size = new System.Drawing.Size(142, 30);
            this.BTNDecryptFileUtf.TabIndex = 23;
            this.BTNDecryptFileUtf.Text = "Decrypt to File (UTF8)";
            this.BTNDecryptFileUtf.UseVisualStyleBackColor = true;
            this.BTNDecryptFileUtf.Click += new System.EventHandler(this.BTNDecryptFileUtf_Click);
            // 
            // BTNDecryptFile
            // 
            this.BTNDecryptFile.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNDecryptFile.Location = new System.Drawing.Point(565, 506);
            this.BTNDecryptFile.Name = "BTNDecryptFile";
            this.BTNDecryptFile.Size = new System.Drawing.Size(142, 30);
            this.BTNDecryptFile.TabIndex = 22;
            this.BTNDecryptFile.Text = "Decrypt to File";
            this.BTNDecryptFile.UseVisualStyleBackColor = true;
            this.BTNDecryptFile.Click += new System.EventHandler(this.BTNDecryptFile_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer4
            // 
            this.Timer4.Interval = 1;
            this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // BTNSave
            // 
            this.BTNSave.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNSave.Location = new System.Drawing.Point(129, 12);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(117, 30);
            this.BTNSave.TabIndex = 21;
            this.BTNSave.Text = "Save File";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // Timer3
            // 
            this.Timer3.Interval = 1;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // BTNAdd4
            // 
            this.BTNAdd4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNAdd4.Location = new System.Drawing.Point(727, 542);
            this.BTNAdd4.Name = "BTNAdd4";
            this.BTNAdd4.Size = new System.Drawing.Size(167, 30);
            this.BTNAdd4.TabIndex = 20;
            this.BTNAdd4.Text = "Add to Dictionary 4";
            this.BTNAdd4.UseVisualStyleBackColor = true;
            this.BTNAdd4.Click += new System.EventHandler(this.BTNAdd4_Click);
            // 
            // BTNAdd3
            // 
            this.BTNAdd3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNAdd3.Location = new System.Drawing.Point(727, 506);
            this.BTNAdd3.Name = "BTNAdd3";
            this.BTNAdd3.Size = new System.Drawing.Size(167, 30);
            this.BTNAdd3.TabIndex = 19;
            this.BTNAdd3.Text = "Add to Dictionary 3";
            this.BTNAdd3.UseVisualStyleBackColor = true;
            this.BTNAdd3.Click += new System.EventHandler(this.BTNAdd3_Click);
            // 
            // BTNDecrypt
            // 
            this.BTNDecrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNDecrypt.Location = new System.Drawing.Point(565, 470);
            this.BTNDecrypt.Name = "BTNDecrypt";
            this.BTNDecrypt.Size = new System.Drawing.Size(142, 30);
            this.BTNDecrypt.TabIndex = 15;
            this.BTNDecrypt.Text = "Decrypt";
            this.BTNDecrypt.UseVisualStyleBackColor = true;
            this.BTNDecrypt.Click += new System.EventHandler(this.BTNDecrypt_Click);
            // 
            // BTNEncrypt
            // 
            this.BTNEncrypt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNEncrypt.Location = new System.Drawing.Point(565, 434);
            this.BTNEncrypt.Name = "BTNEncrypt";
            this.BTNEncrypt.Size = new System.Drawing.Size(142, 30);
            this.BTNEncrypt.TabIndex = 14;
            this.BTNEncrypt.Text = "Encrypt";
            this.BTNEncrypt.UseVisualStyleBackColor = true;
            this.BTNEncrypt.Click += new System.EventHandler(this.BTNEncrypt_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // BTNAdd2
            // 
            this.BTNAdd2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNAdd2.Location = new System.Drawing.Point(727, 470);
            this.BTNAdd2.Name = "BTNAdd2";
            this.BTNAdd2.Size = new System.Drawing.Size(167, 30);
            this.BTNAdd2.TabIndex = 18;
            this.BTNAdd2.Text = "Add to Dictionary 2";
            this.BTNAdd2.UseVisualStyleBackColor = true;
            this.BTNAdd2.Click += new System.EventHandler(this.BTNAdd2_Click);
            // 
            // BTNAdd1
            // 
            this.BTNAdd1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNAdd1.Location = new System.Drawing.Point(727, 434);
            this.BTNAdd1.Name = "BTNAdd1";
            this.BTNAdd1.Size = new System.Drawing.Size(167, 30);
            this.BTNAdd1.TabIndex = 17;
            this.BTNAdd1.Text = "Add to Dictionary 1";
            this.BTNAdd1.UseVisualStyleBackColor = true;
            this.BTNAdd1.Click += new System.EventHandler(this.BTNAdd1_Click);
            // 
            // BTNOpen
            // 
            this.BTNOpen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BTNOpen.Location = new System.Drawing.Point(12, 12);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Size = new System.Drawing.Size(100, 30);
            this.BTNOpen.TabIndex = 16;
            this.BTNOpen.Text = "Load text ...";
            this.BTNOpen.UseVisualStyleBackColor = true;
            this.BTNOpen.Click += new System.EventHandler(this.BTNOpen_Click);
            // 
            // TXTData
            // 
            this.TXTData.Location = new System.Drawing.Point(12, 48);
            this.TXTData.Multiline = true;
            this.TXTData.Name = "TXTData";
            this.TXTData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXTData.Size = new System.Drawing.Size(882, 368);
            this.TXTData.TabIndex = 13;
            this.TXTData.TextChanged += new System.EventHandler(this.TXTData_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEncPerc);
            this.groupBox1.Controls.Add(this.lblEncSize);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.lblChar);
            this.groupBox1.Controls.Add(this.lblWords);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 183);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Statisitics";
            // 
            // lblEncPerc
            // 
            this.lblEncPerc.AutoSize = true;
            this.lblEncPerc.Location = new System.Drawing.Point(7, 117);
            this.lblEncPerc.Name = "lblEncPerc";
            this.lblEncPerc.Size = new System.Drawing.Size(173, 20);
            this.lblEncPerc.TabIndex = 29;
            this.lblEncPerc.Text = "Compression Ratio:";

            // 
            // lblEncSize
            // 
            this.lblEncSize.AutoSize = true;
            this.lblEncSize.Location = new System.Drawing.Point(7, 85);
            this.lblEncSize.Name = "lblEncSize";
            this.lblEncSize.Size = new System.Drawing.Size(196, 20);
            this.lblEncSize.TabIndex = 28;
            this.lblEncSize.Text = "Encryped text size (Bytes):";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(7, 55);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(130, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Text Size (bytes):";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(7, 31);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(141, 20);
            this.lblChar.TabIndex = 1;
            this.lblChar.Text = "Character counter:";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(7, 153);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(137, 20);
            this.lblWords.TabIndex = 0;
            this.lblWords.Text = "Number of Words:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(722, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 29);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWordCount
            // 
            this.btnWordCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnWordCount.Location = new System.Drawing.Point(568, 578);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(138, 29);
            this.btnWordCount.TabIndex = 28;
            this.btnWordCount.Text = "Word count";
            this.btnWordCount.UseVisualStyleBackColor = true;
            this.btnWordCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(415, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 29;
            this.button1.Text = "Generate Random text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWordCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNRemove1);
            this.Controls.Add(this.BTNSaveUtf);
            this.Controls.Add(this.BTNDecryptFileUtf);
            this.Controls.Add(this.BTNDecryptFile);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNAdd4);
            this.Controls.Add(this.BTNAdd3);
            this.Controls.Add(this.BTNDecrypt);
            this.Controls.Add(this.BTNEncrypt);
            this.Controls.Add(this.BTNAdd2);
            this.Controls.Add(this.BTNAdd1);
            this.Controls.Add(this.BTNOpen);
            this.Controls.Add(this.TXTData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arabic Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BTNRemove1;
        internal System.Windows.Forms.Button BTNSaveUtf;
        internal System.Windows.Forms.Button BTNDecryptFileUtf;
        internal System.Windows.Forms.Button BTNDecryptFile;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Timer Timer4;
        internal System.Windows.Forms.Timer Timer2;
        internal System.Windows.Forms.Button BTNSave;
        internal System.Windows.Forms.Timer Timer3;
        internal System.Windows.Forms.Button BTNAdd4;
        internal System.Windows.Forms.Button BTNAdd3;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.Button BTNDecrypt;
        internal System.Windows.Forms.Button BTNEncrypt;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Button BTNAdd2;
        internal System.Windows.Forms.Button BTNAdd1;
        internal System.Windows.Forms.Button BTNOpen;
        internal System.Windows.Forms.TextBox TXTData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEncSize;
        private System.Windows.Forms.Label lblEncPerc;
        private System.Windows.Forms.Button btnWordCount;
        private System.Windows.Forms.Button button1;
    }
}

