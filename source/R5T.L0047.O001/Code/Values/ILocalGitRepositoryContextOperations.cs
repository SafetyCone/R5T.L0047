using System;
using System.Threading.Tasks;

using R5T.L0047.T000;
using R5T.T0131;
using R5T.T0188;


namespace R5T.L0047.O001
{
    [ValuesMarker]
    public partial interface ILocalGitRepositoryContextOperations : IValuesMarker
    {
        public Func<ILocalGitRepositoryContext, Task> Delete_Repository =>
            context => Instances.LocalGitRepositoryContextOperator.Delete_LocalDirectory(context);

        public Func<ILocalGitRepositoryContext, Task> Add_GitIgnoreFile =>
            context => Instances.LocalGitRepositoryContextOperator.Add_GitIgnoreFile(context);

        public delegate Func<ILocalGitRepositoryContext, Task> In_CommitContext_Params(
            ICommitMessage commitMessage,
            params Func<ILocalGitRepositoryContext, Task>[] operations);

        public In_CommitContext_Params In_CommitContext =>
            (commitMessage, operations) =>
                context => Instances.LocalGitRepositoryContextOperator.In_CommitContext(
                    context,
                    commitMessage,
                    operations);
    }
}
