using System;

namespace ASI.ES.SkillUp.FileCopy
{
    /// <summary>
    /// Constants class.
    /// </summary>
    class Constants
    {
        //For console formatting .  
        public const int BufferSize     = 1024;
        public const int LargeFormSize  = 220;
        public const int MediumFormSize = 165;
    }

    /// <summary>
    /// Messages class.
    /// </summary>
    class Messages
    {
        //Store a program definition message
        public const string FolderContainsFile    = "This folder already contains a file named \'";
        public const string WouldYouLikeToReplace = "\'.\nWould you like to replace the existing file?";
        public const string ConfirmFileReplace    = "Confirm File Replace";
        public const string Cancel                = "Cancel";
        public const string Start                 = "Start";
        public const string ProgressStatus        = "Progress Status.";
        public const string Complated             = "% Completed.";
    }
}