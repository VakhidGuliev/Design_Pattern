using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.Strategy.Sort
{
   public interface ISort
    {
        List<int> Sort(List<int> list);
        string Name { get; }
    }
}
