using System.Text;
using System.Security.Cryptography;


namespace BLL
{
    public class passwordHashing
    {
      



        /// the following 2 methods are from https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129
        public string Hash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]); // fills it with 16 random bytes

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);   //password based key derivation function   random from seed from password and seed 
            byte[] hash = pbkdf2.GetBytes(20);   //ask for 20 bytes from the random generator 

            byte[] hashBytes = new byte[36];  //create a new array of 36 bytes
            Array.Copy(salt, 0, hashBytes, 0, 16);  //substring the salt to the first 16 bytes of the array
            Array.Copy(hash, 0, hashBytes, 16, 20);  // substring the hash to the last 20 bytes of the array

            string savedPasswordHash = Convert.ToBase64String(hashBytes);  //convert the array to a string

            return savedPasswordHash;
        }

        public  bool Validate(string password, string savedPasswordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash); //convert the string to a byte array

            byte[] salt = new byte[16]; //create a new array of 16 bytes
            Array.Copy(hashBytes, 0, salt, 0, 16); //substring the salt to the first 16 bytes of the array

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000); //password based key derivation function   random from seed from password and seed
            byte[] hash = pbkdf2.GetBytes(20); //ask for 20 bytes from the random generator

            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i]) //compare the two arrays
                    return false;

            return true;
        }
    }
}