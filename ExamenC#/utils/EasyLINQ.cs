using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.utils
{
    public class EasyLINQ<T> where T : class, new()
    {

        List<T> List;
        public EasyLINQ(List<T> list) {
            List = list;
        }

        // coincidente ej: (o => o.Name == "")
        public T GetFirstCoincidence(Func<T, bool> coincidence)
        {
            return List.FirstOrDefault(coincidence);
        }
        // expresion ej: (p => p.Age > 28)
        public IEnumerable<T> FilterByExpresion(Func<T, bool> expresion)
        {
            return List.Where(expresion);
        }
        // selector ej: (p => p.Age)
        public T GetMaxValue(Func<T, int> selector)
        {
            return List.OrderByDescending(selector).FirstOrDefault();
        }
        // selector ej: (p => p.Age)
        public T GetMinValue(Func<T, int> selector)
        {
            return List.OrderBy(selector).FirstOrDefault();
        }
        // comparer ej: new CustomObjectNameComparer()
        public List<T> GetDistinctElements(IEqualityComparer<T> comparer)
        {
            return List.Distinct(comparer).ToList();
        }
        //
        public List<T> GetDistinctElements()
        {
            return List.Distinct().ToList();
        }
        // expresion ej: (p => p.Age > 28)
        public bool AnyMatchingElement(Func<T, bool> expresion)
        {
            return List.Any(expresion);
        }
        //keySelector ej:  (p => p.Age)
        public Dictionary<TKey, List<T>> GroupByProperty<TKey>(List<T> list, Func<T, TKey> keySelector)
        {
            return list.GroupBy(keySelector)
                       .ToDictionary(group => group.Key, group => group.ToList());
        }
    }
}
