using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    class CollectionsOfCollections
    {
        Dictionary<int, string>[] dictionaries;
        ArrayList arrayList1;
        ArrayList arrayList2;
        List<ArrayList> arrayLists;
        public CollectionsOfCollections()
        {
            this.dictionaries = new Dictionary<int, string>[6];
            initializeDictionary(new string[]{ "Pies","Kot","Kon"}, 0);
            initializeDictionary(new string[] { "paproc", "dab", "brzoza" }, 1);
            initializeDictionary(new string[] { "a", "b", "c" }, 2);
            initializeDictionary(new string[] { "d", "e", "f" }, 3);
            initializeDictionary(new string[] { "g", "h", "i" }, 4);
            initializeDictionary(new string[] { "j", "k", "m" }, 5);

            arrayList1 = new ArrayList();
            arrayList1.Add(dictionaries[0]);
            arrayList1.Add(dictionaries[1]);
            arrayList1.Add(dictionaries[2]);
            arrayList2 = new ArrayList();
            arrayList2.Add(dictionaries[3]);
            arrayList2.Add(dictionaries[4]);
            arrayList2.Add(dictionaries[5]);

            arrayLists = new List<ArrayList>();
            arrayLists.Add(arrayList1);
            arrayLists.Add(arrayList2);

        }

        public void initializeDictionary(string[] strings, int j)
        {
            dictionaries[j] = new Dictionary<int, string>();
            for(int i=0;i<strings.Length;i++)
                dictionaries[j].Add(i, strings[i]); 
        }

        public void printCollections()
        {
            Console.WriteLine("Lista:");
            foreach (var i in arrayLists)
            {
                Console.WriteLine("\tArrayList:");
                foreach (Dictionary<int,string> j in i)
                {
                   
                    Console.WriteLine("\t\tSlownik:");
                    foreach (KeyValuePair<int, string> kvp in j)
                    {
                        Console.WriteLine("\t\t\tKlucz = {0}, Wartosc = {1}", kvp.Key, kvp.Value);
                    }
                }
            }
        }
    }
}
