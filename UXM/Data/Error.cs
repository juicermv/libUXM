using System;
using System.IO;

namespace UXM.Data
{
    public class InvalidGameException : Exception
    {
        public InvalidGameException() { }
        public InvalidGameException(string message) : base(message) { }
        public InvalidGameException(string message, Exception inner) : base(message, inner) { }
    };

    public class UnpackStorageException(GameInfo gameInfo, DriveInfo driveInfo) : Exception(
                    $"Not enough free space on drive {driveInfo.Name} to unpack the game. " +
                    $"Required: {gameInfo.RequiredGB} GB, Available: {driveInfo.AvailableFreeSpace / (1024 * 1024 * 1024)} GB")
    { }
}
