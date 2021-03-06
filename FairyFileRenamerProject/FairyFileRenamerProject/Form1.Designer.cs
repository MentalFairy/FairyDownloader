﻿namespace FairyFileRenamerProject
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
            this.downloadLinkTextBox.Location = new System.Drawing.Point(110, 8);
            this.downloadLinkTextBox.Name = "downloadLinkTextBox";
            this.downloadLinkTextBox.Size = new System.Drawing.Size(349, 20);
            this.downloadLinkTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(126, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 36);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Downloader";
            // 
            // downloadLinkLabel
            // 
            this.downloadLinkLabel.AutoSize = true;
            this.downloadLinkLabel.ForeColor = System.Drawing.Color.White;
            this.downloadLinkLabel.Location = new System.Drawing.Point(8, 11);
            this.downloadLinkLabel.Name = "downloadLinkLabel";
            this.downloadLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.downloadLinkLabel.TabIndex = 2;
            this.downloadLinkLabel.Text = "Download Link:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.destinationTextBox.ForeColor = System.Drawing.Color.Cyan;
            this.destinationTextBox.Location = new System.Drawing.Point(110, 39);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(308, 20);
            this.destinationTextBox.TabIndex = 3;
            this.destinationTextBox.Text = "C:\\Users\\FairyMental\\Desktop\\DownloadTest";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.ForeColor = System.Drawing.Color.White;
            this.destinationLabel.Location = new System.Drawing.Point(8, 46);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(88, 13);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Destination Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Song Titles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Options";
            // 
            // dontRenameCheckbox
            // 
            this.dontRenameCheckbox.AutoSize = true;
            this.dontRenameCheckbox.ForeColor = System.Drawing.Color.White;
            this.dontRenameCheckbox.Location = new System.Drawing.Point(8, 46);
            this.dontRenameCheckbox.Name = "dontRenameCheckbox";
            this.dontRenameCheckbox.Size = new System.Drawing.Size(94, 17);
            this.dontRenameCheckbox.TabIndex = 11;
            this.dontRenameCheckbox.Text = "Don\'t Rename";
            this.dontRenameCheckbox.UseVisualStyleBackColor = true;
            this.dontRenameCheckbox.CheckedChanged += new System.EventHandler(this.dontRenameCheckbox_CheckedChanged);
            // 
            // dontDeleteVideoCheckbox
            // 
            this.dontDeleteVideoCheckbox.AutoSize = true;
            this.dontDeleteVideoCheckbox.ForeColor = System.Drawing.Color.White;
            this.dontDeleteVideoCheckbox.Location = new System.Drawing.Point(8, 69);
            this.dontDeleteVideoCheckbox.Name = "dontDeleteVideoCheckbox";
            this.dontDeleteVideoCheckbox.Size = new System.Drawing.Size(139, 17);
            this.dontDeleteVideoCheckbox.TabIndex = 12;
            this.dontDeleteVideoCheckbox.Text = "Don\'t Delete Video Files";
            this.dontDeleteVideoCheckbox.UseVisualStyleBackColor = true;
            this.dontDeleteVideoCheckbox.CheckedChanged += new System.EventHandler(this.dontDeleteVideoCheckbox_CheckedChanged);
            // 
            // loadSongsButton
            // 
            this.loadSongsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loadSongsButton.ForeColor = System.Drawing.Color.White;
            this.loadSongsButton.Location = new System.Drawing.Point(521, 212);
            this.loadSongsButton.Name = "loadSongsButton";
            this.loadSongsButton.Size = new System.Drawing.Size(448, 23);
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
            this.pathSelectorButton.Location = new System.Drawing.Point(424, 39);
            this.pathSelectorButton.Name = "pathSelectorButton";
            this.pathSelectorButton.Size = new System.Drawing.Size(35, 20);
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
            this.songTitlesList.Location = new System.Drawing.Point(5, 122);
            this.songTitlesList.Name = "songTitlesList";
            this.songTitlesList.Size = new System.Drawing.Size(454, 154);
            this.songTitlesList.TabIndex = 15;
            this.songTitlesList.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // selectAllCheckbox
            // 
            this.selectAllCheckbox.AutoSize = true;
            this.selectAllCheckbox.ForeColor = System.Drawing.Color.White;
            this.selectAllCheckbox.Location = new System.Drawing.Point(381, 99);
            this.selectAllCheckbox.Name = "selectAllCheckbox";
            this.selectAllCheckbox.Size = new System.Drawing.Size(70, 17);
            this.selectAllCheckbox.TabIndex = 16;
            this.selectAllCheckbox.Text = "Select All";
            this.selectAllCheckbox.UseVisualStyleBackColor = true;
            this.selectAllCheckbox.CheckedChanged += new System.EventHandler(this.selectAllCheckbox_CheckedChanged);
            // 
            // downloadStatusProgressbar
            // 
            this.downloadStatusProgressbar.Location = new System.Drawing.Point(5, 359);
            this.downloadStatusProgressbar.Name = "downloadStatusProgressbar";
            this.downloadStatusProgressbar.Size = new System.Drawing.Size(454, 15);
            this.downloadStatusProgressbar.TabIndex = 18;
            // 
            // downloadStatusLabel
            // 
            this.downloadStatusLabel.AutoSize = true;
            this.downloadStatusLabel.ForeColor = System.Drawing.Color.White;
            this.downloadStatusLabel.Location = new System.Drawing.Point(5, 343);
            this.downloadStatusLabel.Name = "downloadStatusLabel";
            this.downloadStatusLabel.Size = new System.Drawing.Size(94, 13);
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
            this.cboResolution.Location = new System.Drawing.Point(386, 282);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(70, 21);
            this.cboResolution.TabIndex = 20;
            // 
            // dontConvertCheckbox
            // 
            this.dontConvertCheckbox.AutoSize = true;
            this.dontConvertCheckbox.ForeColor = System.Drawing.Color.White;
            this.dontConvertCheckbox.Location = new System.Drawing.Point(8, 92);
            this.dontConvertCheckbox.Name = "dontConvertCheckbox";
            this.dontConvertCheckbox.Size = new System.Drawing.Size(126, 17);
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
            this.optionsPanel.Location = new System.Drawing.Point(3, 419);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(200, 112);
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
            this.mainPanel.Location = new System.Drawing.Point(9, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(470, 534);
            this.mainPanel.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(429, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = ". . .";
            // 
            // loadLinkPanel
            // 
            this.loadLinkPanel.BackgroundImage = global::FairyFileRenamerProject.Properties.Resources.VisualStudioRedButton_1201;
            this.loadLinkPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadLinkPanel.Controls.Add(this.loadLinkLabel);
            this.loadLinkPanel.Location = new System.Drawing.Point(0, 64);
            this.loadLinkPanel.Name = "loadLinkPanel";
            this.loadLinkPanel.Size = new System.Drawing.Size(470, 29);
            this.loadLinkPanel.TabIndex = 26;
            this.loadLinkPanel.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // loadLinkLabel
            // 
            this.loadLinkLabel.AutoSize = true;
            this.loadLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadLinkLabel.ForeColor = System.Drawing.Color.Aqua;
            this.loadLinkLabel.Location = new System.Drawing.Point(150, 7);
            this.loadLinkLabel.Name = "loadLinkLabel";
            this.loadLinkLabel.Size = new System.Drawing.Size(155, 13);
            this.loadLinkLabel.TabIndex = 0;
            this.loadLinkLabel.Text = "Load Link - Dispaly Video Titles";
            this.loadLinkLabel.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // convertionStatusProgressbar
            // 
            this.convertionStatusProgressbar.Location = new System.Drawing.Point(5, 393);
            this.convertionStatusProgressbar.Name = "convertionStatusProgressbar";
            this.convertionStatusProgressbar.Size = new System.Drawing.Size(454, 15);
            this.convertionStatusProgressbar.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Conversion Status:";
            // 
            // downloadVideosPanel
            // 
            this.downloadVideosPanel.BackgroundImage = global::FairyFileRenamerProject.Properties.Resources.VisualStudioRedButton_1201;
            this.downloadVideosPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadVideosPanel.Controls.Add(this.downloadVideosLabel);
            this.downloadVideosPanel.Location = new System.Drawing.Point(0, 311);
            this.downloadVideosPanel.Name = "downloadVideosPanel";
            this.downloadVideosPanel.Size = new System.Drawing.Size(467, 29);
            this.downloadVideosPanel.TabIndex = 25;
            this.downloadVideosPanel.Click += new System.EventHandler(this.downloadVideosButton_Click);
            // 
            // downloadVideosLabel
            // 
            this.downloadVideosLabel.AutoSize = true;
            this.downloadVideosLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadVideosLabel.ForeColor = System.Drawing.Color.Aqua;
            this.downloadVideosLabel.Location = new System.Drawing.Point(155, 8);
            this.downloadVideosLabel.Name = "downloadVideosLabel";
            this.downloadVideosLabel.Size = new System.Drawing.Size(136, 13);
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
            this.label4.Location = new System.Drawing.Point(55, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fairy ";
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePanel.BackgroundImage")));
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.Location = new System.Drawing.Point(311, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(133, 54);
            this.imagePanel.TabIndex = 25;
            // 
            // downloadVideosButton
            // 
            this.downloadVideosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadVideosButton.ForeColor = System.Drawing.Color.White;
            this.downloadVideosButton.Location = new System.Drawing.Point(521, 241);
            this.downloadVideosButton.Name = "downloadVideosButton";
            this.downloadVideosButton.Size = new System.Drawing.Size(448, 23);
            this.downloadVideosButton.TabIndex = 17;
            this.downloadVideosButton.Text = "Download Videos";
            this.downloadVideosButton.UseVisualStyleBackColor = false;
            this.downloadVideosButton.Click += new System.EventHandler(this.downloadVideosButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(485, 603);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.downloadVideosButton);
            this.Controls.Add(this.loadSongsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

