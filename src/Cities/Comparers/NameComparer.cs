using System.Collections.Generic;

namespace Cities.Comparers
{
    public class NameComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            // Since we want to sort strings, we can use the
            // comparer for the built-in string class
            return string.Compare(x.Name, y.Name);
        }
    }

    public class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return string.Compare(x.State, y.State);
        }
    }

    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            int result = 0;
            if (x.Population > y.Population) result = -1;
            else if (x.Population < y.Population) result = 1;
            return result;
        }
    }

    public class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            int result = 0;
            if (x.Area > y.Area) result = -1;
            else if (x.Area < y.Area) result = 1;
            return result;
        }
    }
}
