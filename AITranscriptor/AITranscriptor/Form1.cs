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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            string filename = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    filename = openFileDialog.SafeFileName;
                    label1.Text = filename;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.


            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            //processStartInfo.FileName = "C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\main.exe";
            //processStartInfo.Arguments = "-m C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\models\\ggml-base.en.bin " +
            //                             "-f C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\samples\\jfk.wav " +
            //                             "-otxt";

            processStartInfo.FileName = Application.StartupPath + "\\main.exe";
            processStartInfo.Arguments = Application.StartupPath + " -f samples\\"+filename+" -otxt";
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            textBox1.Text = File.ReadAllText(Application.StartupPath + "\\samples\\" + filename+".txt");

            Console.WriteLine("Current date (received from CMD):");
            Console.Write(output);
            //Process.Start("C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\main -f samples/jfk.wav -otxt");
            //Process.Start(@"C:\\Users\\usuari\\Cplus_Projects\\AITranscriptor\\AITranscriptor\\main", "-f samples\\jfk.wav -otxt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath+"\\samples");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = Application.StartupPath;
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
