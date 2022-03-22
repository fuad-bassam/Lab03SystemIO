using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03System_IO
{
    public  class Challenges
    {
        //	/////////Challenge 1

        public static string[] Challenge1_CreateArr()
        {
            Console.WriteLine("Enter 3 number in the same line");
            String StringData = Console.ReadLine();

            String[] arr = StringData.Split(" ");

            return arr;

        }





        public static int Challenge1_Mult_3_Num(string[] arr)
        {
          
            int mult = 1;



            for (int i = 0; i < 3; i++)
            {

                try
                {
                    bool tryNum = int.TryParse(arr[i], out int num);
                    if (!tryNum) { num = 1; }


                    mult *= num;

                }
                catch (IndexOutOfRangeException)
                {

                    return 0;
                }


            }

            return mult;
        }


        /////////////////////////



        ///////////////////Challenge 2

        public static int Challenge2_FindRandomNunber()
        {

            String numInput = "";
            int num = 0;
            do
            {
                Console.WriteLine("enter number between 2 -10 ");
                numInput = Console.ReadLine();
            } while (!int.TryParse(numInput, out num) || num <= 2 || num >= 10);


            return num;
        }

        public static int Challenge2_AvgRandom()
        {

            int num = Challenge2_FindRandomNunber();

            Random random = new Random();
            int avg = 0;

            for (int i = 1; i <= num; i++)
            {
                int rand = random.Next(1, 50);
                avg += rand;
                Console.WriteLine($"{i}/{num} random number = {rand}");
            }

            return (avg / num);
        }



        //////////////////////////Challenge 3

        public static void Challenge3_starsDesign()
        {
            String numInput = "";
            int num = 0;
            bool tryNum = true;
            do
            {
                Console.Write("Challenge3 : \n enter number of middle stars ");
                numInput = Console.ReadLine();
                tryNum = int.TryParse(numInput, out num);
            } while ((!tryNum) || (num <= 0));
            //
            //Console.WriteLine(num);

            int numStar = 1, spaseNum = (num / 2);

            for (int i = 0; i < (num / 2 + 1); i++)
            {

                //numStar = 2 * i + 1;
                // spaseNum = (num - numStar) / 2;

                for (int j = 1; j <= (numStar + spaseNum); j++)
                {

                    if (j <= spaseNum)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                numStar += 2;
                spaseNum -= 1;
                Console.WriteLine(" ");
            }
            numStar -= 2;
            spaseNum += 1;
            while (numStar != 1)
            {

                numStar -= 2;
                spaseNum += 1;
                for (int j = 1; j <= (numStar + spaseNum); j++)
                {

                    if (j <= spaseNum)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine(" ");

            }


        }


        //////////////////////////////////




        ////////////////////Challenge 4


        public static int Challenge4MostDuplicates(int[] arr) {

            string arrayString = "";


            for (int i = 0; i < arr.Length; i++)
            {
                if (arrayString.IndexOf($"{arr[i]} ") == -1)
                {
                    arrayString += arr[i] + " ";
                }

            }
            //  Console.WriteLine($" {arrayString} ");

            String[] arr2 = arrayString.Split(" ");
            int[] arr3 = new int[arr2.Length];
            int max = 0;
            for (int i = 0; i < arr2.Length; i++)
            { arr3[i] = 0;
                for (int j = 0; j < arr.Length; j++)
                {

                    if ((arr2[i]) == Convert.ToString(arr[j]))
                    {
                        arr3[i] += 1;
                    }

                }
                if (arr3[i] > arr3[max]) { max = i; }

            }

          

            return Convert.ToInt32(arr2[max]);

        }

        ///////////////////////////





        ////////////////////Challenge 5

        public static int Challenge5_MaxNum(int[] arr) {

            int max = arr[0];

            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }

            }

            return max;
        }


        /////////////////////////////////////




        ////////////////////Challenge 6

        public static String Challenge6_fileWrite(string str) {

            String filePath = "words.txt";

            //////if we want to overWrite data in the file
            // File.WriteAllText(filePath, str);


            //////if we want to keep data in the file and add above it 
            File.AppendAllText(filePath, str);

            Console.WriteLine("modifying done");

            return filePath;
        }



        //////////////////////////////////

        ////////////////////Challenge 7

        public static void Challenge7_fileRead(string filePath)
        {



            Console.WriteLine("Challenge7: \n"+File.ReadAllText(filePath));

        }
        //////////////////////////////////


        ////////////////////Challenge 8

        public static int Challenge8_PicANumber() {

            bool tryPars = true;
            int num = 0;
            string inputNum = "";
            do
            {

                Console.Write("Enter number of the line you want edit it = Line ");
                inputNum = Console.ReadLine();
                tryPars = int.TryParse(inputNum, out num);
            } while (!tryPars || num <= 0);


            return num;

        }
        public static void Challenge8_fileEditLine(String filePath, String word, int lineEdit)
        {
            try
            {


                StreamReader streamOfFile = File.OpenText(filePath);

                string lineOfData = streamOfFile.ReadLine();

                List<string> dataArr = new List<string>();

                int count = 1;

                do
                {

                    if (lineEdit != count)
                    {
                        dataArr.Add(lineOfData);
                    }
                    else
                    {
                        dataArr.Add(word);
                    }
                    lineOfData = streamOfFile.ReadLine();
                    count++;

                } while (lineOfData != null);

                streamOfFile.Close();

                Console.WriteLine("done");


                File.WriteAllLines(filePath, dataArr);




            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }






        }


        /////////////////////////


        ////////////////////Challenge 9


        public static string[] Challenge9_arrayWordLength(string str) {

            string[] arrStr = str.Split(" ");

            for (int i = 0; i < arrStr.Length; i++)
            {
                arrStr[i] += " : " + arrStr[i].Length;            }

            return arrStr;
        }


        ////////////////////////////////


    }
}
    

