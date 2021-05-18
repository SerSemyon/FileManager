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
            EnterName nameForm = new EnterName("Новая папка", this);
            nameForm.ShowDialog();
            if (nameForm.result == DialogResult.OK)
            {
                Directory.CreateDirectory(Path.Combine(ActiveList.addressText.Text, nameForm.textBox1.Text));
                ActiveList.UpdateContent();
            }
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
            DialogResult del = MessageBox.Show("Вы уверены?", "Удалить?", MessageBoxButtons.OKCancel);
            if (del == DialogResult.OK)
            {
                foreach (var f in ActiveList.SelectedItems)
                {
                    try
                    {
                        Directory.Delete(ActiveList.addressText.Text + f, true);
                    }
                    catch
                    {
                        File.Delete(ActiveList.addressText.Text + f);
                    }
                }
                ActiveList.UpdateContent();
            }
        }
        
        private void buttonRename_Click(object sender, EventArgs e)
        {
            EnterName nameForm = new EnterName(ActiveList.SelectedItem.ToString(), this);
            nameForm.ShowDialog();
            if (nameForm.result == DialogResult.OK)
            {
                string newPath = Path.Combine(ActiveList.addressText.Text, nameForm.textBox1.Text);
                try
                {
                    if (File.Exists(newPath))
                    {
                        MessageBox.Show("Файл с таким именем уже существует", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        File.Move(Path.Combine(ActiveList.addressText.Text, ActiveList.SelectedItem.ToString()), newPath);
                    }

                }
                catch
                {
                    if (Directory.Exists(newPath))
                    {
                        MessageBox.Show("Папка с таким именем уже существует", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Directory.Move(Path.Combine(ActiveList.addressText.Text, ActiveList.SelectedItem.ToString()), newPath);
                    }
                }
                ActiveList.UpdateContent();
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            selectedFiles.Clear();
            foreach(var file in ActiveList.SelectedItems)
            {
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
                    File.Copy(file, ActiveList.addressText.Text+Path.GetFileName(file),true);
                }
            }
            listFiles1.UpdateContent();
            listFiles2.UpdateContent();
        }
        private void DirectoryCopy(string from, string to)
        {
            string newFolder = to + Path.GetFileName(from);
            DirectoryInfo dir = new DirectoryInfo(from);
            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(newFolder);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                file.CopyTo(Path.Combine(newFolder, file.Name), true);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                DirectoryCopy(subdir.FullName, Path.Combine(newFolder , subdir.Name));
            }

        }

        private void buttonZip_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnzip_Click(object sender, EventArgs e)
        {

        }
    }
}
