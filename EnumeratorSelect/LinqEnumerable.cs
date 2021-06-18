using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorSelect
{
    class Config
    {
        public bool isRemove { private set; get; }
        public void Remove() => isRemove = true;
    }
    static class LinqEnumerable
    {
        public static IEnumerable<R> SelectAt<T,R>(this IEnumerable<T> enumerable,
            Func<T,Config,R> func)
        {
            foreach (var item in enumerable)
            {
                Config config = new Config();
                var result = func(item, config);
                if (!config.isRemove) yield return result;
            }
        }
    }
}
