using Design_Pattern.Strategy.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
   public class UI
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 1,3,4,5,22,5,0};
             
            Sort sort = new Sort(data,new HeapSort());
            Console.WriteLine(sort.Name);
            sort.Run();
            
        }
    }
}
