using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Generator
    {
        public static string CodeGenerator()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
