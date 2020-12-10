using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5100
{
   abstract   partial class func_of_list
    {
        

        public static void new_obj(class_container objs,film a)
        {
            objs.films1.Add(a);
        }

        public static void count_elements(class_container objs)
        {
            Console.WriteLine("коилчесмтво фильмов "+objs.films1.Count);
            Console.WriteLine();


        }
        public static void year_finder(class_container objs)
        { 
            
            Console.WriteLine("Введите дату выхода");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Фильмы вышедшие в один и тот же год");
            for (int i = 0;i<objs.films1.Count;i++)
            {
                if (objs.films1[i].strct.year_of_release == id)
                    Console.WriteLine(objs.films1[i].strct.name_of_film);
                
            }
            Console.WriteLine();


        }
        public static void time_of_programm_func(class_container objs)
        { 
            
            
            for(int i = 0;i<objs.films1.Count;i++)
            {
                Console.WriteLine(objs.films1[i].strct.name_of_film);
                Console.WriteLine(" время фильма - " + objs.films1[i].Times_of_film) ;
            }
            Console.WriteLine();


        }
        public static void count_of_advert(class_container objs)
        { 
            
            
            for(int i = 0;i<objs.films1.Count;i++)
            {
                Console.WriteLine("фильмы " + objs.films1[i]);
                Console.WriteLine("рекламы фильмов " + objs.films1[i].strct.count_of_adverts);
            }
            Console.WriteLine();


        }

        

        
    }
}
