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
            this.loadTranscript = new System.Windows.Forms.Button();
            this.openTranscriptFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu_button = new System.Windows.Forms.Button();
            this.modelType = new System.Windows.Forms.ComboBox();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.transcriptLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transcript = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loadAudio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // translateEnglish
            // 
            this.translateEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.translateEnglish.Dock = System.Windows.Forms.DockStyle.Top;
            this.translateEnglish.FlatAppearance.BorderSize = 0;
            this.translateEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translateEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateEnglish.Location = new System.Drawing.Point(0, 29);
            this.translateEnglish.Name = "translateEnglish";
            this.translateEnglish.Size = new System.Drawing.Size(202, 29);
            this.translateEnglish.TabIndex = 0;
            this.translateEnglish.Text = "Translate to English";
            this.translateEnglish.UseVisualStyleBackColor = false;
            this.translateEnglish.Click += new System.EventHandler(this.translateEnglish_Click);
            // 
            // loadTranscript
            // 
            this.loadTranscript.BackColor = System.Drawing.Color.SandyBrown;
            this.loadTranscript.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadTranscript.FlatAppearance.BorderSize = 0;
            this.loadTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTranscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTranscript.Location = new System.Drawing.Point(0, 58);
            this.loadTranscript.Name = "loadTranscript";
            this.loadTranscript.Size = new System.Drawing.Size(202, 29);
            this.loadTranscript.TabIndex = 1;
            this.loadTranscript.Text = "Open Transcription";
            this.loadTranscript.UseVisualStyleBackColor = false;
            this.loadTranscript.Click += new System.EventHandler(this.loadTranscript_Click);
            // 
            // openTranscriptFolder
            // 
            this.openTranscriptFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.openTranscriptFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.openTranscriptFolder.FlatAppearance.BorderSize = 0;
            this.openTranscriptFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTranscriptFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTranscriptFolder.Location = new System.Drawing.Point(0, 87);
            this.openTranscriptFolder.Name = "openTranscriptFolder";
            this.openTranscriptFolder.Size = new System.Drawing.Size(202, 29);
            this.openTranscriptFolder.TabIndex = 2;
            this.openTranscriptFolder.Text = "Open Transcript Folder";
            this.openTranscriptFolder.UseVisualStyleBackColor = false;
            this.openTranscriptFolder.Click += new System.EventHandler(this.openTranscript_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 314);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "no file";
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(713, 80);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 30);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(769, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.openTranscriptFolder);
            this.panel2.Controls.Add(this.loadTranscript);
            this.panel2.Controls.Add(this.translateEnglish);
            this.panel2.Controls.Add(this.menu_button);
            this.panel2.Location = new System.Drawing.Point(597, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 29);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.Red;
            this.menu_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_button.FlatAppearance.BorderSize = 0;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_button.Location = new System.Drawing.Point(0, 0);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(202, 29);
            this.menu_button.TabIndex = 0;
            this.menu_button.Text = "Menu";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
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
            this.transcript.Location = new System.Drawing.Point(409, 86);
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
            this.label3.Location = new System.Drawing.Point(116, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "File:";
            // 
            // loadAudio
            // 
            this.loadAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAudio.Location = new System.Drawing.Point(12, 37);
            this.loadAudio.Name = "loadAudio";
            this.loadAudio.Size = new System.Drawing.Size(101, 24);
            this.loadAudio.TabIndex = 16;
            this.loadAudio.Text = "Load Audio";
            this.loadAudio.UseVisualStyleBackColor = true;
            this.loadAudio.Click += new System.EventHandler(this.loadAudio_Click);
            // 
            // Form_Transctiptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadAudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transcript);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transcriptLanguage);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.modelType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Transctiptor";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Transctiptor_FormClosed);
            this.Load += new System.EventHandler(this.Form);
            this.Click += new System.EventHandler(this.Form_Transctiptor_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button translateEnglish;
        private System.Windows.Forms.Button loadTranscript;
        private System.Windows.Forms.Button openTranscriptFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox modelType;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.ComboBox transcriptLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button transcript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadAudio;
    }
}

