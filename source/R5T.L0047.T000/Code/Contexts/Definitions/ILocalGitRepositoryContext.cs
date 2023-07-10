using System;

using R5T.T0137;
using R5T.T0184;
using R5T.T0200;


namespace R5T.L0047.T000
{
    /// <summary>
    /// Context for local repository operations.
    /// </summary>
    [ContextDefinitionMarker]
    public interface ILocalGitRepositoryContext : IContextDefinitionMarker,
        N001.ILocalRepositoryContext
    {
        public IRepositoryOwnerName OwnerName { get; set; }
        public new ILocalGitRepositoryDirectoryPath DirectoryPath { get; }
    }
}
