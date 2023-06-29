using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0039.T000;
using R5T.L0047.T000;
using R5T.T0131;
using R5T.T0187;
using R5T.T0198;
using R5T.T0198.Extensions;


namespace R5T.L0047.O001
{
    [ValuesMarker]
    public partial interface ILocalRepositoryContextOperations : IValuesMarker
    {
        public Func<ILocalRepositoryContext, Task> In_SolutionContext_N001(
            ISolutionName solutionName,
            params Func<L0039.T000.N001.ISolutionContext, Task>[] operations)
            =>
                context => Instances.LocalRepositoryContextOperator.In_SolutionContext_N001(
                    context,
                    solutionName,
                    operations);

        public Func<T000.N001.ILocalRepositoryContext, Task> In_SolutionContext(
            ISolutionName solutionName,
            params Func<ISolutionContext, Task>[] operations)
            =>
                context => Instances.LocalRepositoryContextOperator.In_SolutionContext(
                    context,
                    solutionName,
                    operations);

        public Func<T000.N001.ILocalRepositoryContext, Task> In_NewSolutionContext(
            ISolutionName solutionName,
            params Func<ISolutionContext, Task>[] operations)
            =>
                context => Instances.LocalRepositoryContextOperator.In_SolutionContext(
                    context,
                    solutionName,
                    operations
                        .Prepend(Instances.SolutionContextOperations.Create_New_SolutionFile));

        public Task<IRepositoryUrl> Get_RepositoryUrl(T000.N001.ILocalRepositoryContext context)
        {
            var repositoryUrlString = Instances.GitOperator.GetRepositoryRemoteUrl(
                context.DirectoryPath.Value);

            var repositoryUrl = repositoryUrlString.ToRepositoryUrl();

            return Task.FromResult(repositoryUrl);
        }
    }
}
