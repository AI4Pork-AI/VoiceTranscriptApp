using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITranscriptor
{
    public partial class Form_Transctiptor : Form
    {
        string nn_model, file_type, lang, filename;

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

            modelType.SelectedIndex = 1;
            fileType.SelectedIndex = 0;
            transcriptLanguage.SelectedIndex = 0;
        }

        private Process whisperSetup()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            //processStartInfo.FileName = "C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\main.exe";
            //processStartInfo.Arguments = "-m C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\models\\ggml-base.en.bin " +
            //                             "-f C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\samples\\jfk.wav " +
            //                             "-otxt";

            processStartInfo.FileName = Application.StartupPath + "\\main.exe";
            processStartInfo.Arguments = this.whisperArgsSetup();
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processStartInfo;

            return process;
        }

        private string whisperArgsSetup()
        {
            string args = " -m " + Application.StartupPath + "\\models\\" + this.nn_model + (this.lang == "en" ? ".en" : "") + ".bin" +
                          " -f " + Application.StartupPath + "\\samples\\" + filename +
                          (transcriptLanguage.SelectedIndex == 0 ? "" : " -l " + this.lang) +
                          " " + this.file_type;
            return args;
        }

        private void Form(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
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
                    this.filename = openFileDialog.SafeFileName;
                    label1.Text = this.filename;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.

            Process whisper = this.whisperSetup();
            whisper.Start();

            string output = whisper.StandardOutput.ReadToEnd();
            whisper.WaitForExit();

            try
            {
                textBox1.Text = File.ReadAllText(Application.StartupPath + "\\samples\\" + filename + ".txt");
            }
            catch (FileNotFoundException)
            {
                textBox1.Text = "Error: Transcript file couldn't be created.";
            }
            

            Console.WriteLine("Current date (received from CMD):");
            Console.Write(output);
            //Process.Start("C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\main -f samples/jfk.wav -otxt");
            //Process.Start(@"C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\main", "-f samples\\jfk.wav -otxt");
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void open_transcript_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;
            Process.Start(Application.StartupPath+"\\samples");
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string args = this.whisperArgsSetup();
            if (textBox1.Text == "")
            {
                textBox1.Text = Application.StartupPath + "\\main.exe" + args;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
            else panel2.Height = 116;
        }

        private void Form_Transctiptor_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 116) panel2.Height = 29;
        }

        private void transcript_Click(object sender, EventArgs e)
        {
            Process whisper = this.whisperSetup();
            whisper.Start();

            string output = whisper.StandardOutput.ReadToEnd();
            whisper.WaitForExit();

            try
            {
                textBox1.Text = File.ReadAllText(Application.StartupPath + "\\samples\\" + filename + ".txt");
            }
            catch (FileNotFoundException)
            {
                //textBox1.Text = "Error: Transcript file couldn't be created.";
            }


            Console.WriteLine("Current date (received from CMD):");
            Console.Write(output);
        }

        private void loadAudio_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    this.filename = openFileDialog.SafeFileName;
                    label1.Text = this.filename;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
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

        private void fileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fileType.SelectedIndex)
            {
                case 0: //txt
                    this.file_type = "";
                    break;

                case 1: //txt
                    this.file_type = "-otxt";
                    break;

                case 2: //csv
                    this.file_type = "-ocsv";
                    break;

                case 3: //vtt
                    this.file_type = "-ovtt";
                    break;

                case 4: //srt
                    this.file_type = "-osrt";
                    break;

                case 5: //words (karaoke)
                    this.file_type = "-owts";
                    break;
            }
        }

        private void transcriptLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lang = transcriptLanguage.SelectedValue.ToString();
        }
    }
}
