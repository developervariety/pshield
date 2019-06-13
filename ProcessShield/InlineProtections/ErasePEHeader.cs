using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessShield.InlineProtections
{
    class ErasePEHeader
    {
        private static List<int> byteList = new List<int>();

        //credits: gigajew hf.
        public static void Run()
        {
            var array = new byte[5];
            Nop(ref array);
            using (var fileStream = new FileStream(Globals._Output, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                fileStream.Seek(30L, SeekOrigin.Begin);
                fileStream.Write(array, 0, array.Length);
                array = new byte[18];
                Nop(ref array);
                fileStream.Seek(42L, SeekOrigin.Begin);
                fileStream.Write(array, 0, array.Length);
                array = new byte[38];
                Nop(ref array);
                fileStream.Seek(78L, SeekOrigin.Begin);
                fileStream.Write(array, 0, array.Length);
                fileStream.Flush();
            }
        }

        private static void Nop(ref byte[] buffer)
        {
            for (var i = 0; i < buffer.Length; i++) buffer[i] = 144;
        }


        public static bool Verify()
        {

            using (var fileStream = new FileStream(Globals._Output, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                fileStream.Seek(30L, SeekOrigin.Begin);
                byteList.Add(fileStream.ReadByte());
                fileStream.Seek(42L, SeekOrigin.Begin);
                byteList.Add(fileStream.ReadByte());
                fileStream.Seek(78L, SeekOrigin.Begin);
                byteList.Add(fileStream.ReadByte());
                fileStream.Flush();
            }

            foreach (var item in byteList)
            {
                if (item != 144)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

