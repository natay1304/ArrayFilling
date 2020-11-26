using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    public class Arrays
    {
        public static void RandomArrayFilling<T>(T[] recipient, T[] acceptor) 
        {
            var rng = new Random();

            void Shuffle<T2>(IList<T2> list)
            {
                var n = list.Count;
                while (n > 1)
                {
                    n--;
                    var k = rng.Next(n + 1);
                    T2 value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }

            var indexesRecipient  = new List<int>();
            //var indexesRecipient = recipient.Where(element => element == null).Select((_, i) => i).ToList();
            var indexesAcceptor = acceptor.Select((_, i) => i).ToList();

            for (int i = 0; i < recipient.Length; i++)
            {
                if (recipient[i] == null)
                {
                    indexesRecipient.Add(i);
                }
            }

            Shuffle(indexesRecipient);
            Shuffle(indexesAcceptor);

            var length = Math.Min(indexesRecipient.Count, indexesAcceptor.Count);

            for (int i = 0; i < length; i++)
            {
                recipient[indexesRecipient[i]] = acceptor[indexesAcceptor[i]];
            }
        }
    }
}
