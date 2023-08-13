using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibGit2Sharp;
using R5T.L0039.T000;
using R5T.L0047.T000;
using R5T.T0132;
using R5T.T0172.Extensions;
using R5T.T0187;


namespace R5T.L0047.O001
{
    [FunctionalityMarker]
    public partial interface ILocalRepositoryContextOperator : IFunctionalityMarker
    {
        public async Task In_SolutionContext_N001(
            ILocalRepositoryContext localGitRepositoryContext,
            ISolutionName solutionName,
            params Func<L0039.T000.N001.ISolutionContext, Task>[] operations)
        {
            var solutionDirectoryPath = Instances.RepositoryPathsOperator.GetSourceDirectoryPath(
                localGitRepositoryContext.DirectoryPath.Value)
                .ToSolutionDirectoryPath();

            var solutionContext = new L0039.T000.N001.SolutionContext
            {
                SolutionName = solutionName,
                DirectoryPath = solutionDirectoryPath,
            };

            await Instances.ActionOperator.Run(
                solutionContext,
                operations);
        }

        public async Task In_SolutionContext(
            L0047.T000.N001.ILocalRepositoryContext localRepositoryContext,
            ISolutionName solutionName,
            IEnumerable<Func<ISolutionContext, Task>> operations)
        {
            var solutionDirectoryPath = Instances.RepositoryPathsOperator.GetSourceDirectoryPath(
                localRepositoryContext.DirectoryPath.Value)
                .ToSolutionDirectoryPath();

            var solutionFilePath = Instances.SolutionPathsOperator.Get_SolutionFilePath(
                solutionDirectoryPath,
                solutionName);

            var solutionContext = new SolutionContext
            {
                SolutionName = solutionName,
                SolutionFilePath = solutionFilePath,
                TextOutput = localRepositoryContext.TextOutput,
            };

            await Instances.ActionOperator.Run(
                solutionContext,
                operations);
        }

        public Task In_SolutionContext(
            ILocalRepositoryContext localRepositoryContext,
            ISolutionName solutionName,
            params Func<ISolutionContext, Task>[] operations)
        {
            return this.In_SolutionContext(
                localRepositoryContext,
                solutionName,
                operations.AsEnumerable());
        }
    }
}
