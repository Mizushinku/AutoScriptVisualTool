using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoScriptVisualTool
{
    class Cipher
    {
        private static byte[] pseudoKey;
        private static void pseudoRandom(char key, ref byte[] pseudoKey)
        {
            pseudoKey[0] = (byte)key;
            for (int i = 1; i < pseudoKey.Length; i++)
            {
                byte b = pseudoKey[i - 1];
                byte bnew = (byte)((b * 7) % 255);
                pseudoKey[i] = bnew;
            }
        }
        private static void encrypt(ref byte[] plan, ref byte[] cipher, ref byte[] key)
        {
            for (int i = 0; i < plan.Length; i++)
            {
                cipher[i] = (byte)(plan[i] ^ key[i]);
            }
        }

        private static void decrypt(ref byte[] cipher, ref byte[] plan, ref byte[] key)
        {
            for (int i = 0; i < cipher.Length; i++)
            {
                plan[i] = (byte)(cipher[i] ^ key[i]);
            }

        }
        public static void encode(String input, String output,char key)
        {
            FileStream fin = new FileStream(input, FileMode.Open);
            BinaryReader br = new BinaryReader(fin);
            long fsize = br.BaseStream.Length;
            byte[] buffer = new byte[fsize];
            byte[] cipher = new byte[fsize];
            pseudoKey = new byte[fsize];
            pseudoRandom(key, ref pseudoKey);
            buffer = br.ReadBytes((int)fsize);
            encrypt(ref buffer, ref cipher, ref pseudoKey);
            fin.Close();
            FileStream fout = new FileStream(output, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fout);
            bw.Write(cipher);
            bw.Flush();
            bw.Close();
            fout.Close();
        }
        public static void decode(string input, string output, char Key)
        {
            FileStream file = new FileStream(input, FileMode.Open);
            BinaryReader br = new BinaryReader(file);
            long fsize = br.BaseStream.Length;
            byte[] plan = new byte[fsize];
            byte[] buf = new byte[fsize];
            pseudoKey = new byte[fsize];
            buf = br.ReadBytes((int)fsize);
            //char key = (char)0x8C;
            pseudoRandom(Key, ref pseudoKey);
            decrypt(ref buf, ref plan, ref pseudoKey);
            file.Close();
            FileStream fout = new FileStream(output, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fout);
            bw.Write(plan);
            bw.Flush();
            bw.Close();
            fout.Close();
        }
        /*
        static void Main(string[] args)
        {
            encode("test.txt", "test.txt",(char)0X8C);
            //decode("test.txt", "test.txt", (char)0X8C);                                
        }
        */
    }
}
