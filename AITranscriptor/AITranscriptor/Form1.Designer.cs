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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.open_transcript_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu_button = new System.Windows.Forms.Button();
            this.model_type = new System.Windows.Forms.ComboBox();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.transcriptLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Audio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open Transcription";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // open_transcript_button
            // 
            this.open_transcript_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.open_transcript_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.open_transcript_button.FlatAppearance.BorderSize = 0;
            this.open_transcript_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_transcript_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_transcript_button.Location = new System.Drawing.Point(0, 87);
            this.open_transcript_button.Name = "open_transcript_button";
            this.open_transcript_button.Size = new System.Drawing.Size(202, 29);
            this.open_transcript_button.TabIndex = 2;
            this.open_transcript_button.Text = "Open Transcript Folder";
            this.open_transcript_button.UseVisualStyleBackColor = false;
            this.open_transcript_button.Click += new System.EventHandler(this.open_transcript_Click);
            // 
            // textBox1
            // 
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
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "No transcription";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(713, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(769, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.open_transcript_button);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.menu_button);
            this.panel2.Location = new System.Drawing.Point(15, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 29);
            this.panel2.TabIndex = 7;
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
            this.menu_button.MouseLeave += new System.EventHandler(this.menu_button_MouseLeave);
            this.menu_button.MouseHover += new System.EventHandler(this.menu_button_MouseHover);
            // 
            // model_type
            // 
            this.model_type.FormattingEnabled = true;
            this.model_type.Items.AddRange(new object[] {
            "Small",
            "Medium ",
            "High"});
            this.model_type.Location = new System.Drawing.Point(15, 80);
            this.model_type.Name = "model_type";
            this.model_type.Size = new System.Drawing.Size(121, 21);
            this.model_type.TabIndex = 8;
            this.model_type.SelectedIndexChanged += new System.EventHandler(this.model_type_SelectedIndexChanged);
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
            this.fileType.Location = new System.Drawing.Point(142, 80);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(121, 21);
            this.fileType.TabIndex = 9;
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // transcriptLanguage
            // 
            this.transcriptLanguage.FormattingEnabled = true;
            this.transcriptLanguage.Items.AddRange(new object[] {
            "Auto",
            "Catalan",
            "Spanish ",
            "English"});
            this.transcriptLanguage.Location = new System.Drawing.Point(269, 80);
            this.transcriptLanguage.Name = "transcriptLanguage";
            this.transcriptLanguage.Size = new System.Drawing.Size(121, 21);
            this.transcriptLanguage.TabIndex = 10;
            this.transcriptLanguage.SelectedIndexChanged += new System.EventHandler(this.transcriptLanguage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Accuracy";
            // 
            // outputType
            // 
            this.outputType.AutoSize = true;
            this.outputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputType.Location = new System.Drawing.Point(139, 61);
            this.outputType.Name = "outputType";
            this.outputType.Size = new System.Drawing.Size(81, 16);
            this.outputType.TabIndex = 12;
            this.outputType.Text = "Output File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Language";
            // 
            // Form_Transctiptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transcriptLanguage);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.model_type);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Transctiptor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button open_transcript_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox model_type;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.ComboBox transcriptLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputType;
        private System.Windows.Forms.Label label4;
    }
}

