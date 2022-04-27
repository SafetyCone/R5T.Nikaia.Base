using System;using R5T.T0064;


namespace R5T.Nikaia
{[ServiceDefinitionMarker]
    public interface IGitExecutableFilePathProvider:IServiceDefinition
    {
        string GetGitExecutableFilePath();
    }
}
