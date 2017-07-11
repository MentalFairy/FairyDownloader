namespace FairyFileRenamerProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.downloadLinkTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.downloadLinkLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dontRenameCheckbox = new System.Windows.Forms.CheckBox();
            this.dontDeleteVideoCheckbox = new System.Windows.Forms.CheckBox();
            this.loadSongsButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathSelectorButton = new System.Windows.Forms.Button();
            this.songTitlesList = new System.Windows.Forms.CheckedListBox();
            this.selectAllCheckbox = new System.Windows.Forms.CheckBox();
            this.downloadStatusProgressbar = new System.Windows.Forms.ProgressBar();
            this.downloadStatusLabel = new System.Windows.Forms.Label();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.dontConvertCheckbox = new System.Windows.Forms.CheckBox();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.loadLinkPanel = new System.Windows.Forms.Panel();
            this.loadLinkLabel = new System.Windows.Forms.Label();
            this.convertionStatusProgressbar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadVideosPanel = new System.Windows.Forms.Panel();
            this.downloadVideosLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.downloadVideosButton = new System.Windows.Forms.Button();
            this.optionsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.loadLinkPanel.SuspendLayout();
            this.downloadVideosPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadLinkTextBox
            // 
            this.downloadLinkTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.downloadLinkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.downloadLinkTextBox.ForeColor = System.Drawing.Color.Cyan;
            this.downloadLinkTextBox.Location = new System.Drawing.Point(220, 15);
            this.downloadLinkTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.downloadLinkTextBox.Name = "downloadLinkTextBox";
            this.downloadLinkTextBox.Size = new System.Drawing.Size(694, 31);
            this.downloadLinkTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(252, 35);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(333, 73);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Downloader";
            // 
            // downloadLinkLabel
            // 
            this.downloadLinkLabel.AutoSize = true;
            this.downloadLinkLabel.ForeColor = System.Drawing.Color.White;
            this.downloadLinkLabel.Location = new System.Drawing.Point(16, 21);
            this.downloadLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.downloadLinkLabel.Name = "downloadLinkLabel";
            this.downloadLinkLabel.Size = new System.Drawing.Size(159, 25);
            this.downloadLinkLabel.TabIndex = 2;
            this.downloadLinkLabel.Text = "Download Link:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.destinationTextBox.ForeColor = System.Drawing.Color.Cyan;
            this.destinationTextBox.Location = new System.Drawing.Point(220, 75);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(612, 31);
            this.destinationTextBox.TabIndex = 3;
            this.destinationTextBox.Text = "C:\\Users\\FairyMental\\Desktop\\DownloadTest";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.ForeColor = System.Drawing.Color.White;
            this.destinationLabel.Location = new System.Drawing.Point(16, 88);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(176, 25);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Destination Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Song Titles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Options";
            // 
            // dontRenameCheckbox
            // 
            this.dontRenameCheckbox.AutoSize = true;
            this.dontRenameCheckbox.ForeColor = System.Drawing.Color.White;
            this.dontRenameCheckbox.Location = new System.Drawing.Point(16, 88);
            this.dontRenameCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dontRenameCheckbox.Name = "dontRenameCheckbox";
            this.dontRenameCheckbox.Size = new System.Drawing.Size(179, 29);
            this.dontRenameCheckbox.TabIndex = 11;
            this.dontRenameCheckbox.Text = "Don\'t Rename";
            this.dontRenameCheckbox.UseVisualStyleBackColor = true;
            this.dontRenameCheckbox.CheckedChanged += new System.EventHandler(this.dontRenameCheckbox_CheckedChanged);
            // 
            // dontDeleteVideoCheckbox
            // 
            this.dontDeleteVideoCheckbox.AutoSize = true;
            this.dontDeleteVideoCheckbox.ForeColor = System.Drawing.Color.White;
            this.dontDeleteVideoCheckbox.Location = new System.Drawing.Point(16, 133);
            this.dontDeleteVideoCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dontDeleteVideoCheckbox.Name = "dontDeleteVideoCheckbox";
            this.dontDeleteVideoCheckbox.Size = new System.Drawing.Size(274, 29);
            this.dontDeleteVideoCheckbox.TabIndex = 12;
            this.dontDeleteVideoCheckbox.Text = "Don\'t Delete Video Files";
            this.dontDeleteVideoCheckbox.UseVisualStyleBackColor = true;
            this.dontDeleteVideoCheckbox.CheckedChanged += new System.EventHandler(this.dontDeleteVideoCheckbox_CheckedChanged);
            // 
            // loadSongsButton
            // 
            this.loadSongsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loadSongsButton.ForeColor = System.Drawing.Color.White;
            this.loadSongsButton.Location = new System.Drawing.Point(1042, 408);
            this.loadSongsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadSongsButton.Name = "loadSongsButton";
            this.loadSongsButton.Size = new System.Drawing.Size(896, 44);
            this.loadSongsButton.TabIndex = 13;
            this.loadSongsButton.Text = "Load Link and Display Song Titles";
            this.loadSongsButton.UseVisualStyleBackColor = false;
            this.loadSongsButton.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // pathSelectorButton
            // 
            this.pathSelectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pathSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathSelectorButton.ForeColor = System.Drawing.Color.White;
            this.pathSelectorButton.Location = new System.Drawing.Point(848, 75);
            this.pathSelectorButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pathSelectorButton.Name = "pathSelectorButton";
            this.pathSelectorButton.Size = new System.Drawing.Size(70, 38);
            this.pathSelectorButton.TabIndex = 14;
            this.pathSelectorButton.UseVisualStyleBackColor = false;
            this.pathSelectorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // songTitlesList
            // 
            this.songTitlesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.songTitlesList.CheckOnClick = true;
            this.songTitlesList.ForeColor = System.Drawing.Color.Cyan;
            this.songTitlesList.FormattingEnabled = true;
            this.songTitlesList.Location = new System.Drawing.Point(10, 235);
            this.songTitlesList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.songTitlesList.Name = "songTitlesList";
            this.songTitlesList.Size = new System.Drawing.Size(904, 290);
            this.songTitlesList.TabIndex = 15;
            this.songTitlesList.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // selectAllCheckbox
            // 
            this.selectAllCheckbox.AutoSize = true;
            this.selectAllCheckbox.ForeColor = System.Drawing.Color.White;
            this.selectAllCheckbox.Location = new System.Drawing.Point(762, 190);
            this.selectAllCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectAllCheckbox.Name = "selectAllCheckbox";
            this.selectAllCheckbox.Size = new System.Drawing.Size(134, 29);
            this.selectAllCheckbox.TabIndex = 16;
            this.selectAllCheckbox.Text = "Select All";
            this.selectAllCheckbox.UseVisualStyleBackColor = true;
            this.selectAllCheckbox.CheckedChanged += new System.EventHandler(this.selectAllCheckbox_CheckedChanged);
            // 
            // downloadStatusProgressbar
            // 
            this.downloadStatusProgressbar.Location = new System.Drawing.Point(10, 690);
            this.downloadStatusProgressbar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.downloadStatusProgressbar.Name = "downloadStatusProgressbar";
            this.downloadStatusProgressbar.Size = new System.Drawing.Size(908, 29);
            this.downloadStatusProgressbar.TabIndex = 18;
            // 
            // downloadStatusLabel
            // 
            this.downloadStatusLabel.AutoSize = true;
            this.downloadStatusLabel.ForeColor = System.Drawing.Color.White;
            this.downloadStatusLabel.Location = new System.Drawing.Point(10, 660);
            this.downloadStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.downloadStatusLabel.Name = "downloadStatusLabel";
            this.downloadStatusLabel.Size = new System.Drawing.Size(186, 25);
            this.downloadStatusLabel.TabIndex = 19;
            this.downloadStatusLabel.Text = "Download Status: ";
            // 
            // cboResolution
            // 
            this.cboResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.cboResolution.Location = new System.Drawing.Point(772, 542);
            this.cboResolution.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(136, 33);
            this.cboResolution.TabIndex = 20;
            // 
            // dontConvertCheckbox
            // 
            this.dontConvertCheckbox.AutoSize = true;
            this.dontConvertCheckbox.ForeColor = System.Drawing.Color.White;
            this.dontConvertCheckbox.Location = new System.Drawing.Point(16, 177);
            this.dontConvertCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dontConvertCheckbox.Name = "dontConvertCheckbox";
            this.dontConvertCheckbox.Size = new System.Drawing.Size(245, 29);
            this.dontConvertCheckbox.TabIndex = 21;
            this.dontConvertCheckbox.Text = "Don\'t Convert to mp3";
            this.dontConvertCheckbox.UseVisualStyleBackColor = true;
            this.dontConvertCheckbox.CheckedChanged += new System.EventHandler(this.dontConvertCheckbox_CheckedChanged);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.label3);
            this.optionsPanel.Controls.Add(this.dontConvertCheckbox);
            this.optionsPanel.Controls.Add(this.dontRenameCheckbox);
            this.optionsPanel.Controls.Add(this.dontDeleteVideoCheckbox);
            this.optionsPanel.Location = new System.Drawing.Point(6, 806);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(400, 215);
            this.optionsPanel.TabIndex = 22;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.loadLinkPanel);
            this.mainPanel.Controls.Add(this.convertionStatusProgressbar);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.downloadLinkTextBox);
            this.mainPanel.Controls.Add(this.optionsPanel);
            this.mainPanel.Controls.Add(this.downloadLinkLabel);
            this.mainPanel.Controls.Add(this.downloadStatusLabel);
            this.mainPanel.Controls.Add(this.cboResolution);
            this.mainPanel.Controls.Add(this.downloadStatusProgressbar);
            this.mainPanel.Controls.Add(this.destinationTextBox);
            this.mainPanel.Controls.Add(this.destinationLabel);
            this.mainPanel.Controls.Add(this.songTitlesList);
            this.mainPanel.Controls.Add(this.selectAllCheckbox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.downloadVideosPanel);
            this.mainPanel.Controls.Add(this.pathSelectorButton);
            this.mainPanel.Location = new System.Drawing.Point(18, 115);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(940, 1027);
            this.mainPanel.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(866, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = ". . .";
            this.label7.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadLinkPanel
            // 
            this.loadLinkPanel.BackgroundImage = global::FairyFileRenamerProject.Properties.Resources.VisualStudioRedButton_1201;
            this.loadLinkPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadLinkPanel.Controls.Add(this.loadLinkLabel);
            this.loadLinkPanel.Location = new System.Drawing.Point(0, 123);
            this.loadLinkPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadLinkPanel.Name = "loadLinkPanel";
            this.loadLinkPanel.Size = new System.Drawing.Size(940, 56);
            this.loadLinkPanel.TabIndex = 26;
            this.loadLinkPanel.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // loadLinkLabel
            // 
            this.loadLinkLabel.AutoSize = true;
            this.loadLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadLinkLabel.ForeColor = System.Drawing.Color.Aqua;
            this.loadLinkLabel.Location = new System.Drawing.Point(300, 13);
            this.loadLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loadLinkLabel.Name = "loadLinkLabel";
            this.loadLinkLabel.Size = new System.Drawing.Size(315, 25);
            this.loadLinkLabel.TabIndex = 0;
            this.loadLinkLabel.Text = "Load Link - Dispaly Video Titles";
            this.loadLinkLabel.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // convertionStatusProgressbar
            // 
            this.convertionStatusProgressbar.Location = new System.Drawing.Point(10, 756);
            this.convertionStatusProgressbar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.convertionStatusProgressbar.Name = "convertionStatusProgressbar";
            this.convertionStatusProgressbar.Size = new System.Drawing.Size(908, 29);
            this.convertionStatusProgressbar.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 725);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Conversion Status:";
            // 
            // downloadVideosPanel
            // 
            this.downloadVideosPanel.BackgroundImage = global::FairyFileRenamerProject.Properties.Resources.VisualStudioRedButton_1201;
            this.downloadVideosPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadVideosPanel.Controls.Add(this.downloadVideosLabel);
            this.downloadVideosPanel.Location = new System.Drawing.Point(0, 598);
            this.downloadVideosPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.downloadVideosPanel.Name = "downloadVideosPanel";
            this.downloadVideosPanel.Size = new System.Drawing.Size(934, 56);
            this.downloadVideosPanel.TabIndex = 25;
            this.downloadVideosPanel.Click += new System.EventHandler(this.downloadVideosButton_Click);
            // 
            // downloadVideosLabel
            // 
            this.downloadVideosLabel.AutoSize = true;
            this.downloadVideosLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadVideosLabel.ForeColor = System.Drawing.Color.Aqua;
            this.downloadVideosLabel.Location = new System.Drawing.Point(310, 15);
            this.downloadVideosLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.downloadVideosLabel.Name = "downloadVideosLabel";
            this.downloadVideosLabel.Size = new System.Drawing.Size(270, 25);
            this.downloadVideosLabel.TabIndex = 0;
            this.downloadVideosLabel.Text = "Download Checked Videos";
            this.downloadVideosLabel.Click += new System.EventHandler(this.downloadVideosButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(110, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 73);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fairy ";
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePanel.BackgroundImage")));
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.Location = new System.Drawing.Point(622, 0);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(266, 104);
            this.imagePanel.TabIndex = 25;
            // 
            // downloadVideosButton
            // 
            this.downloadVideosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadVideosButton.ForeColor = System.Drawing.Color.White;
            this.downloadVideosButton.Location = new System.Drawing.Point(1042, 463);
            this.downloadVideosButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.downloadVideosButton.Name = "downloadVideosButton";
            this.downloadVideosButton.Size = new System.Drawing.Size(896, 44);
            this.downloadVideosButton.TabIndex = 17;
            this.downloadVideosButton.Text = "Download Videos";
            this.downloadVideosButton.UseVisualStyleBackColor = false;
            this.downloadVideosButton.Click += new System.EventHandler(this.downloadVideosButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(970, 1160);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.downloadVideosButton);
            this.Controls.Add(this.loadSongsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Fairy Downloader";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.loadLinkPanel.ResumeLayout(false);
            this.loadLinkPanel.PerformLayout();
            this.downloadVideosPanel.ResumeLayout(false);
            this.downloadVideosPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downloadLinkTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label downloadLinkLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox dontRenameCheckbox;
        private System.Windows.Forms.CheckBox dontDeleteVideoCheckbox;
        private System.Windows.Forms.Button loadSongsButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button pathSelectorButton;
        private System.Windows.Forms.CheckedListBox songTitlesList;
        private System.Windows.Forms.CheckBox selectAllCheckbox;
        private System.Windows.Forms.ProgressBar downloadStatusProgressbar;
        private System.Windows.Forms.Label downloadStatusLabel;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.CheckBox dontConvertCheckbox;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ProgressBar convertionStatusProgressbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel downloadVideosPanel;
        private System.Windows.Forms.Label downloadVideosLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel loadLinkPanel;
        private System.Windows.Forms.Label loadLinkLabel;
        private System.Windows.Forms.Button downloadVideosButton;
    }
}

