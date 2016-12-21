using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace ASI.ES.SkillUp.FileCopy
{
    /// <summary>
    /// FileCopy class.
    /// </summary>
    public partial class FileCopy : Form
    {
        /// <summary>
        /// FileCopy constructor.
        /// </summary>
        public FileCopy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// buttonFile_Click event.
        /// </summary>
        private void buttonFile_Click(object sender, EventArgs e)
        {
            DialogResult objDialogResult = openFileDialogSourceFile.ShowDialog();
            if (objDialogResult == DialogResult.OK)
            {
                textBoxSource.Text = openFileDialogSourceFile.FileName;
            }
        }

        /// <summary>
        /// buttonFolder_Click event.
        /// </summary>
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            DialogResult objDialogResult = folderBrowserDialogDestinationPath.ShowDialog();
            if (objDialogResult == DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialogDestinationPath.SelectedPath;
            }
        }

        /// <summary>
        /// textBoxDestination_TextChanged event.
        /// </summary>
        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDestination.Text) &&
                !string.IsNullOrEmpty(textBoxSource.Text))
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        /// <summary>
        /// textBoxSource_TextChanged event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDestination.Text) &&
                !string.IsNullOrEmpty(textBoxSource.Text))
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        /// <summary>
        /// buttonStart_Click event.
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorkerFileCopy.IsBusy)
                {
                    backgroundWorkerFileCopy.CancelAsync();
                    return;
                }
                else
                {
                    backgroundWorkerFileCopy.RunWorkerAsync();
                    SetForm();
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message, ErrorMessages.Tag, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// SetForm method.
        /// </summary>
        private void SetForm()
        {
            try
            {
                FileCopy.ActiveForm.Height = Constants.LargeFormSize;
                buttonStart.Text = Messages.Cancel;

                textBoxSource.Enabled = false;
                textBoxDestination.Enabled = false;
                buttonFile.Enabled = false;
                buttonFolder.Enabled = false;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message, ErrorMessages.Tag, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ResetForm method.
        /// </summary>
        private void ResetForm()
        {
            try
            {
                buttonStart.Text = Messages.Start;
                FileCopy.ActiveForm.Height = Constants.MediumFormSize;
                progressBarFileCopy.Value = 0;
                labelProgressStatus.Text = Messages.ProgressStatus;

                textBoxSource.Enabled = true;
                textBoxDestination.Enabled = true;
                buttonFile.Enabled = true;
                buttonFolder.Enabled = true;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message, ErrorMessages.Tag, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// backgroundWorker1_DoWork event.
        /// </summary>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ErrorCodes objErrorCode = CopyFile(textBoxSource.Text, textBoxDestination.Text);
                if (objErrorCode != ErrorCodes.Success)
                {
                    MessageBox.Show(Errors.GetErrorMessage(objErrorCode), ErrorMessages.Tag, MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        /// <summary>
        /// backgroundWorker1_ProgressChanged event.
        /// </summary>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBarFileCopy.Value = e.ProgressPercentage;
                labelProgressStatus.Text = e.ProgressPercentage + Messages.Complated;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        /// <summary>
        /// backgroundWorker1_RunWorkerCompleted
        /// </summary>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                ResetForm();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message, ErrorMessages.Tag, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// CopyFile Method.
        /// </summary>
        /// <param name="sFilePath">String type, source file path</param>
        /// <param name="sDestinationDirectoryPath">String type, directory path</param>
        /// <returns>ErrorCodes type, error code</returns>
        private ErrorCodes CopyFile(string sFilePath, string sDestinationDirectoryPath)
        {
            //Check for given source folder path and destination is null or empty.
            if (string.IsNullOrEmpty(sFilePath) == true || string.IsNullOrEmpty(sDestinationDirectoryPath) == true)
            {
                return ErrorCodes.CopyFileFunctionFail;
            }

            //Check for file is exists or not.
            if (File.Exists(sFilePath) == false)
            {
                return ErrorCodes.SourceFileNotFound;
            }

            //Check for destination folder is exists or not.
            if (Directory.Exists(sDestinationDirectoryPath) == false)
            {
                return ErrorCodes.DestinationDirectoryNotFound;
            }
            try
            {
                //For create file name in destination folder.eg.path + Fetch current directory from path + extension
                string sFileName = sDestinationDirectoryPath + Path.DirectorySeparatorChar + Path.GetFileName(sFilePath);
                if (File.Exists(sFileName))
                {
                    DialogResult objDialogResult = MessageBox.Show(Messages.FolderContainsFile + Path.GetFileName(sFileName) +
                                                                   Messages.WouldYouLikeToReplace, Messages.ConfirmFileReplace,
                                                                   MessageBoxButtons.YesNo);
                    if (objDialogResult == DialogResult.No)
                    {
                        return ErrorCodes.Success;
                    }
                    else
                    {
                        File.Delete(sFileName);
                    }
                }
                byte[] btaryBuffer = new byte[Constants.BufferSize];

                //Open destination file in write mode.
                using (BinaryWriter objBinaryWriter = new BinaryWriter(File.OpenWrite(sFileName)))
                {
                    using (BinaryReader objBinaryReader = new BinaryReader(File.OpenRead(sFilePath)))
                    {
                        int nbytesRead = 0;
                        long nFileSize = new FileInfo(sFilePath).Length;
                        int nCurrentPosition = 1;
                        double nTotalPercentage;
                        do
                        {
                            if (backgroundWorkerFileCopy.CancellationPending)
                            {
                                objBinaryReader.Close();
                                objBinaryWriter.Close();
                                objBinaryReader.Dispose();
                                objBinaryWriter.Dispose();
                                File.Delete(sFileName);
                                return ErrorCodes.Success;
                            }
                            //Read total bytes and store in destination file.
                            nbytesRead = objBinaryReader.Read(btaryBuffer, 0, (int)Constants.BufferSize);
                            objBinaryWriter.Write(btaryBuffer, 0, nbytesRead);

                            nCurrentPosition += nbytesRead;
                            nTotalPercentage = nCurrentPosition / (double)nFileSize;
                            nTotalPercentage = nTotalPercentage * 100;

                            backgroundWorkerFileCopy.ReportProgress((int)nTotalPercentage);
                        } while (nbytesRead != 0);
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                return ErrorCodes.DestinationDirectoryNotFound;
            }
            catch (FileNotFoundException)
            {
                return ErrorCodes.SourceFileNotFound;
            }
            catch (IOException)
            {
                return ErrorCodes.IOException;
            }
            catch (ArgumentException)
            {
                return ErrorCodes.InvalidArgument;
            }
            catch (Exception)
            {
                return ErrorCodes.CopyFileFunctionFail;
            }
            return ErrorCodes.Success;
        }

        /// <summary>
        /// FileCopy_FormClosing event.
        /// </summary>
        private void FileCopy_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorkerFileCopy.CancelAsync();
        }
    }
}