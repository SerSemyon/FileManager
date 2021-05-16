
namespace FileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listFiles1 = new FileManager.ListFiles();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listFiles2 = new FileManager.ListFiles();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUnzip = new System.Windows.Forms.Button();
            this.buttonZip = new System.Windows.Forms.Button();
            this.buttonPastle = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.listFiles1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.mainTableLayoutPanel.Controls.Add(this.listFiles2, 2, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // listFiles1
            // 
            this.listFiles1.AllowDrop = true;
            this.listFiles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles1.FormattingEnabled = true;
            this.listFiles1.Location = new System.Drawing.Point(3, 29);
            this.listFiles1.Name = "listFiles1";
            this.listFiles1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listFiles1.Size = new System.Drawing.Size(374, 418);
            this.listFiles1.TabIndex = 4;
            this.listFiles1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFiles1_MouseClick);
            this.listFiles1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listFiles1_DragEnter);
            this.listFiles1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listFiles2_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 26);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(43, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FileManager.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(420, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 26);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FileManager.Properties.Resources.back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(43, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // listFiles2
            // 
            this.listFiles2.AllowDrop = true;
            this.listFiles2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles2.FormattingEnabled = true;
            this.listFiles2.Location = new System.Drawing.Point(423, 29);
            this.listFiles2.Name = "listFiles2";
            this.listFiles2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listFiles2.Size = new System.Drawing.Size(374, 418);
            this.listFiles2.TabIndex = 7;
            this.listFiles2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFiles2_MouseClick);
            this.listFiles2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listFiles2_DragEnter);
            this.listFiles2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listFiles2_MouseDoubleClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUnzip);
            this.panel1.Controls.Add(this.buttonZip);
            this.panel1.Controls.Add(this.buttonPastle);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonRename);
            this.panel1.Controls.Add(this.buttonCopy);
            this.panel1.Controls.Add(this.buttonNewFolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(380, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 424);
            this.panel1.TabIndex = 8;
            // 
            // buttonUnzip
            // 
            this.buttonUnzip.BackgroundImage = global::FileManager.Properties.Resources._unarchive_90724;
            this.buttonUnzip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUnzip.Location = new System.Drawing.Point(3, 180);
            this.buttonUnzip.Name = "buttonUnzip";
            this.buttonUnzip.Size = new System.Drawing.Size(34, 23);
            this.buttonUnzip.TabIndex = 11;
            this.buttonUnzip.UseVisualStyleBackColor = true;
            // 
            // buttonZip
            // 
            this.buttonZip.BackgroundImage = global::FileManager.Properties.Resources.seo_social_web_network_internet_89_icon_icons_com_61531;
            this.buttonZip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZip.Location = new System.Drawing.Point(3, 151);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(34, 23);
            this.buttonZip.TabIndex = 10;
            this.buttonZip.UseVisualStyleBackColor = true;
            // 
            // buttonPastle
            // 
            this.buttonPastle.BackgroundImage = global::FileManager.Properties.Resources.file_add_insert_plus_icon_178130;
            this.buttonPastle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPastle.Location = new System.Drawing.Point(3, 32);
            this.buttonPastle.Name = "buttonPastle";
            this.buttonPastle.Size = new System.Drawing.Size(34, 23);
            this.buttonPastle.TabIndex = 9;
            this.buttonPastle.UseVisualStyleBackColor = true;
            this.buttonPastle.Click += new System.EventHandler(this.buttonPastle_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::FileManager.Properties.Resources.trash_120980;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(3, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(34, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.BackgroundImage = global::FileManager.Properties.Resources.Rename_icon_icons_com_55827;
            this.buttonRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRename.Location = new System.Drawing.Point(3, 93);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(34, 23);
            this.buttonRename.TabIndex = 7;
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackgroundImage = global::FileManager.Properties.Resources.documents_files_copy_paste_icon_132933;
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopy.Location = new System.Drawing.Point(3, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(34, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.BackgroundImage = global::FileManager.Properties.Resources.newfolder_80795;
            this.buttonNewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewFolder.Location = new System.Drawing.Point(3, 64);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(34, 23);
            this.buttonNewFolder.TabIndex = 5;
            this.buttonNewFolder.UseVisualStyleBackColor = true;
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Файловый менеджер";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TextBox textBox1;
        private ListFiles listFiles1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private ListFiles listFiles2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.Button buttonPastle;
        private System.Windows.Forms.Button buttonUnzip;
        private System.Windows.Forms.Button buttonZip;
    }
}

