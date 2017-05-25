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
            this.songTitlesList = new System.Windows.Forms.ListBox();
            this.renamedSongTitlesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dontRenameCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loadSongsButton = new System.Windows.Forms.Button();
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
            this.destinationTextBox.Size = new System.Drawing.Size(309, 20);
            this.destinationTextBox.TabIndex = 3;
            this.destinationTextBox.Text = "C:\\FairyDownloads";
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
            // songTitlesList
            // 
            this.songTitlesList.FormattingEnabled = true;
            this.songTitlesList.Location = new System.Drawing.Point(10, 141);
            this.songTitlesList.Name = "songTitlesList";
            this.songTitlesList.Size = new System.Drawing.Size(227, 251);
            this.songTitlesList.TabIndex = 5;
            // 
            // renamedSongTitlesList
            // 
            this.renamedSongTitlesList.FormattingEnabled = true;
            this.renamedSongTitlesList.Location = new System.Drawing.Point(243, 141);
            this.renamedSongTitlesList.Name = "renamedSongTitlesList";
            this.renamedSongTitlesList.Size = new System.Drawing.Size(229, 251);
            this.renamedSongTitlesList.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Renamed Song Titles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Options";
            // 
            // dontRenameCheckbox
            // 
            this.dontRenameCheckbox.AutoSize = true;
            this.dontRenameCheckbox.Location = new System.Drawing.Point(15, 432);
            this.dontRenameCheckbox.Name = "dontRenameCheckbox";
            this.dontRenameCheckbox.Size = new System.Drawing.Size(94, 17);
            this.dontRenameCheckbox.TabIndex = 11;
            this.dontRenameCheckbox.Text = "Don\'t Rename";
            this.dontRenameCheckbox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 455);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 582);
            this.Controls.Add(this.loadSongsButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dontRenameCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renamedSongTitlesList);
            this.Controls.Add(this.songTitlesList);
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
        private System.Windows.Forms.ListBox songTitlesList;
        private System.Windows.Forms.ListBox renamedSongTitlesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox dontRenameCheckbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loadSongsButton;
    }
}

