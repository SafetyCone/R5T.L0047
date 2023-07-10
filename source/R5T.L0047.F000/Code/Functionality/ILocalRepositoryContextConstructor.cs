using System;

using R5T.T0132;
using R5T.T0159;
using R5T.T0184;
using R5T.T0200;
using R5T.T0200.Extensions;

using R5T.L0047.T000;


namespace R5T.L0047.F000
{
    [FunctionalityMarker]
    public partial interface ILocalRepositoryContextConstructor : IFunctionalityMarker
    {
        /// <summary>
        /// Get the most derived type in the local repository context chain for use.
        /// Methods operating on the type will operation on less derived tyeps in the local repository context chain.
        /// </summary>
        public ILocalRepositoryContext Get_LocalRepositoryContext(
            IRepositoryName repositoryName,
            IRepositoryOwnerName ownerName,
            ILocalRepositoryDirectoryPath localRepositoryDirectoryPath,
            ITextOutput textOutput)
        {
            var output = new LocalRepositoryContext
            {
                DirectoryPath = localRepositoryDirectoryPath,
                OwnerName = ownerName,
                RepositoryName = repositoryName,
                TextOutput = textOutput,
            };

            return output;
        }

        public ILocalRepositoryContext Get_LocalRepositoryContext(
            IRepositoryName repositoryName,
            IRepositoryOwnerName ownerName, 
            ITextOutput textOutput)
        {
            var localRepositoryDirectoryPath = Instances.DirectoryPathOperator.GetLocalRepositoryDirectoryPath(
                repositoryName.Value,
                ownerName.Value)
                .ToLocalRepositoryDirectoryPath();

            var output = this.Get_LocalRepositoryContext(
                repositoryName,
                ownerName,
                localRepositoryDirectoryPath,
                textOutput);

            return output;
        }
    }
}
