using System;


namespace R5T.L0047.O001
{
    public class LocalRepositoryContextOperations : ILocalRepositoryContextOperations
    {
        #region Infrastructure

        public static ILocalRepositoryContextOperations Instance { get; } = new LocalRepositoryContextOperations();


        private LocalRepositoryContextOperations()
        {
        }

        #endregion
    }
}
