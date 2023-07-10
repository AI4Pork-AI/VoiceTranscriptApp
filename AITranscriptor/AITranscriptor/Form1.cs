using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AITranscriptor
{
    public partial class Form_Transctiptor : Form
    {
        private object syncGate = new object();
        private ProcessTracker p_tracker = new ProcessTracker();
        private Process whisper;
        private StringBuilder output = new StringBuilder();
        private bool outputChanged;

        string nn_model, file_type, lang, filename;
        string audioFolderName = "audio";
        string modelFolderName = "models";
        string transcriptFolderName = "transcripts";
        string translateFolderName = "translations";

        SortedDictionary<string, string>  g_lang = new SortedDictionary<string, string>
        {
            { "aaa", "auto"},
            { "en",  "english"},
            { "zh",  "chinese"},
            { "de",  "german"},
            { "es",  "spanish"},
            { "ru",  "russian"},
            { "ko",  "korean"},
            { "fr",  "french"},
            { "ja",  "japanese"},
            { "pt",  "portuguese"},
            { "tr",  "turkish"},
            { "pl",  "polish"},
            { "ca",  "catalan"},
            { "nl",  "dutch"},
            { "ar",  "arabic"},
            { "sv",  "swedish"},
            { "it",  "italian"},
            { "id",  "indonesian"},
            { "hi",  "hindi"},
            { "fi",  "finnish"},
            { "vi",  "vietnamese"},
            { "he",  "hebrew"},
            { "uk",  "ukrainian"},
            { "el",  "greek"},
            { "ms",  "malay"},
            { "cs",  "czech"},
            { "ro",  "romanian"},
            { "da",  "danish"},
            { "hu",  "hungarian"},
            { "ta",  "tamil"},
            { "no",  "norwegian"},
            { "th",  "thai"},
            { "ur",  "urdu"},
            { "hr",  "croatian"},
            { "bg",  "bulgarian"},
            { "lt",  "lithuanian"},
            { "la",  "latin"},
            { "mi",  "maori"},
            { "ml",  "malayalam"},
            { "cy",  "welsh"},
            { "sk",  "slovak"},
            { "te",  "telugu"},
            { "fa",  "persian"},
            { "lv",  "latvian"},
            { "bn",  "bengali"},
            { "sr",  "serbian"},
            { "az",  "azerbaijani"},
            { "sl",  "slovenian"},
            { "kn",  "kannada"},
            { "et",  "estonian"},
            { "mk",  "macedonian"},
            { "br",  "breton"},
            { "eu",  "basque"},
            { "is",  "icelandic"},
            { "hy",  "armenian"},
            { "ne",  "nepali"},
            { "mn",  "mongolian"},
            { "bs",  "bosnian"},
            { "kk",  "kazakh"},
            { "sq",  "albanian"},
            { "sw",  "swahili"},
            { "gl",  "galician"},
            { "mr",  "marathi"},
            { "pa",  "punjabi"},
            { "si",  "sinhala"},
            { "km",  "khmer"},
            { "sn",  "shona"},
            { "yo",  "yoruba"},
            { "so",  "somali"},
            { "af",  "afrikaans"},
            { "oc",  "occitan"},
            { "ka",  "georgian"},
            { "be",  "belarusian"},
            { "tg",  "tajik"},
            { "sd",  "sindhi"},
            { "gu",  "gujarati"},
            { "am",  "amharic"},
            { "yi",  "yiddish"},
            { "lo",  "lao"},
            { "uz",  "uzbek"},
            { "fo",  "faroese"},
            { "ht",  "haitian creole"},
            { "ps",  "pashto"},
            { "tk",  "turkmen"},
            { "nn",  "nynorsk"},
            { "mt",  "maltese"},
            { "sa",  "sanskrit"},
            { "lb",  "luxembourgish"},
            { "my",  "myanmar"},
            { "bo",  "tibetan"},
            { "tl",  "tagalog"},
            { "mg",  "malagasy"},
            { "as",  "assamese"},
            { "tt",  "tatar"},
            { "haw", "hawaiian"},
            { "ln",  "lingala"},
            { "ha",  "hausa"},
            { "ba",  "bashkir"},
            { "jw",  "javanese"},
            { "su",  "sundanese"},
        };

        public Form_Transctiptor()
        {
            InitializeComponent();
            transcriptLanguage.DataSource = new BindingSource(g_lang, null);
            transcriptLanguage.DisplayMember = "Value";
            transcriptLanguage.ValueMember = "Key";

            //Create directories if doesn't exist
            Directory.CreateDirectory(Application.StartupPath + "\\"+this.audioFolderName+"\\");
            Directory.CreateDirectory(Application.StartupPath + "\\" + this.modelFolderName + "\\");
            Directory.CreateDirectory(Application.StartupPath + "\\"+this.translateFolderName+"\\");
            Directory.CreateDirectory(Application.StartupPath + "\\" + this.transcriptFolderName + "\\");

            //If the models are present in their folder, add the option to select them
            List<string> models = new List<string>() { };

            if (File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-tiny.bin") ||
                File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-tiny_en.bin")) models.Add("Tiny");
            if (File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-base.bin") ||
                File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-base_en.bin")) models.Add("Base");
            if (File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-small.bin") ||
                File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-small_en.bin")) models.Add("Small");
            if (File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-medium.bin") ||
                File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-medium_en.bin")) models.Add("Medium");
            if (File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-large.bin") ||
                File.Exists(Application.StartupPath + "\\" + this.modelFolderName + "\\ggml-large_en.bin")) models.Add("High");

            modelType.DataSource = models;

            if(models.Any()) modelType.SelectedIndex = 0;

            fileType.SelectedIndex = 0;
            transcriptLanguage.SelectedIndex = 0;
        }

        private Process convertFile()
        {
            //ffmpeg -i input.mp3 -ar 16000 -ac 1 -c:a pcm_s16le output.wav
            string args = "-i \"" + Application.StartupPath + "\\"+this.audioFolderName+"\\" + this.filename + "\"" +
                          " -ar 16000" +
                          " -ac 1" +
                          " -c:a pcm_s16le \"" +
                          Application.StartupPath + "\\"+this.audioFolderName+"\\" + Path.GetFileNameWithoutExtension(this.filename) + ".wav\"";
            textBox1.Text = args; //DEBUG
            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "\"" + Application.StartupPath + "\\ffmpeg.exe\"";
            processStartInfo.Arguments = args;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            return process;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fileType.SelectedIndex)
            {
                case 0: //txt
                    this.file_type = "-otxt";
                    break;

                case 1: //csv
                    this.file_type = "-ocsv";
                    break;

                case 2: //vtt
                    this.file_type = "-ovtt";
                    break;

                case 3: //srt
                    this.file_type = "-osrt";
                    break;

                case 4: //words (karaoke)
                    this.file_type = "-owts";
                    break;
            }
        }

        private void Form(object sender, EventArgs e)
        {

        }

        private void Form_Transctiptor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Kill opened processes
            if (p_tracker.HasProcess("whisper"))
            {
                Process whisper2 = Process.GetProcessById(p_tracker.Processes.FirstOrDefault(x => x.Value == "whisper").Key);
                whisper2.Kill();
            }

            if (p_tracker.HasProcess("ffmpeg"))
            {
                Process ffmpeg = Process.GetProcessById(p_tracker.Processes.FirstOrDefault(x => x.Value == "ffmpeg").Key);
                ffmpeg.Kill();
            }
        }

        private void Form_Transctiptor_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
        }

        private void loadAudio_Click(object sender, EventArgs e)
        {
            string ext;
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    this.filename = openFileDialog.SafeFileName;
                    ext = Path.GetExtension(this.filename);

                    if (ext != ".wav")
                    {
                        if (!File.Exists(Application.StartupPath + "\\"+this.audioFolderName+"\\" + Path.GetFileNameWithoutExtension(this.filename) + ".wav"))
                        {
                            Process ffmpeg = this.convertFile();
                            ffmpeg.Start();
                            p_tracker.AddProcess(ffmpeg, "ffmpeg");
                            string output = ffmpeg.StandardOutput.ReadToEnd();
                            //textBox1.Text = "Converting file into .wav... Please wait"; //TODO: Please wait
                            ffmpeg.WaitForExit();
                            
                            //textBox1.Text = "";
                            Console.WriteLine("Current date (received from CMD):");
                            Console.Write(output);
                        }
                    }
                    this.filename = Path.GetFileNameWithoutExtension(this.filename) + ".wav";
                    label1.Text = this.filename;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void loadTranscript_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;

            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    label1.Text = openFileDialog.SafeFileName;
                    textBox1.Text = text;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;
        }

        private void modelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modelType.SelectedIndex)
            {
                case 0: //tiny
                    this.nn_model = "ggml-tiny";
                    break;

                case 1: //base
                    this.nn_model = "ggml-base";
                    break;

                case 2: //small
                    this.nn_model = "ggml-small";
                    break;

                case 3: //medium
                    this.nn_model = "ggml-medium";
                    break;

                case 4: //large
                    this.nn_model = "ggml-large";
                    break;
            }
        }

        private void openTranscript_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;
            Process.Start("\"" + Application.StartupPath + "\\"+this.audioFolderName+"\"");
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (syncGate)
            {
                if (sender != whisper) return;
                output.AppendLine(e.Data);
                if (outputChanged) return;
                outputChanged = true;
                BeginInvoke(new Action(OnOutputChanged));
            }
        }

        private void OnOutputChanged()
        {
            lock (syncGate)
            {
                textBox1.Text = output.ToString();
                outputChanged = false;
            }
        }

        private void OnProcessExited(object sender, EventArgs e)
        {
            lock (syncGate)
            {
                if (sender != whisper) return;
                whisper.Dispose();
                whisper = null;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string args = this.whisperArgsSetup(false);
            if (textBox1.Text == "")
            {
                textBox1.Text = "\"" + Application.StartupPath + "\\main.exe\"" + args;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void transcript_Click(object sender, EventArgs e)
        {
            if(this.filename != "") { 

                lock(syncGate)
                {
                    if (this.whisper != null) return;
                }
                output.Clear();
                outputChanged = false;
                textBox1.Text = "";

                this.whisper = this.whisperSetup(false);

                this.whisper.OutputDataReceived += OnOutputDataReceived;
                this.whisper.Exited += OnProcessExited;

                this.whisper.Start();

                this.whisper.BeginOutputReadLine();
            }
        }

        private void transcriptLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lang = transcriptLanguage.SelectedValue.ToString();
        }

        private void translateEnglish_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;

            textBox1.Text = "Translating... Please wait";

            Process whisper = this.whisperSetup(true);
            whisper.Start();
            p_tracker.AddProcess(whisper, "whisper");

            string output = whisper.StandardOutput.ReadToEnd();

            whisper.WaitForExit();

            File.WriteAllText("\"" + Application.StartupPath + "\\" + this.translateFolderName + "\\TR_" + Path.GetFileNameWithoutExtension(this.filename) + ".txt\"",
                                output);

            try
            {
               textBox1.Text = File.ReadAllText("\"" + Application.StartupPath + "\\"+this.translateFolderName + "\\TR_" + Path.GetFileNameWithoutExtension(this.filename) + ".txt\"");
            }
            catch (FileNotFoundException)
            {
                textBox1.Text = "Error: Translated file couldn't be created.";
            }

            
        }

        private Process whisperSetup(bool translate = false)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "\"" + Application.StartupPath + "\\main.exe\"";
            processStartInfo.Arguments = this.whisperArgsSetup(translate);
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processStartInfo;

            return process;
        }

        private string whisperArgsSetup(bool translate)
        {
            string args = " -m \"" + Application.StartupPath + "\\models\\" + this.nn_model + (this.lang == "en" ? ".en" : "") + ".bin\"" +
                          " -f \"" + Application.StartupPath + "\\"+this.audioFolderName+"\\" + this.filename + "\"" +
                          (transcriptLanguage.SelectedIndex == 0 ? "" : " -l " + this.lang) +
                          " "+ (this.file_type == ".txt" ? "-otxt " : "-otxt " + this.file_type)+
                          " -of \"" + Application.StartupPath + "\\" + transcriptFolderName + "\\" + Path.GetFileNameWithoutExtension(this.filename) + "\"" +
                          (translate ? " -tr " : "");    
            return args;
        } 
    }
}
