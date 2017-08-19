using System;
using System.Linq;

namespace PosAsp.Library
{
    public class RandomAccessToken
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public static string RandomString(int Size)
        {
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, Size).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
    }
}