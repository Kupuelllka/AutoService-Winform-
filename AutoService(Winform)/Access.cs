using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService_Winform_
{
    public static class Access
    {
        static int access;
        public static int Acces { get { return access; } set => Access.access = value; }
    }
}
