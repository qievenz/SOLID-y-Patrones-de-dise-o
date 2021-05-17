using System.Collections.Generic;

namespace _09.Patron.Creacional.Singleton
{
    public class SingletonFinder
    {
        private ISingletonContainer _singletonDataContainer;

        public SingletonFinder(ISingletonContainer singletonDataContainer)
        {
            _singletonDataContainer = singletonDataContainer;
        }
        public int GetPopulation(IEnumerable<string> names)
        {
            int total = 0;
            
            foreach (var name in names)
            {
                total += SingletonDataContainer.Instance.GetPopulation(name);
            }
            
            return total;
        }
    }
}
