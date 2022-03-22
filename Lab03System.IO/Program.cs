using System;

namespace Lab03System_IO
{
    public   class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 1, 3, 6, 7, 7, 5, 7, 3 ,90,5,5,5,5,5,5,8,9,12,34};

            Console.WriteLine("Challenge1: multiplied number = " + Challenges.Challenge1_Mult_3_Num(Challenges.Challenge1_CreateArr()));
            Console.WriteLine("\n Challenge2 :avg = " + Challenges.Challenge2_AvgRandom());
            Challenges.Challenge3_starsDesign();

            Console.WriteLine("\n Challenge4 :the Most Duplicate = " + Challenges.Challenge4MostDuplicates(arr));

            Console.WriteLine("\n Challenge5 :The max number in array = " + Challenges.Challenge5_MaxNum(arr));


            Console.WriteLine("Challenge 6 :Write what you want to save in Word file");
            String strChallenge6 = Console.ReadLine();


            String filePath = Challenges.Challenge6_fileWrite(strChallenge6);

            Challenges.Challenge7_fileRead(filePath);
            Console.WriteLine("Challenge 8: Write what you want to edit");
            String strChallenge8 = Console.ReadLine();


            Challenges.Challenge8_fileEditLine(filePath, strChallenge8, Challenges.Challenge8_PicANumber());


            Console.WriteLine("Challenge 9 : Write a sentence");
             String strChallenge9 = Console.ReadLine();
            String[] Challenge9_arrStr = Challenges.Challenge9_arrayWordLength(strChallenge9);

            foreach (string item in Challenge9_arrStr)
            {
                Console.Write(item +" ");
            }

           // Console.ReadKey();
        }
    }
}
