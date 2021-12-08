using System.Text;

namespace ConsoleApp1
{
    public class Vigenere
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz .,?!:";
        
        public string toVigenere(string text, string key)
        {
            //зашифрованный текст
            var encodedText = new StringBuilder();

            //массив индексов символов ключа
            var keyLettersIndexes = new int[key.Length];

            //заполнение массива
            for (var i = 0; i < key.Length; i++)
                keyLettersIndexes[i] = alphabet.IndexOf(key[i]);

            for (var i = 0; i < text.Length; i++)
            {
                encodedText.Append(alphabet[
                    (alphabet.IndexOf(text[i]) + keyLettersIndexes[i % key.Length])
                    % alphabet.Length]);
            }
            
            return encodedText.ToString();
        }

        public string fromVigenere(string encodedText, string key)
        {
            //расшифрованный текст
            var decodedText = new StringBuilder();

            //массив индексов символов ключа
            var keyLettersIndexes = new int[key.Length];

            //заполнение массива
            for (var i = 0; i < key.Length; i++)
                keyLettersIndexes[i] = alphabet.IndexOf(key[i]);

            for (var i = 0; i < encodedText.Length; i++)
            {
                decodedText.Append(alphabet[
                    (alphabet.IndexOf(encodedText[i]) + alphabet.Length - keyLettersIndexes[i % key.Length])
                    % alphabet.Length]);
            }

            return decodedText.ToString();
        }  
    }
}