using System.Collections.Generic;
namespace Design_Pattern.Strategy.Sort
{
    public class HeapSort : ISort
    {
        public string Name => GetType().Name;

        public List<int> Sort(List<int> a)
        {
            int n = a.Count;
            int k = n / 2;
            while (k > 0)
            {
                --k;

                Sieve(a, n, k);
            }

            k = n;
            while (k > 1)
            {
                --k;
                Swap(a[0], a[k]);
                Sieve(a, k, 0);

            }
         
            return a;
          
        }

        private void Sieve(List<int> a, int n, int i)
        {
            while (true)
            {

                int s0 = (2 * i) + 1;

                if (s0 >= n)
                {
                    break;
                }

                int s1 = s0 + 1;
                int s = s0;

                if (s1 < n && a[s1] > a[s0])
                {
                    s = s1;
                }

                if (a[i] >= a[s1])
                {
                    break;
                }
                Swap(a[i], a[s]);
                i = s;

            }
        }

        private void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }

}

