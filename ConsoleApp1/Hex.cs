using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Hex
    {
        public string toHex(string text)
        {
            var bytes = Encoding.Default.GetBytes(text);
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        public string fromHex(string hex)
        {
            var bb = Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
            
            return Encoding.ASCII.GetString(bb);
        }
    }
}