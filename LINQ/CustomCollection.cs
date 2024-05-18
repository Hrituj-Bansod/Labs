using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class CustomCollection<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            foreach (var item in _items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<TResult> Select<TResult>(Func<T, TResult> selector)
        {
            foreach (var item in _items)
            {
                yield return selector(item);
            }
        }
    }

}
