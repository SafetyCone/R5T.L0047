using System;


namespace R5T.L0047.F000
{
    public class LocalRepositoryContextConstructors : ILocalRepositoryContextConstructors
    {
        #region Infrastructure

        public static ILocalRepositoryContextConstructors Instance { get; } = new LocalRepositoryContextConstructors();


        private LocalRepositoryContextConstructors()
        {
        }

        #endregion
    }
}
