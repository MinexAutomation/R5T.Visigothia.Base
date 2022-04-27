using System;

using R5T.T0064;


namespace R5T.Visigothia
{
    /// <summary>
    /// Provide the user directory of the user under which the current environment is running.
    /// For examaple, on Windows, for user David, that directory would be C:\Users\David.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IUserProfileDirectoryPathProvider : IServiceDefinition
    {
        string GetUserProfileDirectoryPath();
    }
}
