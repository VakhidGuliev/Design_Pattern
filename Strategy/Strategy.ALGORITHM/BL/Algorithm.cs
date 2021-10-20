using Design_Pattern.Strategy.Sort;

namespace Design_Pattern
{
    public abstract class Algorithm
    {
        public abstract string Name { get; }
        protected Algorithm()
        {

        }
        public abstract void Run();
    }
}
