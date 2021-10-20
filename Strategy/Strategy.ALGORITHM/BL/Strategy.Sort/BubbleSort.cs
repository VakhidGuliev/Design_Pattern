using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.Strategy.Sort
{
    public class BubbleSort : ISort
    {
        public string Name { get => GetType().Name; }

        public List<int> Sort(List<int> list)
        {
            bool inverse = true;
            int c = 0;
            while (inverse)
            {
                inverse = false;
                for (int i = 0; i < list.Count - 1; ++i)
                {
                    if (list[i] > list[i + 1])
                    {
                        c = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = c;
                        inverse = true;
                    }
                }
            }
            return list;

        }

    }
}
