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
        private bool translate = false;

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

        /// <summary>
        /// Constructor of the form. It initializes its components.
        /// </summary>
        public Form_Transctiptor()
        {
            InitializeComponent();

            transcriptLanguage.DataSource = new BindingSource(g_lang, null);
            transcriptLanguage.DisplayMember = "Value";
            transcriptLanguage.ValueMember = "Key";

            //Create directories if doesn't exist
            Directory.CreateDirectory(Application.StartupPath + "\\" + this.audioFolderName+"\\");
            Directory.CreateDirectory(Application.StartupPath + "\\" + this.modelFolderName + "\\");
            Directory.CreateDirectory(Application.StartupPath + "\\" + this.translateFolderName+"\\");
            Directory.CreateDirectory(Application.StartupPath + "\\" + this.transcriptFolderName + "\\");
            Directory.CreateDirectory(Application.StartupPath + "\\dll\\");

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
            statusBox.Text = "Ready";
            transcript.Enabled = true;
            translateEnglish.Enabled = true;
            loadTextFile.Enabled = true;
        }

        /// <summary>
        /// This function creates a process that converts any audio to .wav format. It requires the ffmpeg application.
        /// </summary>
        /// <returns>Ffmpeg application instance</returns>
        private Process convertFile(string file_path_and_name)
        {
            //ffmpeg -i input.mp3 -ar 16000 -ac 1 -c:a pcm_s16le output.wav
            string args = "-i \"" + file_path_and_name + "\"" +
                          " -ar 16000" +
                          " -ac 1" +
                          " -c:a pcm_s16le \"" +
                          Application.StartupPath + "\\"+this.audioFolderName+"\\" + Path.GetFileNameWithoutExtension(this.filename) + ".wav\"";

            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "\"" + Application.StartupPath + "\\dll\\ffmpeg.exe\"";
            processStartInfo.Arguments = args;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processStartInfo;

            //this.textBox1.Text = "\"" + Application.StartupPath + "\\dll\\ffmpeg.exe\"" + " " + args; //Debug

            return process;
        }

        /// <summary>
        /// Index changed control for the 'fileType' dropdown list. The function saves the correct whisper instance of the output filetype.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Determines what to do when the form is closed. That is, kill all the running background applications (whisper and ffmpeg).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Transctiptor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close opened processes
            if (this.whisper != null && !this.whisper.HasExited)
            {
                this.whisper.Close();
            }

            if (p_tracker.HasProcess("ffmpeg"))
            {
                Process ffmpeg = Process.GetProcessById(p_tracker.Processes.FirstOrDefault(x => x.Value == "ffmpeg").Key);
                ffmpeg.Close();
            }
        }

        /// <summary>
        /// Control for the 'loadAudio' button. This function opens the file explorer and allows the user to select an audio file. 
        /// Using the 'ffmpeg' app, the function converts the selected file to .wav format.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadAudio_Click(object sender, EventArgs e)
        {
            statusBox.Text = "Loading...";
            //transcript.Enabled = false;
            //translateEnglish.Enabled = false;
            //loadTextFile.Enabled = false;
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
                            Process ffmpeg = this.convertFile(file);
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
            statusBox.Text = "Ready";
            //transcript.Enabled = true;
            //translateEnglish.Enabled = true;
            //loadTextFile.Enabled = true;
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        /// <summary>
        /// Control for the button 'loadTextFile'. This function opens the file explorer and allows the user to select a text file which will be shown in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadTextFile_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file, Encoding.UTF8);
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

        /// <summary>
        /// Control for the 'modelType' dropdown list. When an accuracy level is selected, the function saves the proper model 'whisper' instruction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Control for the 'openAppFolder' button. This function will open the app folder in the file explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openAppFolder_Click(object sender, EventArgs e)
        {
            Process.Start("\"" + Application.StartupPath + "\"");
        }

        /// <summary>
        /// Function that controls the received 'whisper' output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This function prints the whisper output in the form.
        /// </summary>
        private void OnOutputChanged()
        {
            lock (syncGate)
            {
                textBox1.Text = output.ToString();
                outputChanged = false;
            }
        }

        /// <summary>
        /// The function controls what to do when the whisper app finishes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnProcessExited(object sender, EventArgs e)
        {
            lock (syncGate)
            {
                if (sender != whisper) return;
                whisper.Dispose();
                whisper = null;
                BeginInvoke(new Action(asyncWhisperExit));
            }

        }

        private void asyncWhisperExit()
        {
            if (!timestampsNo.Checked && this.file_type == "-otxt")
            {
                File.WriteAllText(Application.StartupPath + "\\" + this.transcriptFolderName + "\\" + Path.GetFileNameWithoutExtension(this.filename) + "_timestamps.txt",
                                  textBox1.Text);
            }

            if (statusBox.Text != "Stopped") statusBox.Text = "Finished";
        }

        private void stopTranscript()
        {
            if (this.whisper != null) if (!this.whisper.HasExited) if (this.whisper != null)
            {
                statusBox.Text = "Stopped";
                this.whisper.Kill();
            }

            if (p_tracker.HasProcess("ffmpeg"))
            {
                Process ffmpeg = Process.GetProcessById(p_tracker.Processes.FirstOrDefault(x => x.Value == "ffmpeg").Key);
                ffmpeg.Close();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.stopTranscript();
            //transcript.Enabled = true;
            //translateEnglish.Enabled = true;
            //loadTextFile.Enabled = true;
        }

        /// <summary>
        /// Test button functionalities (for debugging purposes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testButton_Click(object sender, EventArgs e)
        {
            string args = this.whisperArgsSetup(false);
            if (textBox1.Text == "")
            {
                textBox1.Text = "\"" + Application.StartupPath + "\\dll\\main.exe\"" + args;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        /// <summary>
        /// Control for the 'transcript' button. The function calls the 'whisper' app and proceed to transcribe the given audio with 
        /// the given specifications in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transcript_Click(object sender, EventArgs e)
        {
            this.whisperStart(sender, e);
        }

        /// <summary>
        /// Control for the 'transcriptLanguage' dropdown list. This function saves the selected language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transcriptLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lang = transcriptLanguage.SelectedValue.ToString();
        }

        /// <summary>
        /// Control for the button 'translateEnglish'. The function uses whisper app to translate the given audio to english. 
        /// It also considers the parameters related to the audio, that is; the accuracy, the language, and the timestamps.
        /// It creates an output file in the 'translations' folder with the origin with name 'TR_filename.txt'. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void translateEnglish_Click(object sender, EventArgs e)
        {
            this.whisperStart(sender, e);
        }

        /// <summary>
        /// Start whisper process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ebool"></param>
        private void whisperStart(object sender, EventArgs ebool)
        {
            this.stopTranscript(); // Stop previous transcription if exist.

            if (this.filename != "")
            {
                lock (syncGate)
                {
                    if (this.whisper != null) return;
                }
                output.Clear();
                outputChanged = false;
                textBox1.Text = "";
                statusBox.Text = translate ? "Translating" : "Transcripting";
                //transcript.Enabled = false;
                //translateEnglish.Enabled = false;
                //loadTextFile.Enabled = false;

                this.whisper = this.whisperSetup(timestampsNo.Checked);
                this.whisper.EnableRaisingEvents = true;
                this.whisper.OutputDataReceived += OnOutputDataReceived;
                this.whisper.Exited += OnProcessExited;


                this.whisper.Start();

                this.whisper.BeginOutputReadLine();
            }
        }

        /// <summary>
        /// This function sets the characteristics of the whisper app.
        /// </summary>
        /// <param name="translate"></param>
        /// <param name="no_timestamps"></param>
        /// <returns>Returns a ProcessStartInfo object containing all the characteristics of the whisper app.</returns>
        private Process whisperSetup(bool no_timestamps = true)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = "\"" + Application.StartupPath + "\\dll\\main.exe\"";
            processStartInfo.Arguments = this.whisperArgsSetup(no_timestamps);
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.StandardOutputEncoding = Encoding.UTF8;

            Process process = new Process();
            process.StartInfo = processStartInfo;

            return process;
        }

        /// <summary>
        /// This function sets the argumetns for the whisper app.
        /// </summary>
        /// <param name="translate"></param>
        /// <param name="no_timestamps"></param>
        /// <returns>Gives a string containing all the arguments of the whisper app.</returns>
        private string whisperArgsSetup(bool no_timestamps)
        {
            string args = " -m \"" + Application.StartupPath + "\\models\\" + this.nn_model + (this.lang == "en" ? ".en" : "") + ".bin\"" +
                          " -f \"" + Application.StartupPath + "\\"+this.audioFolderName+"\\" + this.filename + "\"" +
                          (transcriptLanguage.SelectedIndex == 0 ? "" : " -l " + this.lang) +
                          " "+ ("-otxt " + this.file_type)+
                          " -of \"" + Application.StartupPath + "\\" + (translate ? translateFolderName : transcriptFolderName) + "\\" + Path.GetFileNameWithoutExtension(this.filename) + "\"" +
                          (no_timestamps ? " -nt" : "") +
                          (translate ? " -tr " : "");

            this.translate = false;
            return args;
        } 
    }
}
