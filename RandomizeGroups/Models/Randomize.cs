using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizeGroups.Models
{
    public  static class Randomize
    {
        public static void RandomizeMethod<T>(this T[] items)
        {
            Random rand = new Random();

            for (int i = 0; i < items.Length-1; i++)
            {
                int j = rand.Next(i, items.Length);

                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}
