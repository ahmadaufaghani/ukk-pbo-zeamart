using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Latihan4
{
    internal class Hash
    {
        public string HashPass(string data)
        {
            SHA1 sha = SHA1.Create();

            byte[] kodehash = sha.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder nilaiHasil = new StringBuilder();

            for(int i = 0; i < kodehash.Length; i++)
            {
                nilaiHasil.Append(kodehash[i].ToString());
            }

            return nilaiHasil.ToString();
           
        }
    }
}
