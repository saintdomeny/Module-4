using static System.Net.Mime.MediaTypeNames;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4.5


            //4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Имя питомца:");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Введите тип питомца(собака, рыбка, хомячок):");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Возраст питомца:");
            Pet.Age = double.Parse(Console.ReadLine());//Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine(Pet.Name + Pet.Type + Pet.Age + Pet.NameCount);
            Console.ReadKey();

            //4.3.17
            /*
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for(int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
            */
            //4.3.16
            //вариант с foreach
            /*
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int result = 0;

            foreach(int i in arr)
            {
                result = i > 0 ? result + 1 : result;
            }
            Console.WriteLine(result);
            // Второй вариант с for
            result = 0;

            for(int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    result = arr[i, j] > 0 ? result + 1 : result;   
            }
            Console.WriteLine(result);
            */
            //4.3.15
            /*
            var arr = new int[] { 5, 6, 9, -6, -7, 3, 4 };

            int result = 0;

            foreach(int i in arr)
            {
                result = i > 0 ? result + 1 : result;
            }
            Console.WriteLine(result);
            */
            //4.3.14
            /*
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var i in array)
            {
                foreach (var item in i)
                {
                    Console.Write(item + " ");
                }
            }
            */
            //4.3.13
            /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            */
            //4.3.12
            /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write(arr[i] + " ");
            }*/



            //4.3.11

            /*int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }*/

            /*Console.WriteLine("Напишите ваше имя");

            string name = Console.ReadLine();

            Console.WriteLine("Ваше имя наоборот:");

            for (int i = name.Length; i > 0; i--)
            {
                Console.Write(name[i - 1] + " ");
            } 
            Console.Write("Последняя буква вашего имени - " + name[name.Length - 1]);

            */
            /*while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                var text = Console.ReadLine();
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        continue;
                }
            }*/
        }
    }
}