
namespace RustBestSpot
{
    partial class Main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageSizeWidth = new System.Windows.Forms.Label();
            this.imageSizeHeight = new System.Windows.Forms.Label();
            this.imageMatches = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.selectIcon = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.findAll = new System.Windows.Forms.Button();
            this.removeMark = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.Label();
            this.bestSpot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(12, 12);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(89, 23);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "Select Map";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.SynchronizingObject = this;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(106, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // imageSizeWidth
            // 
            this.imageSizeWidth.AutoSize = true;
            this.imageSizeWidth.Location = new System.Drawing.Point(107, 18);
            this.imageSizeWidth.Name = "imageSizeWidth";
            this.imageSizeWidth.Size = new System.Drawing.Size(83, 13);
            this.imageSizeWidth.TabIndex = 2;
            this.imageSizeWidth.Text = "imageSizeWidth";
            // 
            // imageSizeHeight
            // 
            this.imageSizeHeight.AutoSize = true;
            this.imageSizeHeight.Location = new System.Drawing.Point(196, 18);
            this.imageSizeHeight.Name = "imageSizeHeight";
            this.imageSizeHeight.Size = new System.Drawing.Size(89, 13);
            this.imageSizeHeight.TabIndex = 3;
            this.imageSizeHeight.Text = " imageSizeHeight";
            // 
            // imageMatches
            // 
            this.imageMatches.AutoSize = true;
            this.imageMatches.Location = new System.Drawing.Point(291, 17);
            this.imageMatches.Name = "imageMatches";
            this.imageMatches.Size = new System.Drawing.Size(13, 13);
            this.imageMatches.TabIndex = 4;
            this.imageMatches.Text = "0";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(11, 185);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(89, 23);
            this.run.TabIndex = 5;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // selectIcon
            // 
            this.selectIcon.Location = new System.Drawing.Point(11, 70);
            this.selectIcon.Name = "selectIcon";
            this.selectIcon.Size = new System.Drawing.Size(89, 23);
            this.selectIcon.TabIndex = 6;
            this.selectIcon.Text = "Select Icon";
            this.selectIcon.UseVisualStyleBackColor = true;
            this.selectIcon.Click += new System.EventHandler(this.selectIcon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // findAll
            // 
            this.findAll.Location = new System.Drawing.Point(11, 41);
            this.findAll.Name = "findAll";
            this.findAll.Size = new System.Drawing.Size(89, 23);
            this.findAll.TabIndex = 8;
            this.findAll.Text = "Find All";
            this.findAll.UseVisualStyleBackColor = true;
            this.findAll.Click += new System.EventHandler(this.findAll_Click);
            // 
            // removeMark
            // 
            this.removeMark.Location = new System.Drawing.Point(310, 13);
            this.removeMark.Name = "removeMark";
            this.removeMark.Size = new System.Drawing.Size(75, 23);
            this.removeMark.TabIndex = 9;
            this.removeMark.Text = "Remove";
            this.removeMark.UseVisualStyleBackColor = true;
            this.removeMark.Click += new System.EventHandler(this.removeMark_Click);
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Location = new System.Drawing.Point(12, 211);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(49, 13);
            this.distance.TabIndex = 10;
            this.distance.Text = "Distance";
            // 
            // bestSpot
            // 
            this.bestSpot.Location = new System.Drawing.Point(11, 228);
            this.bestSpot.Name = "bestSpot";
            this.bestSpot.Size = new System.Drawing.Size(89, 23);
            this.bestSpot.TabIndex = 11;
            this.bestSpot.Text = "Best Spot";
            this.bestSpot.UseVisualStyleBackColor = true;
            this.bestSpot.Click += new System.EventHandler(this.bestSpot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 274);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(88, 23);
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestSpot);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.removeMark);
            this.Controls.Add(this.findAll);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.selectIcon);
            this.Controls.Add(this.run);
            this.Controls.Add(this.imageMatches);
            this.Controls.Add(this.imageSizeHeight);
            this.Controls.Add(this.imageSizeWidth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectImage);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.IO.FileSystemWatcher fileWatcher;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imageSizeHeight;
        private System.Windows.Forms.Label imageSizeWidth;
        private System.Windows.Forms.Label imageMatches;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button selectIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button findAll;
        private System.Windows.Forms.Button removeMark;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Button bestSpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label label2;
    }
}

