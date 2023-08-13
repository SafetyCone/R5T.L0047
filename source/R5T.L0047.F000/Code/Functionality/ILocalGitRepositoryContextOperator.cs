using System;
using System.Threading.Tasks;

using R5T.L0047.T000;
using R5T.T0132;
using R5T.T0186;
using R5T.T0200.Extensions;


namespace R5T.L0047.F000
{
    [FunctionalityMarker]
    public partial interface ILocalGitRepositoryContextOperator : IFunctionalityMarker
    {
        public Task In_LocalGitRepositoryContext(
            IGitHubRepositoryName repositoryName,
            IGitHubRepositoryOwnerName ownerName,
            params Func<ILocalGitRepositoryContext, Task>[] operations)
        {
            var localRepositoryDirectoryPath = Instances.DirectoryPathOperator.GetLocalRepositoryDirectoryPath(
                repositoryName.Value,
                ownerName.Value)
                .ToLocalRepositoryDirectoryPath();

            return Instances.ContextOperator.In_Context(
                () => new LocalGitRepositoryContext
                {
                    DirectoryPath = localRepositoryDirectoryPath,
                    OwnerName = ownerName,
                    RepositoryName = repositoryName,
                },
                operations,
                context => Instances.ActionOperations.DoNothing_Synchronous(context));
        }

        public Task In_LocalGitRepositoryContext(
            L0042.T000.IRepositoryContext repositoryContext,
            IGitHubRepositoryName repositoryName,
            IGitHubRepositoryOwnerName ownerName,
            params Func<ILocalGitRepositoryContext, Task>[] operations)
        {
            var localRepositoryDirectoryPath = Instances.DirectoryPathOperator.GetLocalRepositoryDirectoryPath(
                repositoryName.Value,
                ownerName.Value)
                .ToLocalRepositoryDirectoryPath();

            return Instances.ContextOperator.In_Context(
                () => new LocalGitRepositoryContext
                {
                    DirectoryPath = localRepositoryDirectoryPath,
                    OwnerName = ownerName,
                    RepositoryName = repositoryName,
                    TextOutput = repositoryContext.TextOutput,
                },
                operations,
                context => Instances.ActionOperations.DoNothing_Synchronous(context));
        }
    }
}
