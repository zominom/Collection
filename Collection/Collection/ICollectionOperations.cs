using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public interface ICollectionOperations
    {
        void ListOperations<T>(List<T> list)
            where T : IEquatable<T>
        {
            const int NUMBER_OF_UNIQUE = 3;
            const string MAMAS_STRING = "mamas";
            const string COURSE_STRING = "course59";
            const char SIX = '6';

            int mamasIndex = 0;
            int courseIndex = 0;

            // Step 1
            list.RemoveAt(Convert.ToInt32(list.Count / 2));

            // Step 2
            while (mamasIndex != -1)
            {
                mamasIndex = list.FindIndex(item => item.Equals(MAMAS_STRING));
                if (mamasIndex != -1 && typeof(T) == typeof(string))
                {
                    list[mamasIndex] = (T)(object)(MAMAS_STRING + SIX);
                }
            }
            // Step 3
            courseIndex = list.FindIndex(item => item.Equals(COURSE_STRING));
            if (courseIndex % 2 != 0)
            {
                list.Reverse();
            }
            // Step 4
            if (list.Distinct().Count() == NUMBER_OF_UNIQUE && typeof(T) == typeof(string))
            {
                List<string> insertedList = new List<string>();
                insertedList.Add("2");
                insertedList.Add("3");
                insertedList.Add("4");
                list.InsertRange(2, (IEnumerable<T>)insertedList.AsEnumerable<string>());
            }
        }

        void DictionaryOperations<T, X>(Dictionary<T, X> dictionary)
            where T : notnull
            where X : IComparable<int>
        {
            const string KEY_TO_FIND = "scuba";
            const string KEY_TO_ADD = "dive";

            if (typeof(T) == typeof(string) && typeof(X) == typeof(int))
            {
                T keyToFind = (T)(object)KEY_TO_FIND;
                T keyToAdd = (T)(object)KEY_TO_ADD;

                if (dictionary.ContainsKey(keyToFind) && dictionary[keyToFind].CompareTo(6) == 0)
                {
                    dictionary[keyToAdd] = (X)(object)6;
                }
            }
        }

        void StackOperations<T>(Stack<T> stack)
        {

        }
    }

}
