using System;

using R5T.T0137;


namespace R5T.L0047.T000.N001
{
    /// <summary>
    /// Context for local repository operations.
    /// </summary>
    [ContextDefinitionMarker]
    public interface ILocalRepositoryContext : IContextDefinitionMarker,
        L0042.T000.IRepositoryContext
    {
        public T0200.N001.ILocalRepositoryDirectoryPath DirectoryPath { get; }
    }
}
