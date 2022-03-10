using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class TableElem
    {
        public int id { get; set; }
        public string login {get;set;}
        public string password { get; set; }
        public TableElem(Account account)
        {
            id = account.id;
            login = account.login;
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(account.passwordHash);
                // Get the hashed string.  
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                // Print the string. 
                password = hash;
            }
            //password = Encoding.Unicode.GetString(account.passwordHash);
        }
    }
}
