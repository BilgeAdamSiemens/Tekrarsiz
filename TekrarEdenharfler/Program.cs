using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekrarEdenharfler
{
    class Program
    {
        
        public static char Tekrarsiz(string ilkchar)
        {
            int i, j;
            bool tekrarEden;
            char[] charlar = ilkchar.ToCharArray();
            for (i = 0; i < ilkchar.Length; i++)
            {
                tekrarEden = false;
                for(j= 0; j < ilkchar.Length; j++)
                {
                    if ((i != j) && ilkchar[i] == ilkchar[j]);
                    tekrarEden = true;
                    break;
                }
                if(tekrarEden == false)
                {
                    return charlar[i];
                }
            }
            return default(char);
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz: ");
            string kelime = Console.ReadLine();
            char ilkharf = Tekrarsiz(kelime);
            Console.WriteLine("Sonuç: ", ilkharf);
            Console.ReadKey();
            
            
            
            

        }
    }
}
