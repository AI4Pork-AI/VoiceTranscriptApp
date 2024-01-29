namespace AITranscriptor
{
    partial class Form_Transctiptor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.translateEnglish = new System.Windows.Forms.Button();
            this.loadTextFile = new System.Windows.Forms.Button();
            this.openAppFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.modelType = new System.Windows.Forms.ComboBox();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.transcriptLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transcript = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loadAudio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timestampsNo = new System.Windows.Forms.RadioButton();
            this.timestampsYes = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // translateEnglish
            // 
            this.translateEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.translateEnglish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.translateEnglish.FlatAppearance.BorderSize = 0;
            this.translateEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateEnglish.Location = new System.Drawing.Point(266, 2);
            this.translateEnglish.Name = "translateEnglish";
            this.translateEnglish.Size = new System.Drawing.Size(170, 29);
            this.translateEnglish.TabIndex = 0;
            this.translateEnglish.Text = "Translate to English";
            this.translateEnglish.UseVisualStyleBackColor = false;
            this.translateEnglish.Click += new System.EventHandler(this.translateEnglish_Click);
            // 
            // loadTextFile
            // 
            this.loadTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadTextFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loadTextFile.FlatAppearance.BorderSize = 0;
            this.loadTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTextFile.Location = new System.Drawing.Point(442, 2);
            this.loadTextFile.Name = "loadTextFile";
            this.loadTextFile.Size = new System.Drawing.Size(170, 29);
            this.loadTextFile.TabIndex = 1;
            this.loadTextFile.Text = "Load Text File";
            this.loadTextFile.UseVisualStyleBackColor = false;
            this.loadTextFile.Click += new System.EventHandler(this.loadTextFile_Click);
            // 
            // openAppFolder
            // 
            this.openAppFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openAppFolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openAppFolder.FlatAppearance.BorderSize = 0;
            this.openAppFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAppFolder.Location = new System.Drawing.Point(618, 2);
            this.openAppFolder.Name = "openAppFolder";
            this.openAppFolder.Size = new System.Drawing.Size(170, 29);
            this.openAppFolder.TabIndex = 2;
            this.openAppFolder.Text = "Program Folder";
            this.openAppFolder.UseVisualStyleBackColor = false;
            this.openAppFolder.Click += new System.EventHandler(this.openAppFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(776, 314);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "no file";
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(266, 36);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 30);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Visible = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // modelType
            // 
            this.modelType.FormattingEnabled = true;
            this.modelType.Location = new System.Drawing.Point(14, 93);
            this.modelType.Name = "modelType";
            this.modelType.Size = new System.Drawing.Size(121, 21);
            this.modelType.TabIndex = 8;
            this.modelType.SelectedIndexChanged += new System.EventHandler(this.modelType_SelectedIndexChanged);
            // 
            // fileType
            // 
            this.fileType.FormattingEnabled = true;
            this.fileType.Items.AddRange(new object[] {
            "txt",
            "csv",
            "vtt",
            "srt",
            "words (karaoke)"});
            this.fileType.Location = new System.Drawing.Point(141, 93);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(121, 21);
            this.fileType.TabIndex = 9;
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // transcriptLanguage
            // 
            this.transcriptLanguage.FormattingEnabled = true;
            this.transcriptLanguage.Location = new System.Drawing.Point(268, 93);
            this.transcriptLanguage.Name = "transcriptLanguage";
            this.transcriptLanguage.Size = new System.Drawing.Size(121, 21);
            this.transcriptLanguage.TabIndex = 10;
            this.transcriptLanguage.SelectedIndexChanged += new System.EventHandler(this.transcriptLanguage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Accuracy";
            // 
            // outputType
            // 
            this.outputType.AutoSize = true;
            this.outputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputType.Location = new System.Drawing.Point(138, 74);
            this.outputType.Name = "outputType";
            this.outputType.Size = new System.Drawing.Size(81, 16);
            this.outputType.TabIndex = 12;
            this.outputType.Text = "Output File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Audio Language";
            // 
            // transcript
            // 
            this.transcript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcript.Location = new System.Drawing.Point(497, 86);
            this.transcript.Name = "transcript";
            this.transcript.Size = new System.Drawing.Size(101, 30);
            this.transcript.TabIndex = 14;
            this.transcript.Text = "Transcript";
            this.transcript.UseVisualStyleBackColor = true;
            this.transcript.Click += new System.EventHandler(this.transcript_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "File:";
            // 
            // loadAudio
            // 
            this.loadAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAudio.Location = new System.Drawing.Point(12, 32);
            this.loadAudio.Name = "loadAudio";
            this.loadAudio.Size = new System.Drawing.Size(101, 24);
            this.loadAudio.TabIndex = 16;
            this.loadAudio.Text = "Load Audio";
            this.loadAudio.UseVisualStyleBackColor = true;
            this.loadAudio.Click += new System.EventHandler(this.loadAudio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Timestamps";
            // 
            // timestampsNo
            // 
            this.timestampsNo.AutoSize = true;
            this.timestampsNo.Location = new System.Drawing.Point(52, 3);
            this.timestampsNo.Name = "timestampsNo";
            this.timestampsNo.Size = new System.Drawing.Size(39, 17);
            this.timestampsNo.TabIndex = 19;
            this.timestampsNo.Text = "No";
            this.timestampsNo.UseVisualStyleBackColor = true;
            // 
            // timestampsYes
            // 
            this.timestampsYes.AutoSize = true;
            this.timestampsYes.Checked = true;
            this.timestampsYes.Location = new System.Drawing.Point(3, 3);
            this.timestampsYes.Name = "timestampsYes";
            this.timestampsYes.Size = new System.Drawing.Size(43, 17);
            this.timestampsYes.TabIndex = 18;
            this.timestampsYes.TabStop = true;
            this.timestampsYes.Text = "Yes";
            this.timestampsYes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.timestampsNo);
            this.panel3.Controls.Add(this.timestampsYes);
            this.panel3.Location = new System.Drawing.Point(392, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 21);
            this.panel3.TabIndex = 21;
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(604, 86);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(55, 30);
            this.stop.TabIndex = 22;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(702, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Status";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusBox.Location = new System.Drawing.Point(665, 88);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(123, 26);
            this.statusBox.TabIndex = 24;
            this.statusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contact
            // 
            this.contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contact.FlatAppearance.BorderSize = 0;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(705, 37);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(83, 29);
            this.contact.TabIndex = 25;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = false;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // Form_Transctiptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.translateEnglish);
            this.Controls.Add(this.loadTextFile);
            this.Controls.Add(this.openAppFolder);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadAudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transcript);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transcriptLanguage);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.modelType);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Transctiptor";
            this.Text = "AI Transcriptor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Transctiptor_FormClosed);
            this.Load += new System.EventHandler(this.Form);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button translateEnglish;
        private System.Windows.Forms.Button loadTextFile;
        private System.Windows.Forms.Button openAppFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ComboBox modelType;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.ComboBox transcriptLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button transcript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadAudio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton timestampsNo;
        private System.Windows.Forms.RadioButton timestampsYes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button contact;
    }
}

