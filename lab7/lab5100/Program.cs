using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab5100
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 5
            ///multfilm multfilm1 = new multfilm("Бака", "Загадочный", "Пуприр", 9);
            hud_film Chebyrashka = new hud_film("Чебурашка", "крокодил Гена", "Шапакляк", 8);
            tv_programm Natinonal_Geographic = new tv_programm("National_Gepgrahic", "BearGrils");
            //if (multfilm1 is Iadvert)
            //    Console.WriteLine("Объект multfilm1 наследует интерфейсу Iadvert");
            //else
            //    Console.WriteLine("Объект multfilm1 не наследует интерфейсу Iadvert");
            //Console.WriteLine();

            #endregion




            #region task 7
            Printer printer = new Printer();

            ///multfilm multfilm2 = new multfilm(" Суперсемейка", " Мистр Исключительный", " Бади", 9);
            ///object[] arr1 = new object[] { multfilm2, Chebyrashka };
            ///foreach (object i in arr1)
            {
           ///     printer.IAmPrinting(i);
            }
            #endregion

            //#region task4 lab6
            //Console.WriteLine("zadanie ne sdelano ");
            //Class1 n1 = new Class1("name","cherecter","Batya");
            //n1.info();
            //((Iadvert)n1).info();


            /////news news1 = new news("Проход", 2002, 30, 1);
            /////multfilm multfilm3 = new multfilm("Приход",2002,40,2);
            //hud_film hud_film1 = new hud_film("Отход",2001,89,9);
            //film film1 = new film("Переход",2007,90,5);
            //film film2 = new film("Приход", 2002, 40, 2);
            //film film3 = new film("Отход", 2002, 89, 9);
            //film film4 = new film("Вездеход", 1999, 100, 10);
            //tv_programm tv_programm1 = new tv_programm("Вездеход",1999,100,10);
            //List<film> films3 = new List<film>();

            //films3.Add(film1);
            //films3.Add(film2);
            //films3.Add(film3);
            //films3.Add(film4);
            //class_container objs = new class_container(films3);

            //Console.WriteLine();


            //func_of_list.count_elements(objs);
            //func_of_list.time_of_programm_func(objs);
            //func_of_list.year_finder(objs);

            //Console.WriteLine("asdawdqw");
            //Console.WriteLine(film1.strct.times_of_film);






            //#endregion

            #region lb7
            string result;



            try { 
                film filmForEx = new film("Avengers", 2017, 5, 3);
                film filmForEx2 = new film("Avengers - 2", 2018, 0.5, 0);
                news newsForEx1 = new news("Discovery", 2100, "Pochta");
                news newsForEx2 = new news("Nationa Geagraphic", 800, "Putin");
                multfilm multfilmForEx1 = new multfilm("Vasya", "Pupkin", "Vayne", 5);

            }
            catch (filmException ex)
            { 
                Console.WriteLine($"Error:{ex.Message}"); 
            }
            catch (newsException ex) 
            { 
                Console.WriteLine($"Error:{ex.Message}");
            }
            catch (multfilmException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }


            

            

            try
            {
                Console.WriteLine("Enter your dateyear:");
                int dateYear = Convert.ToInt32(Console.ReadLine());
                result = "You entered " + dateYear;
                Console.WriteLine(result);
            }
            catch (FormatException) { Console.WriteLine($"BadType"); }

            try
            {
                Console.WriteLine("Intered number:a");
                Console.WriteLine("Intered number:b");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
                Console.WriteLine("GoodOperation");
            }
            catch
            {
                Console.WriteLine("BadOperation");
            }


            try
            {
               
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Exception:{ex.Message}"); 
                Console.WriteLine($"Exception was triggered in :{ex.InnerException}");          
            }
            catch
            {
                Console.WriteLine("Universal handler");
            }
            finally
            {
                int index;
                index = -100;
                Debug.Assert(index > 0, "Index of array must be hiegher then 0");
                Console.WriteLine("TheEnd");
            }
            #endregion
        }
    }
}



