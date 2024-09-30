using System.IO;
using System.Security.Cryptography; // contiene clases para implementar criptografia segura aes
using System.Text; // para trabajar con codificaciones UTF-8

public class Encrypter
{
    // Clave y vector de inicialización
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("HolaJoneitosjri1"); // Debe ser de 16, 24 o 32 bytes
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("12hdwijbciworh45"); // Debe ser de 16 bytes

    
    public  string Encrypt(string plainText)
    {   // creamos la instancia de Aes
        using (Aes aesAlg = Aes.Create())
        {
            // configuramos la clave y el vector de inicializacion
            aesAlg.Key = Key;
            aesAlg.IV = IV;
            //creamos el objeto que realiza la encriptacion con la clave y el vector
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            // crea el flujo de memoria para los datos encriptados
            /// https://learn.microsoft.com/en-us/dotnet/api/system.io.memorystream?view=net-8.0
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                //enlazamos el flujo de memoria a un flujo criptografico 
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                // escribimos el texto plano en el flujo criptografico, se encripta automaticamente
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(plainText);
                }
                // facilitamos syu almacenamiento o transmision convirtiendolo en base64
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }

    
    public  string Decrypt(string cipherText)
    {   //creamos la instancia de Aes
        using (Aes aesAlg = Aes.Create())
        {
            // configuramos clave y vector
            aesAlg.Key = Key;
            aesAlg.IV = IV;
            // creamos el objeto que desencripta
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            //creamos el flujo de memoria con los datos encriptados
            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
            //enlazamos el flujo de memoria con el flujo criptografico
            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            //leemos el flujo criptografico y obtenemos el texto desencriptado
            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
            {
                return srDecrypt.ReadToEnd();
            }
        }
    }
}
/*
class Program
{
    static void Main()
    {
        string original = "Hola mundo";
        Console.WriteLine("Usuario 1");
        // Encriptar
        string encrypted = PasswordEncryptor.Encrypt(original);
        Console.WriteLine($"Encrypted: {encrypted}");

        // Desencriptar
        string decrypted = PasswordEncryptor.Decrypt(encrypted);
        Console.WriteLine($"Decrypted: {decrypted}");

        Console.WriteLine("Usuario 2");

        string original1 = "que hay gente";

        string encrypted1 = PasswordEncryptor.Encrypt(original1);
        Console.WriteLine($"Encrypted: {encrypted1}");

        // Desencriptar
        string decrypted1 = PasswordEncryptor.Decrypt(encrypted1);
        Console.WriteLine($"Decrypted: {decrypted1}");

        Console.ReadKey();
    }
}
*/