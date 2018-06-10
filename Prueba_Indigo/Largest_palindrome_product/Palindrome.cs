using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_palindrome_product
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
        }

        public int T { get; set; }                
        public int N
        {
            get { return N; }
            set { if ((101101 < value) && (value < 1000000)) { N = value; } else { N = 0; } }
        }

        public void Palindromo()
        {
            if (this.N == 0)
            {
                Console.WriteLine("The variable 'N' is outside the established ranges");
            }else { 
                int p = 0;
                string[] Palindromo = new string[1];
                for (int x = 999; x >= 100; x--)
                {
                    for (int y = 999; y >= 100; y--)
                    {
                        p = (x * y);

                        if (p == Convert.ToInt32(ReverseString(p.ToString())))
                        {
                            if (p <= this.N)
                            {
                                if (Convert.ToInt32(Palindromo[0]) < Convert.ToInt32(ReverseString(p.ToString())))
                                {
                                    Palindromo[0] = ReverseString(p.ToString());
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(Palindromo[0]);
            }
        }

        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

    }
}
