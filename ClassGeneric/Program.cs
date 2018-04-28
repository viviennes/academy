using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassGeneric
{
    class Program
    {
     

        static void Main(string[] args)
        {

            //akceptuje tylko 
            //oprocz tego wszystkie klasy musza spelniac interfejs IAkademia
            //metoda getmytype i ona zwraca nazwe typu? 
            /*
                        MyClass<AkademiaCszarp> myClass1 = new MyClass<AkademiaCszarp>();
                        MyClass<AkademiaCpp> myClass2 = new MyClass<AkademiaCpp>();

                        var akademiaCszarp = new AkademiaCszarp();
                        var akademiaCpp = new AkademiaCpp();

                        myClass1.getMyType(ref akademiaCszarp);
                        myClass2.getMyType(ref akademiaCpp);
            */
            //var zrobmy liste ktora trzyma ArrayListy które trzymają kolekcję Dictionaries a one dowolnie
            //metoda która iteruje po liście wypisując wszystkie arraylisty a później dictionaries
            //1 lista 2 arraylisty i kazda trzyma po trzy dictionary;

            /*
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(dictionary1);
            arrayList1.Add(dictionary2);
            arrayList1.Add(dictionary3);

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add(dictionary4);
            arrayList2.Add(dictionary5);
            arrayList2.Add(dictionary6);

            List<ArrayList> lists = new List<ArrayList>();
            lists.Add(arrayList1);
            lists.Add(arrayList2);

    */
            CollectionsOfCollections collectionsOfCollections = new CollectionsOfCollections();
            collectionsOfCollections.printCollections();
        }

      
    }
}
