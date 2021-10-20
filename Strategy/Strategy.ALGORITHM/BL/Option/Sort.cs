using Design_Pattern.Strategy.Sort;
using System.Collections.Generic;
namespace Design_Pattern
{
    public class Sort : Algorithm
    {
        ISort sortStrategy;
        List<int> data;
        public Sort(List<int> _data, ISort _isort)
        {
            sortStrategy = _isort;
            data = _data;
        }
        public override string Name { get => sortStrategy.Name; }

        public override void Run()
        {
            sortStrategy.Sort(data);
        }

    }
}
