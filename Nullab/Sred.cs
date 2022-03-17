using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Есть коллекция Nullable<int>-ов. Посчитайте сумму элементов такой коллекции. Отсутствующие значения не учитывайте.
//Просуммируйте коллекцию Optional<int>. Результат — Optional<int>.
//Найдите среднее арифметическое коллекции Optional<int> Результат — Optional<float>
namespace Nullab
{
    class Sred
    {
        public Sred()
        {
            static int? Countt(List<int?> a)
            {
                int count = 0;
                int sum = 0;

                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] != null)
                        count++;
                   
                }
                return count;

            }
            static int? Counttt(List<int?> a)  /*Сумма коллекции*/
            {
                int sum = 0;

                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] != null)

                        sum += (int)a[i];
                }
                return sum;

            }
            static double? Countttt(List<int?> a)  /*Среднее коллекции*/
            {
                double sred = 0;
                int count = 0;

                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] != null) { sred += (double)a[i]; }

                    count ++;
                    
                }
                
                return sred / count;

            }



            List<int?> one = new List<int?>();
            
            one.Add(null);
            one.Add(3);
            one.Add(null);
            one.Add(2);
            one.Add(null);
            one.Add(null);

            Console.WriteLine($" {Countt( one )} количество заполненных");
            Console.WriteLine($" {Counttt(one)} Сумма");
            Console.WriteLine($" {Countttt(one)} Среднее");

            //Optional <int?> optional = new Optional<int?>(Countt(one));

            //Optional<int> summ = new Optional<int>(aqw); /*не получилось но буду пробывать потом */







        }
    }
}
