namespace ASI.ES.SkillUp.FileCopy
{
    partial class FileCopy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileCopy));
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.progressBarFileCopy = new System.Windows.Forms.ProgressBar();
            this.labelProgressStatus = new System.Windows.Forms.Label();
            this.backgroundWorkerFileCopy = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogDestinationPath = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.Location = new System.Drawing.Point(81, 63);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(405, 22);
            this.textBoxDestination.TabIndex = 45;
            this.textBoxDestination.TextChanged += new System.EventHandler(this.textBoxDestination_TextChanged);
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFolder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFolder.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFolder.Location = new System.Drawing.Point(495, 61);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(90, 27);
            this.buttonFolder.TabIndex = 44;
            this.buttonFolder.Text = "Folder...";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSource.Location = new System.Drawing.Point(81, 26);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(405, 22);
            this.textBoxSource.TabIndex = 43;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // buttonFile
            // 
            this.buttonFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFile.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonFile.Location = new System.Drawing.Point(494, 23);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(90, 27);
            this.buttonFile.TabIndex = 42;
            this.buttonFile.Text = "File...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonStart.Location = new System.Drawing.Point(254, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(86, 27);
            this.buttonStart.TabIndex = 46;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.BackColor = System.Drawing.Color.Transparent;
            this.labelSource.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelSource.Location = new System.Drawing.Point(6, 29);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(50, 15);
            this.labelSource.TabIndex = 47;
            this.labelSource.Text = "Source :";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.BackColor = System.Drawing.Color.Transparent;
            this.labelDestination.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelDestination.Location = new System.Drawing.Point(6, 67);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(75, 15);
            this.labelDestination.TabIndex = 48;
            this.labelDestination.Text = "Destination :";
            // 
            // progressBarFileCopy
            // 
            this.progressBarFileCopy.Location = new System.Drawing.Point(11, 136);
            this.progressBarFileCopy.Name = "progressBarFileCopy";
            this.progressBarFileCopy.Size = new System.Drawing.Size(573, 27);
            this.progressBarFileCopy.TabIndex = 49;
            // 
            // labelProgressStatus
            // 
            this.labelProgressStatus.AutoSize = true;
            this.labelProgressStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelProgressStatus.Location = new System.Drawing.Point(8, 164);
            this.labelProgressStatus.Name = "labelProgressStatus";
            this.labelProgressStatus.Size = new System.Drawing.Size(95, 15);
            this.labelProgressStatus.TabIndex = 50;
            this.labelProgressStatus.Text = "Progress Status.";
            // 
            // backgroundWorkerFileCopy
            // 
            this.backgroundWorkerFileCopy.WorkerReportsProgress = true;
            this.backgroundWorkerFileCopy.WorkerSupportsCancellation = true;
            this.backgroundWorkerFileCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerFileCopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorkerFileCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "images.jpg");
            this.imageList2.Images.SetKeyName(1, "14.ico");
            this.imageList2.Images.SetKeyName(2, "1.ico");
            this.imageList2.Images.SetKeyName(3, "2.ico");
            this.imageList2.Images.SetKeyName(4, "3.ico");
            this.imageList2.Images.SetKeyName(5, "4.ico");
            this.imageList2.Images.SetKeyName(6, "5.ico");
            this.imageList2.Images.SetKeyName(7, "6.ico");
            this.imageList2.Images.SetKeyName(8, "7.ico");
            this.imageList2.Images.SetKeyName(9, "8.ico");
            this.imageList2.Images.SetKeyName(10, "9.ico");
            this.imageList2.Images.SetKeyName(11, "10.ico");
            this.imageList2.Images.SetKeyName(12, "11.ico");
            this.imageList2.Images.SetKeyName(13, "12.ico");
            this.imageList2.Images.SetKeyName(14, "13.ico");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FileCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 133);
            this.Controls.Add(this.labelProgressStatus);
            this.Controls.Add(this.progressBarFileCopy);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.buttonFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileCopy";
            this.Text = "FileCopy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileCopy_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.ProgressBar progressBarFileCopy;
        private System.Windows.Forms.Label labelProgressStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFileCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialogSourceFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestinationPath;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

