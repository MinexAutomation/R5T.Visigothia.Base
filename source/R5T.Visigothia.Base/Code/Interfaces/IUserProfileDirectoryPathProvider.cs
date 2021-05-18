using System;


namespace R5T.Visigothia
{
    /// <summary>
    /// Provide the user directory of the user under which the current environment is running.
    /// For examaple, on Windows, for user David, that directory would be C:\Users\David.
    /// </summary>
    public interface IUserProfileDirectoryPathProvider
    {
        string GetUserProfileDirectoryPath();
    }
}
