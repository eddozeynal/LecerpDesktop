using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.ServiceGates
{
    public interface ICryptor
    {
        string Encrypt(string strNormalText);
        string Decrypt(string strEncryptedText);
    }
}
