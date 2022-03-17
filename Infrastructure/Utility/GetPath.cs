using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class GetPath
    {
        public static string ReturnPath(string value)
        {
            return Path.GetExtension(value);
        }
    }
}
