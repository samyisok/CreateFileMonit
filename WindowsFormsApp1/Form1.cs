using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public String lastString = "";
        public String dateTime = "";
        public List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();

        public Form1()
        {
            InitializeComponent();
        }

        public void fix( String var, DateTime dateTime)
        {
            Console.WriteLine("alarm1");
            Console.WriteLine(lastString);
            if (var != null && var != "" && !listBoxEx.Items.Contains(System.IO.Path.GetExtension(var)))
            {
                if (lastString.Equals(var)) { 
                //do nothing
                }
                else
                {
                    Console.WriteLine("ALARM2");
                    textBox1.Text += var + Environment.NewLine;
                    lastString = var;
                    notifyIcon1_balloon(var, "Update ");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }
        /* 
         private void notifyIcon1_Click(object sender, EventArgs e)
         {
             this.Show();
             this.WindowState = FormWindowState.Normal;
         }
         */
        private void Form1_Load(object sender, EventArgs e)
        {

            Text = "AraMonitoring";
            // load ex settings.
            if (AraMonitoring.Properties.Settings.Default.ex != "")
            {
                string exParams = AraMonitoring.Properties.Settings.Default.ex;
                listBoxEx.Items.AddRange(JsonConvert.DeserializeObject<Object[]>(exParams));
            }
            // load settings settings.
            if (AraMonitoring.Properties.Settings.Default.folders != "")
            {
                string foldersParams = AraMonitoring.Properties.Settings.Default.folders;
                listBoxFolders.Items.AddRange(JsonConvert.DeserializeObject<Object[]>(foldersParams));
            }

            foreach (string path in listBoxFolders.Items)
            {
                String watchFolder = path;
                watchers.Add(new FileSystemWatcher(watchFolder));
                System.Console.WriteLine("create wathcer " + watchFolder);
            };

            foreach (FileSystemWatcher fsw in watchers) { 
                System.Console.WriteLine("create fsw " + fsw.Path);
                fsw.IncludeSubdirectories = true;
                //fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
                fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName
                    | NotifyFilters.Size | NotifyFilters.CreationTime
                    | NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.Security;
                fsw.Created += new FileSystemEventHandler(fsw_Changed);
                fsw.EnableRaisingEvents = true;
            }
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            if (textBox1.InvokeRequired)
                textBox1.Invoke((MethodInvoker)delegate ()
                {
                    System.Console.WriteLine(e.FullPath);
                    fix(e.FullPath, DateTime.Now);
                });
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void notifyIcon1_balloon(String folder, String title)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = folder;
            notifyIcon1.BalloonTipTitle = title;
            Console.WriteLine("BALLOON");
            notifyIcon1.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
            notifyIcon1.ShowBalloonTip(1500);
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED");
            Process.Start("explorer.exe", "/select, " + Path.GetFullPath(notifyIcon1.BalloonTipText));
            notifyIcon1.BalloonTipClicked -= NotifyIcon1_BalloonTipClicked;
   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addExButton_Click(object sender, EventArgs e)
        {
            if ( textBoxEx.Text != null )
            {
                String stringEx = textBoxEx.Text;
                if (stringEx.Equals("") || listBoxEx.Items.Contains(stringEx))
                {
                    //do nothing
                }
                else
                {
                    listBoxEx.Items.Add(stringEx);
                    ListBox.ObjectCollection myItems = listBoxEx.Items;
                    string output = JsonConvert.SerializeObject(myItems);
                    AraMonitoring.Properties.Settings.Default.ex = output;
                    AraMonitoring.Properties.Settings.Default.Save();
                    System.Console.WriteLine(output);
                }
            }
        }

        private void DeleteExButton_Click(object sender, EventArgs e)
        {
            listBoxEx.Items.Remove(listBoxEx.SelectedItem);
            ListBox.ObjectCollection myItems = listBoxEx.Items;
            string output = JsonConvert.SerializeObject(myItems);
            AraMonitoring.Properties.Settings.Default.ex = output;
            AraMonitoring.Properties.Settings.Default.Save();
            System.Console.WriteLine(output);

        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select folder to monitoring";
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK && !listBoxFolders.Items.Contains(fbd.SelectedPath) )
            {
                listBoxFolders.Items.Add(fbd.SelectedPath);
                ListBox.ObjectCollection myItems = listBoxFolders.Items;
                string output = JsonConvert.SerializeObject(myItems);
                AraMonitoring.Properties.Settings.Default.folders = output;
                AraMonitoring.Properties.Settings.Default.Save();
                System.Console.WriteLine(output);

            }
        }

        private void DeleteFolderButton_Click(object sender, EventArgs e)
        {
            listBoxFolders.Items.Remove(listBoxFolders.SelectedItem);
            ListBox.ObjectCollection myItems = listBoxFolders.Items;
            string output = JsonConvert.SerializeObject(myItems);
            AraMonitoring.Properties.Settings.Default.folders = output;
            AraMonitoring.Properties.Settings.Default.Save();
            System.Console.WriteLine(output);
        }

        private void clearBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
