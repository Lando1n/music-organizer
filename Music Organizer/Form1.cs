using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Music_Organizer
{
    public partial class Form1 : Form
    {
        private Runner run;
        bool running = false;
        public Form1()
        {
            InitializeComponent();
            rootFolderTB.Text = @"D:\Users\Landon\Downloads";
            destFolderTB.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        #region Form
        private void OrganizeButton_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                
                GetUIData();
                if (Directory.Exists(run.rootFolder) && Directory.Exists(run.destFolder))
                {
                   
                    backgroundWorker1.RunWorkerAsync();
                    running = true;
                }
                else
                {
                    MessageBox.Show("One of the locations do not exist");
                }
            }
            else
            {
                MessageBox.Show("Already running!");
            }
        }

        private void rootFolderTB_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                rootFolderTB.Text = fbd.SelectedPath;
            }
        }

        private void destFolderTB_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                destFolderTB.Text = fbd.SelectedPath;
            }
        }

        private void sameLocCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sameLocCB.Checked)
            {
                destFolderTB.Text = rootFolderTB.Text;
                destFolderTB.Enabled = false;
            }
            else
            {
                destFolderTB.Enabled = true;
            }
        }

        private void rootFolderTB_TextChanged(object sender, EventArgs e)
        {
            if (sameLocCB.Checked)
            {
                destFolderTB.Text = rootFolderTB.Text;
            }
        }

        private void MusicFolderBut_Click(object sender, EventArgs e)
        {
            rootFolderTB.Text = @"C:\Users\" + Environment.UserName + @"\Music";
            sameLocCB.Checked = true;
            destFolderTB.Text = rootFolderTB.Text;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            MessageBox.Show(FileList[0]);
        }
        #endregion

        private void GetUIData()
        {
            run = new Runner();
            run.rootFolder = rootFolderTB.Text;
            run.destFolder = destFolderTB.Text;
            run.removeNonAudio = cleanUpCB.Checked;
            run.removeFeat = featArtCB.Checked;
        }

        private void updateInfo(Song song)
        {
            artistLabel.Invoke((MethodInvoker)(() => artistLabel.Text = song.artist));
            albumLabel.Invoke((MethodInvoker)(() => albumLabel.Text = song.album));
        }
        
        private void setupProgress() //Finds the number of songs needed to be checked in music folder
        {
            //count the number of music files in root Folder
            int songs = 0;
            foreach (string ext in run.audioFileTypes)
            {
                foreach (string file in Directory.GetFiles(run.rootFolder, ext, SearchOption.AllDirectories))
                {
                    songs++;
                }
            }
            //Update total on GUI
            if (progressBar1.Parent.InvokeRequired)
            {
                progressBar1.Parent.Invoke(new MethodInvoker(delegate {
                    progressBar1.Maximum = songs;
                    progressBar1.Value = 0;
                    progressBar1.Step = 1;
                }));
            }
            totalSongs.Invoke((MethodInvoker)(() => totalSongs.Text = songs.ToString()));
        }

        private void updateComp() //Updates the progress bar, and the labels for counts of songs completed and moved
        {            
            if (progressBar1.Parent.InvokeRequired)
            {
                progressBar1.Parent.Invoke(new MethodInvoker(delegate { progressBar1.Value++; }));
            }
            compSongs.Invoke((MethodInvoker)(() => compSongs.Text =progressBar1.Value.ToString()));
            movedSongs.Invoke((MethodInvoker)(() => movedSongs.Text = run.songsMoved.ToString()));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string errorLogLoc= run.destFolder + @"\moving error log.txt";
            if (File.Exists(errorLogLoc))
            {
                File.Delete(errorLogLoc);
            }
            setupProgress();
            bool moved;
            foreach (string ext in run.audioFileTypes)
            {
                foreach (string file in Directory.GetFiles(run.rootFolder, ext, SearchOption.AllDirectories))
                {
                    moved = false;
                    Song song = new Song(file, run); //auto fetches meta tags to song instance
                    updateInfo(song); //updates current song on GUI
                    moved = song.moveSong(run.destFolder);
                    if (moved)
                    {
                        run.songsMoved++;
                    }
                    updateComp();
                }
            }
            if (run.removeNonAudio)
            {
                Cleanup.removeNonAudioFiles(run.rootFolder);
            }
            Cleanup.removeEmptyDirect(run.rootFolder);

            if (File.Exists(errorLogLoc))
            {
                Process.Start("notepad.exe", errorLogLoc);
            }
            running = false;
        }
    }
}
