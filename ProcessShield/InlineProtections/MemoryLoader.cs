using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessShield.InlineProtections
{
    public static class MemoryLoader
    {
        public static byte[] sByte = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 3, 34, 77, 89 ,18};


        public static List<byte> obfByte = new List<byte>();

        private static Random _rand = new Random();

        public static ModuleDefMD Create(ModuleDefMD mAssembly)
        {
            ModuleDefMD resourceLoader = ModuleDefMD.Load(Properties.Resources.TestRun);
            ModuleDefMD obfAssembly = mAssembly;

            string resourceName = RandomUtf8String(_rand.Next(6, 18));
            byte randByte = sByte[_rand.Next(0, (sByte.Length - 1))];

            byte[] resourceData = Compress(File.ReadAllBytes(obfAssembly.Location), randByte);
            resourceLoader.Resources.Add(new EmbeddedResource(resourceName, resourceData,
                            ManifestResourceAttributes.Public));

            string f3 = "My.Resource";
            foreach (var t in resourceLoader.GetTypes())
            {
                foreach (var meth in t.Methods)
                {
                    foreach (var e in meth.Body.Instructions)
                    {
                        if (e.OpCode == OpCodes.Ldc_I4_S)
                        {
                            if (e.Operand.ToString() == "18")
                            {
                                e.Operand = randByte;
                                Console.WriteLine(randByte);
                                Console.WriteLine(e);
                            }
                        }
                        else if (e.OpCode == OpCodes.Ldstr)
                        {
                            if ((e.Operand as string) == f3)
                            {
                                e.Operand = resourceName;
                                Console.WriteLine(e);
                            }
                        }
                    }
                }

            }

            return resourceLoader;
        }

        public static string RandomUtf8String(int length)
        {
            string[] chars = Properties.Resources.utf8.Split(' ');

            StringBuilder randomString = new StringBuilder();

            for (int i = 0; i < length; i++)
                randomString.Append(chars[_rand.Next(chars.Length)]);

            return randomString.ToString();
        }

        public static byte[] Compress(byte[] raw, byte randByte)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                    CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }

                foreach (var item in memory.ToArray())
                {
                    obfByte.Add(Convert.ToByte(item ^ randByte));
                }

                return obfByte.ToArray();
                //  return memory.ToArray();
            }
        }

    }

}

