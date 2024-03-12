namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //{
            //Console.WriteLine("Eded daxil et:");
            //int eded = Convert.ToInt32(Console.ReadLine());

            //int say = 0;
            //for (int i = 2; i < eded; i++)
            //{

            //    if (eded % i == 0)
            //    {
            //        say++;
            //        break;
            //    }

            //}
            //if (say > 0)
            //{
            //    Console.WriteLine("murekkeb");
            //}
            //else if (eded == 1)
            //{
            //    Console.WriteLine("NE SADE NE MUREKKEB");
            //}


            //else
            //{
            //    Console.WriteLine("sadedir");
            //}

            //int[] numbers = { 12, 13, 14, 15, };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 0)
            //    {
            //        sum += numbers[i];
            //    }
            //}
            //Console.WriteLine(sum);


            //string[] Abb = { "anar", "ferid", "telman" };
            //bool isHave = false;
            //for (int i = 0; i < Abb.Length; i++)
            //{
            //    if (Abb[i] == "anare")
            //    {
            //        isHave = true;
            //    }
            //}
            //Console.WriteLine(isHave);

            //string[] name = { "ferid", "anar", "fuad" };
            //string add="";
            //int index = 0;
            //for(int i = name[index].Length-1;i>=0;i--)
            //{
            //    add += name[index][i];

            //}

            //Console.WriteLine(add);
            //int[] brr = { 1, 2, 3, 4, 5, 6, 7, };
            //int max = brr[0];
            //for(int i=0;i<brr.Length;i++)
            //{
            //    if 

            //        (brr[i] > max)
            //        max= brr[i];


            //}
            //Console.WriteLine(max);
            //string[] brr = { "Salam", "Heleelo", "Test", "Azeetu" };
            //int say = 0;
            //int input = 'e';
            //for(int i=0; i<brr.Length;i++)
            //{
            //    for(int j = 0; j < brr[i].Length;j++){

            //        if (brr[i][j] ==input) {

            //            say++;
            //            break;
            //        }

            //    }

            //}
            //Console.WriteLine(say);
            //int[] arr = { 1, 2, 3, 4, 5, };
            //int hasil = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        hasil *= arr[i];

            //    }







            //}
            //Console.WriteLine(hasil);
            //int[] arr = { 1, 2, 3, 4, 5, };
            //int n = 8;
            //bool boyukdur = false;
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if (n > arr[i])
            //    {
            //        boyukdur= true;
            //    }
            //    else
            //    {
            //        boyukdur= false;

            //    }
            //}
            //Console.WriteLine(boyukdur);
            //string[] words = { "apple", "power", "yeap" };

            //bool beraberdir= false;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i] =="apple")
            //    {
            //        beraberdir =true;
            //        break;
            //    }
            //    else
            //    {
            //       beraberdir= false;
            //    }
            //    Console.WriteLine(beraberdir);




            //string[] words = { "apple", "power", "yeap" };
            //bool duzdur = false;
            //for (int i = 0; i < words.Length; i++)
            //{
            //    for (int j = 0; j < words[i].Length; j++)
            //    {

            //        if (words[i][j] == 'w')
            //        {
            //            duzdur = true;
            //            break;
            //        }
            //        else
            //        {
            //            duzdur = false;
            //        }

            //    }
            //    Console.WriteLine(duzdur);
            //}


            string[] words = { "apple", "power", "yeap" };


            string add = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    add += words[i][j];
                }

            }
            Console.WriteLine(add);
        }





    }
}
