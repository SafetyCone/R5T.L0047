using System;


namespace R5T.L0047.O001
{
    public class LocalGitRepositoryContextOperations : ILocalGitRepositoryContextOperations
    {
        #region Infrastructure

        public static ILocalGitRepositoryContextOperations Instance { get; } = new LocalGitRepositoryContextOperations();


        private LocalGitRepositoryContextOperations()
        {
        }

        #endregion
    }
}
