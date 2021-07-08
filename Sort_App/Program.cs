using System;

namespace Sort_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[7];
            Console.WriteLine("Введите семь чисел");
            
            int n, k, temp, obr, i, j;

            n = nums.Length;

            for (i = 0; i < n; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Отсортировать по возрастанию или убыванию?");
            Console.WriteLine("Чтобы отстортировать по возрастанию, набери 1\n");
            Console.WriteLine("Чтобы отстортировать по убыванию, набери 2\n");
            Console.WriteLine("Введи 1 или 2\n");

            string answer = Console.ReadLine();
            if (answer == "1")
            {
                for ( i= 0; i <n-1; i++)
            {
                for ( j = i + 1; j < n; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }    
            }
            Console.WriteLine("Вывод отсортированного массива");
            for ( i=0; i < n; i++ )
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
            }

            else if (answer =="2")
            {
                for (i = 0; i < n-1; i++)
            {
                 for ( j=i+1; j< n; j++)
                {
                    if (nums[i] <nums[j])
                    {
                        obr = nums[i];
                        nums[i] = nums[j];
                        nums[j] = obr;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Неверное значение");
            }
        }
    }
}
