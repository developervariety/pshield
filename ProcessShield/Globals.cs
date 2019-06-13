using dnlib.DotNet;
using ProcessShield.PluginSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessShield
{
    public static class Globals
    {
        public static List<PluginObject> _Plugins = new List<PluginObject>();
        public static List<PluginObject> _ActivePlugins = new List<PluginObject>();


        public static ModuleDefMD _Module { get; set; } 
        public static string _Output { get; set; }
    }
}
