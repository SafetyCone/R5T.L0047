using System;
using System.Threading.Tasks;

using R5T.L0047.T000;
using R5T.T0132;
using R5T.T0188;


namespace R5T.L0047.O001
{
    [FunctionalityMarker]
    public partial interface ILocalGitRepositoryContextOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="F0042.F002.IRepositoryFilesOperator.Set_GitIgnoreFile(string)"/>
        public Task Add_GitIgnoreFile(ILocalGitRepositoryContext context)
        {
            context.TextOutput.WriteInformation("Adding gitignore file...");

            Instances.RepositoryFilesOperator.Set_GitIgnoreFile(
                context.DirectoryPath.Value);

            return Task.CompletedTask;
        }

        public Task Delete_LocalDirectory(ILocalGitRepositoryContext context)
        {
            context.TextOutput.WriteInformation("Deleting local Git repository...");

            Instances.LocalRepositoryOperator.Delete(
                context.DirectoryPath.Value);

            return Task.CompletedTask;
        }

        public async Task In_CommitContext<TLocalGitHubRepsitoryContext>(
            TLocalGitHubRepsitoryContext context,
            ICommitMessage commitMessage,
            params Func<TLocalGitHubRepsitoryContext, Task>[] operations)
            where TLocalGitHubRepsitoryContext : ILocalGitRepositoryContext
        {
            context.TextOutput.WriteInformation($"In commit context:\n\t{commitMessage}");

            await Instances.ActionOperator.Run(
                context,
                operations);

            Instances.GitHubOperator.PushAllChanges(
                context.DirectoryPath.Value,
                commitMessage.Value,
                Instances.LoggingOperator.Get_NullLogger());

            context.TextOutput.WriteInformation($"Commited changes:\n\t{commitMessage}");
        }
    }
}
