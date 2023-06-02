using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0184;
using R5T.T0200;


namespace R5T.L0047.T000
{
    /// <inheritdoc cref="ILocalGitRepositoryContext"/>
    [ContextImplementationMarker]
    public class LocalRepositoryContext : IContextImplementationMarker,
        ILocalRepositoryContext
    {
        public ILocalGitRepositoryDirectoryPath DirectoryPath { get; set; }
        public IRepositoryName RepositoryName { get; set; }

        public ITextOutput TextOutput { get; set; }

        T0200.N001.ILocalRepositoryDirectoryPath N001.ILocalRepositoryContext.DirectoryPath => this.DirectoryPath;
    }
}
