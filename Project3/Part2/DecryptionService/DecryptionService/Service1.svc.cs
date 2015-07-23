using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DecryptionService
{
    public class Service1 : IService1
    {
        
        public String  decryption(String cipher)
        {
            String key = "DSOD";
            byte[] key32Bit = Encoding.UTF8.GetBytes(key);
            String plainText = "";                        
            byte[] cipherInByteArray = Encoding.UTF8.GetBytes(cipher);


            for(int i=0;i<cipher.Length;i+=4)
         {
        	 byte[] input32Bit;        	 
        	 
        	 if(cipher.Length>i+3)        	 
        		input32Bit =new byte[]{cipherInByteArray[i],cipherInByteArray[i+1],cipherInByteArray[i+2],cipherInByteArray[i+3]};        	 
         	else if(cipher.Length==i+3)
                 input32Bit = new byte[] { cipherInByteArray[i], cipherInByteArray[i + 1], cipherInByteArray[i + 2], 0 };
     		else if(cipher.Length==i+2)
                 input32Bit = new byte[] { cipherInByteArray[i], cipherInByteArray[i + 1], 0, 0 };
     		else
                 input32Bit = new byte[] { cipherInByteArray[i], 0, 0, 0 };
        	
        	 byte[] output32Bit=blockDecryption(input32Bit, key32Bit);
             String output32BitInString = Encoding.UTF8.GetString(output32Bit, 0, output32Bit.Length);
             plainText = plainText + output32BitInString;

         }


            return plainText;
        }


public byte[] blockDecryption(byte[] input32Bit,byte[] key32Bit)
{
	byte[] output32Bit=new byte[4];
	
  
	for(int i = 0; i < 4; i++)
	{
		output32Bit[i]=(byte)(input32Bit[i] ^ key32Bit[i]);							
	}
	return output32Bit;
		
	
}
        


    }
}
