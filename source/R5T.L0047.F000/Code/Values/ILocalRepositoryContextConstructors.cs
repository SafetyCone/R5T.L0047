using System;

using R5T.T0131;
using R5T.T0159;
using R5T.T0184;
using R5T.T0200;

using R5T.L0047.T000;


namespace R5T.L0047.F000
{
    [ValuesMarker]
    public partial interface ILocalRepositoryContextConstructors : IValuesMarker
    {
        public Func<ILocalRepositoryContext> Get_LocalRepositoryContext(
            IRepositoryName repositoryName,
            IRepositoryOwnerName ownerName,
            ILocalRepositoryDirectoryPath localRepositoryDirectoryPath,
            ITextOutput textOutput)
        {
            return () => Instances.LocalRepositoryContextConstructor.Get_LocalRepositoryContext(
                repositoryName,
                ownerName,
                localRepositoryDirectoryPath,
                textOutput);
        }

        public Func<ILocalRepositoryContext> Get_LocalRepositoryContext(
            IRepositoryName repositoryName,
            IRepositoryOwnerName ownerName,
            ITextOutput textOutput)
        {
            return () => Instances.LocalRepositoryContextConstructor.Get_LocalRepositoryContext(
                repositoryName,
                ownerName,
                textOutput);
        }
    }
}
