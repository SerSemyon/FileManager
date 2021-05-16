using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace FileManager
{
    public partial class MainForm : Form
    {
        ListFiles ActiveList;
        List<string> selectedFiles;
        public MainForm()
        {
            InitializeComponent();
            listFiles1.addressText = textBox1;
            listFiles1.ShowMyComputer();
            listFiles2.addressText = textBox2;
            listFiles2.ShowMyComputer();
            ActiveList = listFiles1;
            selectedFiles = new List<string>(10);
        }

        private void listFiles2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listFiles1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listFiles1.GoBack();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            listFiles1.OpenDirectory(textBox1.Text);
        }

        private void listFiles2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            listFiles2.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listFiles2.GoBack();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                listFiles2.OpenDirectory(textBox1.Text);
        }

        private void listFiles1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listFiles2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            
        }

        private void listFiles1_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveList = listFiles1;
        }

        private void listFiles2_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveList = listFiles2;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonRename_Click(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            selectedFiles.Clear();
            foreach(FileInfo file in ActiveList.SelectedItems)
            {
                string bla = file.ToString();
                selectedFiles.Add(ActiveList.addressText.Text + file.ToString());
            }
        }

        private void buttonPastle_Click(object sender, EventArgs e)
        {
            foreach (string file in selectedFiles)
            {
                if (File.GetAttributes(file) == FileAttributes.Directory)
                {
                    DirectoryCopy(file, ActiveList.addressText.Text);
                }
                else
                {
                    Directory.CreateDirectory(ActiveList.addressText.Text + Path.GetFileName(file));
                    File.Copy(file, ActiveList.addressText.Text+Path.GetDirectoryName(file));
                }
            }
        }
        private void DirectoryCopy(string from, string to)
        {
            string newFolder = to + Path.GetDirectoryName(from);
            DirectoryInfo dir = new DirectoryInfo(from);
            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(to);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(to, file.Name);
                file.CopyTo(tempPath, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(to, subdir.Name);
                DirectoryCopy(subdir.FullName, tempPath);
            }

        }
    }
}
