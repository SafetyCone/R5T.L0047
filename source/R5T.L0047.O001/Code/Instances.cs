using System;


namespace R5T.L0047.O001
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static F0041.IGitHubOperator GitHubOperator => F0041.GitHubOperator.Instance;
        public static F0019.IGitOperator GitOperator => F0019.GitOperator.Instance;
        public static ILocalGitRepositoryContextOperator LocalGitRepositoryContextOperator => O001.LocalGitRepositoryContextOperator.Instance;
        public static ILocalRepositoryContextOperator LocalRepositoryContextOperator => O001.LocalRepositoryContextOperator.Instance;
        public static F0042.ILocalRepositoryOperator LocalRepositoryOperator => F0042.LocalRepositoryOperator.Instance;
        public static F0059.ILoggingOperator LoggingOperator => F0059.LoggingOperator.Instance;
        public static F0042.F002.IRepositoryFilesOperator RepositoryFilesOperator => F0042.F002.RepositoryFilesOperator.Instance;
        public static F0057.IRepositoryPathsOperator RepositoryPathsOperator => F0057.RepositoryPathsOperator.Instance;
        public static L0039.O000.ISolutionContextOperations SolutionContextOperations => L0039.O000.SolutionContextOperations.Instance;
        public static F0129.ISolutionPathsOperator SolutionPathsOperator => F0129.SolutionPathsOperator.Instance;
    }
}