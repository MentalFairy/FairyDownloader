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
            this.downloadLinkTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.downloadLinkLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dontRenameCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loadSongsButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathSelectorButton = new System.Windows.Forms.Button();
            this.songTitlesList = new System.Windows.Forms.CheckedListBox();
            this.selectAllCheckbox = new System.Windows.Forms.CheckBox();
            this.downloadVideosButton = new System.Windows.Forms.Button();
            this.downloadStatusProgressbar = new System.Windows.Forms.ProgressBar();
            this.downloadStatusLabel = new System.Windows.Forms.Label();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // downloadLinkTextBox
            // 
            this.downloadLinkTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.downloadLinkTextBox.Location = new System.Drawing.Point(101, 38);
            this.downloadLinkTextBox.Name = "downloadLinkTextBox";
            this.downloadLinkTextBox.Size = new System.Drawing.Size(371, 20);
            this.downloadLinkTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(162, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(162, 26);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Fairy Downloader";
            // 
            // downloadLinkLabel
            // 
            this.downloadLinkLabel.AutoSize = true;
            this.downloadLinkLabel.Location = new System.Drawing.Point(12, 41);
            this.downloadLinkLabel.Name = "downloadLinkLabel";
            this.downloadLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.downloadLinkLabel.TabIndex = 2;
            this.downloadLinkLabel.Text = "Download Link:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(101, 64);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(330, 20);
            this.destinationTextBox.TabIndex = 3;
            this.destinationTextBox.Text = "C:\\Users\\FairyMental\\Desktop\\DownloadTest";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(7, 67);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(88, 13);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Destination Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Song Titles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Options";
            // 
            // dontRenameCheckbox
            // 
            this.dontRenameCheckbox.AutoSize = true;
            this.dontRenameCheckbox.Location = new System.Drawing.Point(10, 530);
            this.dontRenameCheckbox.Name = "dontRenameCheckbox";
            this.dontRenameCheckbox.Size = new System.Drawing.Size(94, 17);
            this.dontRenameCheckbox.TabIndex = 11;
            this.dontRenameCheckbox.Text = "Don\'t Rename";
            this.dontRenameCheckbox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 553);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Don\'t download whole playlist";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loadSongsButton
            // 
            this.loadSongsButton.Location = new System.Drawing.Point(10, 90);
            this.loadSongsButton.Name = "loadSongsButton";
            this.loadSongsButton.Size = new System.Drawing.Size(462, 23);
            this.loadSongsButton.TabIndex = 13;
            this.loadSongsButton.Text = "Load Link and Display Song Titles";
            this.loadSongsButton.UseVisualStyleBackColor = true;
            this.loadSongsButton.Click += new System.EventHandler(this.loadSongsButton_Click);
            // 
            // pathSelectorButton
            // 
            this.pathSelectorButton.Location = new System.Drawing.Point(437, 62);
            this.pathSelectorButton.Name = "pathSelectorButton";
            this.pathSelectorButton.Size = new System.Drawing.Size(35, 22);
            this.pathSelectorButton.TabIndex = 14;
            this.pathSelectorButton.Text = ". . .";
            this.pathSelectorButton.UseVisualStyleBackColor = true;
            this.pathSelectorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // songTitlesList
            // 
            this.songTitlesList.FormattingEnabled = true;
            this.songTitlesList.Location = new System.Drawing.Point(15, 142);
            this.songTitlesList.Name = "songTitlesList";
            this.songTitlesList.Size = new System.Drawing.Size(457, 244);
            this.songTitlesList.TabIndex = 15;
            // 
            // selectAllCheckbox
            // 
            this.selectAllCheckbox.AutoSize = true;
            this.selectAllCheckbox.Location = new System.Drawing.Point(402, 125);
            this.selectAllCheckbox.Name = "selectAllCheckbox";
            this.selectAllCheckbox.Size = new System.Drawing.Size(70, 17);
            this.selectAllCheckbox.TabIndex = 16;
            this.selectAllCheckbox.Text = "Select All";
            this.selectAllCheckbox.UseVisualStyleBackColor = true;
            this.selectAllCheckbox.CheckedChanged += new System.EventHandler(this.selectAllCheckbox_CheckedChanged);
            // 
            // downloadVideosButton
            // 
            this.downloadVideosButton.Location = new System.Drawing.Point(15, 393);
            this.downloadVideosButton.Name = "downloadVideosButton";
            this.downloadVideosButton.Size = new System.Drawing.Size(457, 23);
            this.downloadVideosButton.TabIndex = 17;
            this.downloadVideosButton.Text = "Download Videos";
            this.downloadVideosButton.UseVisualStyleBackColor = true;
            this.downloadVideosButton.Click += new System.EventHandler(this.downloadVideosButton_Click);
            // 
            // downloadStatusProgressbar
            // 
            this.downloadStatusProgressbar.Location = new System.Drawing.Point(15, 450);
            this.downloadStatusProgressbar.Name = "downloadStatusProgressbar";
            this.downloadStatusProgressbar.Size = new System.Drawing.Size(457, 23);
            this.downloadStatusProgressbar.TabIndex = 18;
            // 
            // downloadStatusLabel
            // 
            this.downloadStatusLabel.AutoSize = true;
            this.downloadStatusLabel.Location = new System.Drawing.Point(12, 434);
            this.downloadStatusLabel.Name = "downloadStatusLabel";
            this.downloadStatusLabel.Size = new System.Drawing.Size(94, 13);
            this.downloadStatusLabel.TabIndex = 19;
            this.downloadStatusLabel.Text = "Download Status: ";
            // 
            // cboResolution
            // 
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.cboResolution.Location = new System.Drawing.Point(351, 479);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(121, 21);
            this.cboResolution.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 582);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.downloadStatusLabel);
            this.Controls.Add(this.downloadStatusProgressbar);
            this.Controls.Add(this.downloadVideosButton);
            this.Controls.Add(this.selectAllCheckbox);
            this.Controls.Add(this.songTitlesList);
            this.Controls.Add(this.pathSelectorButton);
            this.Controls.Add(this.loadSongsButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dontRenameCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.downloadLinkLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.downloadLinkTextBox);
            this.Name = "MainForm";
            this.Text = "Fairy Downloader";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loadSongsButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button pathSelectorButton;
        private System.Windows.Forms.CheckedListBox songTitlesList;
        private System.Windows.Forms.CheckBox selectAllCheckbox;
        private System.Windows.Forms.Button downloadVideosButton;
        private System.Windows.Forms.ProgressBar downloadStatusProgressbar;
        private System.Windows.Forms.Label downloadStatusLabel;
        private System.Windows.Forms.ComboBox cboResolution;
    }
}

