using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_product_in_a_series
{
    public class Series
    {

        public int K { get { return K; }
            set
            {
                if ((value >= 1) && (value <= 7)) { K = value; } else { K = 0; } }
                     }
        public int N { get { return N; }
                        set { if ((value >= K) && (value <= 1000)) { N = value; } else { N = 0; } }
                     }
        public int T { get { return T; }
                        set { if ((value >= 1) && (value <= 100)) { T = value; } else { T = 0; } }
                     }

        public int L {get { return L; }
                            set { if ((value >= K) && (value <= 1000)) { L = value; } else { L = 0; } }
        }
        static void Main(string[] args)
        {
        }

        public void Serie()
        {
            if ( K == 0) { Console.WriteLine("The variable 'K' is outside the established ranges"); }
            else if (N == 0) { Console.WriteLine("The variable 'N' is outside the established ranges");}
            else if (N == 0) { Console.WriteLine("The variable 'T' is outside the established ranges"); }
            else { 
                string Num = this.N.ToString();
                string[] Nums= new string[0];            
                for (int i = 1; (i + this.K) <= this.L; i++)
                    {
                    Array.Resize(ref Nums, Nums.Length + i);
                    Nums[i-1] = Num.Substring(i, this.K);
                    }
                int x=1;
                foreach (string item in Nums)
                {
                    x = Convert.ToInt32(item.Substring(1, 1)) * x; 
                }
                Console.WriteLine(x.ToString());
            }
        }

    }
}
