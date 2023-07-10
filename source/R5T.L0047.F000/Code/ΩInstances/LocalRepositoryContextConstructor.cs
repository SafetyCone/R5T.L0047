using System;


namespace R5T.L0047.F000
{
    public class LocalRepositoryContextConstructor : ILocalRepositoryContextConstructor
    {
        #region Infrastructure

        public static ILocalRepositoryContextConstructor Instance { get; } = new LocalRepositoryContextConstructor();


        private LocalRepositoryContextConstructor()
        {
        }

        #endregion
    }
}
