using System;

namespace d
{
    internal class DllImportAttribute : Attribute
    {
        private string v;
        private string entryPoint;

        public DllImportAttribute(string v)
        {
            this.v = v;
        }

        public DllImportAttribute(string v, string EntryPoint)
        {
            this.v = v;
            entryPoint = EntryPoint;
        }

        public bool SetLastError { get; set; }
    }
}