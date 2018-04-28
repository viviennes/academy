using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum stringLength { bubbleString = 4 };

namespace Stringi
{
    using NewNamespace;

    class Program
    {
        static void Main(string[] args)
        {
            string myText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque vel turpis odio. Nulla et lectus quam. Ut commodo, nunc placerat eleifend vehicula, orci nibh laoreet nisi, ut faucibus mi lacus eu orci. Duis id purus quis massa auctor elementum. Fusce et risus id arcu congue interdum at non velit. Cras et nisi sodales, finibus erat vitae, facilisis orci. Pellentesque est urna, rhoncus eu felis non, malesuada sagittis arcu. Pellentesque sagittis est ligula, in rutrum justo elementum ac. Proin ut neque nibh. Quisque eu odio lorem. Nunc tincidunt libero orci. Aliquam sed quam vitae erat efficitur elementum. Etiam eget nisi accumsan, finibus odio vel, molestie dui. Vivamus iaculis, ante in facilisis hendrerit, dolor felis finibus orci, sit amet bibendum est purus a urna. Suspendisse tincidunt urna at interdum fringilla. Curabitur massa lorem, cursus in congue ut, porta ac metus.

In ac libero quis tellus faucibus posuere tempor et ipsum. Donec imperdiet ex vitae eros imperdiet, sit amet tempus tortor malesuada. Etiam tempor vel metus quis lobortis. In non lorem nibh. Mauris sed hendrerit magna. Etiam sodales aliquam justo, quis mattis elit tempus quis. Suspendisse hendrerit ut ante sed pulvinar. Nunc molestie nisl sit amet augue rutrum pellentesque. Nam vehicula bibendum tortor ut convallis. Mauris dictum lorem magna, sed commodo eros ultrices id. Nulla eleifend iaculis metus, sit amet sagittis velit facilisis sit amet. Phasellus ac est tempor, tincidunt odio eget, porta diam.

Morbi imperdiet ex justo, ut molestie enim rhoncus fringilla. Etiam in sodales erat. Ut vel dignissim neque. Donec ornare eleifend massa sit amet imperdiet. Aenean nibh tellus, volutpat id arcu ut, auctor mattis ante. Suspendisse ex arcu, volutpat at rhoncus vel, lobortis sed turpis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Morbi accumsan tortor lacinia ultricies efficitur. Quisque ac scelerisque nibh, eget aliquam sapien. Sed tortor tortor, ultricies vitae risus sit amet, auctor efficitur velit. Nunc luctus ac lectus in ultrices. Sed faucibus turpis ac sem sollicitudin semper.";

            //zrobić wycinanie kazdego slowa ktoe ma wiecej niz 4 litery
            //ipsum sit et
            WordCompare(myText);
            Console.WriteLine(ReplaceLetter(myText));
            Console.WriteLine();
            Console.WriteLine(StringBubble(myText));

            string str1 = "ala";
            string str2 = "ma kota";
            var date = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            //niezalecane
            Console.WriteLine(str1+str2);
            //format wyjscia
            Console.WriteLine(String.Format("{0} {1}", str1,str2));
            Console.WriteLine(String.Format("Moja nowa data: {0:HH:mm} a do tego stara {0}",date));

            //interpolacja stringow
            Console.WriteLine($"Interpolowany obiekt {date}");
            Console.WriteLine($"Interpolowany i formatowany {date:HH:mm}");

            var variableFromNamespace = testEnum.Jan;

            Console.WriteLine($"Zmienna z innego namespace {variableFromNamespace}");

        }

        //metoda statyczna ma zwraac true albo false

        static bool WordCompare(string formula)
        {

            int str1 = formula.CompareTo(" ipsum ");
            int str2 = formula.CompareTo(" sit ");
            int str3 = formula.CompareTo(" et ");

            if (str1 == 0 && str2 == 0 && str3 == 0)
                return false;

            return true;
        }

        //replace zamieniajace kazdy znak 

        static string ReplaceLetter(string formula)
        {
            return formula.Replace("e", "XY");
        }


        static StringBuilder StringBubble(string formula)
        {
            String[] strTab = formula.Split(' ');
            StringBuilder newFormula = new StringBuilder();
            for (int i = 0; i < strTab.Length; i++)
            {
                if (strTab[i].Length > (int)stringLength.bubbleString)
                {
                    strTab[i] = strTab[i].Substring(0, 4);
                    newFormula.Append(strTab[i] + " ");
                }
            }
            return newFormula;
        }
    }
}
