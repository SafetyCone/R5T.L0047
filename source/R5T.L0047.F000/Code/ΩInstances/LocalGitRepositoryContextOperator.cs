using System;


namespace R5T.L0047.F000
{
    public class LocalGitRepositoryContextOperator : ILocalGitRepositoryContextOperator
    {
        #region Infrastructure

        public static ILocalGitRepositoryContextOperator Instance { get; } = new LocalGitRepositoryContextOperator();


        private LocalGitRepositoryContextOperator()
        {
        }

        #endregion
    }
}
