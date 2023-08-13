using System;
using System.Threading.Tasks;

using R5T.L0039.T000;
using R5T.L0047.T000;
using R5T.T0131;
using R5T.T0187;
using R5T.T0188;


namespace R5T.L0047.O001
{
    [ValuesMarker]
    public partial interface ILocalGitRepositoryContextOperations : IValuesMarker
    {
        public Func<ILocalGitRepositoryContext, Task> Delete_Repository =>
            context => Instances.LocalGitRepositoryContextOperator.Delete_LocalDirectory(context);

        /// <inheritdoc cref="ILocalGitRepositoryContextOperator.Add_GitIgnoreFile(ILocalGitRepositoryContext)"/>
        public Func<ILocalGitRepositoryContext, Task> Add_GitIgnoreFile =>
            context => Instances.LocalGitRepositoryContextOperator.Add_GitIgnoreFile(context);

        public Func<ILocalGitRepositoryContext, Task> In_CommitContext(
            ICommitMessage commitMessage,
            params Func<ILocalGitRepositoryContext, Task>[] operations)
            =>
                context => Instances.LocalGitRepositoryContextOperator.In_CommitContext(
                    context,
                    commitMessage,
                    operations);

        public Func<ILocalGitRepositoryContext, Task> In_SolutionContext(
            ISolutionName solutionName,
            params Func<ISolutionContext, Task>[] solutionContextOperations)
        {
            return Instances.LocalRepositoryContextOperations.In_SolutionContext(
                solutionName,
                solutionContextOperations);
        }
    }
}
