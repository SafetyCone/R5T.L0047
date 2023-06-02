using System;


namespace R5T.L0047.F000
{
    public static class Instances
    {
        public static F0000.IActionOperations ActionOperations => F0000.ActionOperations.Instance;
        public static L0031.IContextOperator ContextOperator => L0031.ContextOperator.Instance;
        public static F0041.IDirectoryPathOperator DirectoryPathOperator => F0041.DirectoryPathOperator.Instance;
    }
}