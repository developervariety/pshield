using dnlib.DotNet;
using pShieldPluginBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessShield.PluginSystem
{

    public class PluginObject
    {
    
        public string Name { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }

        public string FilePath { get; set; }
        public string AssemblyName { get; set; }

        public IShieldPlugin Protection { get; set; }

        public Log LogCallBack { get; set; }

    }
}
