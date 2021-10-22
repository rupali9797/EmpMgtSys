using System;

namespace EmpMgtSys.Models
{
    internal class foreignkeyAttribute : Attribute
    {
        private string v;

        public foreignkeyAttribute(string v)
        {
            this.v = v;
        }
    }
}