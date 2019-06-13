using dnlib.DotNet;
using dnlib.DotNet.Emit;
using pShieldPluginBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProcessShield.PluginSystem
{
    public static class Framework
    {


        public static List<PluginObject> LoadPlugins()
        {
            string[] dllFileNames = null;
            List<PluginObject> pObject = new List<PluginObject>();
            if (Directory.Exists($"{Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location)}\\plugins"))
            {
                dllFileNames = Directory.GetFiles($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\plugins", "*.dll");

                foreach (var pluginDll in dllFileNames)
                {
                    try
                    {
                        pObject.Add(LocatePlugins(pluginDll));
                    }
                    catch { }
                 
                }
            }
            return pObject;
        }

        private static PluginObject LocatePlugins(string filePath)
        {
            ModuleDefMD module = ModuleDefMD.Load(filePath);
            TypeDef pluginType = null;

            PluginObject p1 = new PluginObject() { FilePath = filePath, AssemblyName = Path.GetFileName(filePath)};

            AssemblyName an = AssemblyName.GetAssemblyName(filePath);
            var load = Assembly.LoadFile(filePath);
            Type[] types = load.GetTypes();

            foreach (Type type in types)
            {
                if (type.IsInterface || type.IsAbstract) continue;
              
                else
                {
                    if (type.GetInterface("IShieldPlugin") != null)
                    {
                        p1.Protection = (IShieldPlugin)Activator.CreateInstance(type);
                                          
                    }

                    if(type.Name == "Log")
                    {
                        //p1.LogCallBack = (Log)Activator.CreateInstance(type);
                    }
                }
            }
            foreach (var t in module.GetTypes())
            {
                if (t.IsInterface || t.IsAbstract) continue;

                if (t.HasInterfaces)
                {
                    if (t.Interfaces[0].Interface.Name == "IShieldPlugin")
                    {
                        pluginType = t;
                        break;
                    }
                }
            }
            foreach (var prop in pluginType.Methods)
            {

                if (prop.Name.Contains("Name"))
                    foreach (var item in prop.Body.Instructions)
                    {
                        if (item.OpCode == OpCodes.Ldstr)
                            p1.Name = item.Operand as string;
                    }

                if (prop.Name.Contains("Description"))
                    foreach (var item in prop.Body.Instructions)
                    {
                        if (item.OpCode == OpCodes.Ldstr)
                            p1.Description = item.Operand as string;
                    }

                if (prop.Name.Contains("Creator"))
                    foreach (var item in prop.Body.Instructions)
                    {
                        if (item.OpCode == OpCodes.Ldstr)
                            p1.Creator = item.Operand as string;
                    }

            }
            return p1;
        }
    }
}
