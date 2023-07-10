using System;
using System.Threading.Tasks;

using R5T.L0047.T000;
using R5T.T0132;
using R5T.T0159;
using R5T.T0184;
using R5T.T0200;


namespace R5T.L0047.F000
{
    [FunctionalityMarker]
    public partial interface ILocalRepositoryContextOperator : IFunctionalityMarker
    {
        [Obsolete("Use the other method that requires a repository owner name.")]
        public Task In_LocalRepositoryContext(
            IRepositoryName repositoryName,
            ILocalRepositoryDirectoryPath repositoryDirectoryPath,
            ITextOutput textOutput,
            params Func<ILocalRepositoryContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                () => new LocalRepositoryContext
                {
                    RepositoryName = repositoryName,
                    DirectoryPath = repositoryDirectoryPath,
                    TextOutput = textOutput,
                },
                operations,
                Instances.ActionOperations.DoNothing);
        }

        public Task In_LocalRepositoryContext(
            IRepositoryName repositoryName,
            IRepositoryOwnerName repositoryOwnerName,
            ILocalRepositoryDirectoryPath repositoryDirectoryPath,
            ITextOutput textOutput,
            params Func<ILocalRepositoryContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                Instances.LocalRepositoryContextConstructors.Get_LocalRepositoryContext(
                    repositoryName,
                    repositoryOwnerName,
                    repositoryDirectoryPath,
                    textOutput),
                operations,
                Instances.ActionOperations.DoNothing);
        }

        public Task In_LocalRepositoryContext(
            IRepositoryName repositoryName,
            IRepositoryOwnerName repositoryOwnerName,
            ITextOutput textOutput,
            params Func<ILocalRepositoryContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                Instances.LocalRepositoryContextConstructors.Get_LocalRepositoryContext(
                    repositoryName,
                    repositoryOwnerName,
                    textOutput),
                operations,
                Instances.ActionOperations.DoNothing);
        }
    }
}
