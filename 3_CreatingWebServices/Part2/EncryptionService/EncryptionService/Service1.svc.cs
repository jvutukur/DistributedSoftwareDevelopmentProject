using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EncryptionService
{
    public class Service1 : IService1
    {
        public String encrypt(String plainText)
        {
            String key = "DSOD";
            byte[] key32Bit = Encoding.UTF8.GetBytes(key);
            String cipher = "";
            byte[] plainTextButeArray = Encoding.UTF8.GetBytes(plainText);
            

            for (int i = 0; i < plainText.Length; i=i+4)
            {
                byte[] input32Bit;                
                if (plainText.Length > i + 3)
                    input32Bit = new byte[] { plainTextButeArray[i], plainTextButeArray[i + 1], plainTextButeArray[i + 2], plainTextButeArray[i + 3] };
                else if (plainText.Length == i + 3)
                    input32Bit = new byte[] { plainTextButeArray[i], plainTextButeArray[i + 1], plainTextButeArray[i + 2], 0 };
                else if (plainText.Length == i + 2)
                    input32Bit = new byte[] { plainTextButeArray[i], plainTextButeArray[i + 1], 0, 0 };
                else
                    input32Bit = new byte[] { plainTextButeArray[i], 0, 0, 0 };

                byte[] output32Bit = blockEncrypt(input32Bit, key32Bit);
                String output32BitInString = Encoding.UTF8.GetString(output32Bit, 0, output32Bit.Length);
                cipher = cipher + output32BitInString;
            }

            return cipher;
        }

        //block cipher. This block takes 32 bits as input encypts it. We will use this block again and again till we encrypt the block completely
        public byte[] blockEncrypt(byte[] input32Bit, byte[] key32Bit)
        {
            byte[] output32Bit = new byte[4];

            //Xor Key and Input 32 bits
            for (int i = 0; i < 4; i++)
            {
                output32Bit[i] = (byte)(input32Bit[i] ^ key32Bit[i]);
            }
                       
            return output32Bit;

        }

        

    }
}
