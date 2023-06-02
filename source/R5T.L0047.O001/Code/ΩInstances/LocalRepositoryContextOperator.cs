using System;


namespace R5T.L0047.O001
{
    public class LocalRepositoryContextOperator : ILocalRepositoryContextOperator
    {
        #region Infrastructure

        public static ILocalRepositoryContextOperator Instance { get; } = new LocalRepositoryContextOperator();


        private LocalRepositoryContextOperator()
        {
        }

        #endregion
    }
}
