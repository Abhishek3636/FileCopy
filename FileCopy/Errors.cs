using System;
using System.Collections.Generic;

namespace ASI.ES.SkillUp.FileCopy
{
    /// <summary>
    /// Store error codes.
    /// </summary>
    enum ErrorCodes
    {
        Success      = 0,
        IOException  = 1,
        InvalidArgument = 2,
        SourceFileNotFound = 3,
        CopyFileFunctionFail = 4,
        DestinationDirectoryNotFound = 5,
    }

    /// <summary>
    /// Error messages.
    /// </summary>
    class ErrorMessages
    {
        //Store a exception message
        public const string Tag                          = "Error";
        public const string InvalidArgument              = "Invalid argument.";
        public const string IOException                  = "I/O exception occurred.";
        public const string SuccessFulComplete           = "Successful complete.";
        public const string CopyFileFuctionFail          = "Copy file function fail.";
        public const string InvalidErrorCode             = "Invalid error code.";
        public const string DestinationDirectoryNotFound = "Destination directory not found.";
        public const string SourceFileNotFound           = "Source file not found.";
    }

    /// <summary>
    /// Errors class.
    /// </summary>
    class Errors
    {
        /// <summary>
        /// For get error message by using error code.
        /// </summary>
        /// <param name="eErrorCode">Integer type,error code</param>
        /// <returns>String type, error message</returns>
        public static string GetErrorMessage(ErrorCodes eErrorCode)
        {
            //Return error message.
            switch (eErrorCode)
            {
                case ErrorCodes.InvalidArgument:
                    {
                        return ErrorMessages.InvalidArgument;
                    }
                case ErrorCodes.CopyFileFunctionFail:
                    {
                        return ErrorMessages.CopyFileFuctionFail;
                    }
                case ErrorCodes.DestinationDirectoryNotFound:
                    {
                        return ErrorMessages.DestinationDirectoryNotFound;
                    }
                case ErrorCodes.SourceFileNotFound:
                    {
                        return ErrorMessages.SourceFileNotFound;
                    }
                case ErrorCodes.IOException:
                    {
                        return ErrorMessages.IOException;
                    }
                case ErrorCodes.Success:
                    {
                        return ErrorMessages.SuccessFulComplete;
                    }
                default:
                    {
                        return ErrorMessages.InvalidErrorCode;
                    }
            }
        }
    }
}
