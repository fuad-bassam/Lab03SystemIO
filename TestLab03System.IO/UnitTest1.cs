using System;
using Xunit;
using Lab03System_IO;
using System.IO;
namespace TestLab03System_IO
{
    public class UnitTest1
    {




        [Theory]
        [InlineData(200 ,new String[] {"4", "5", "10" })]
        [InlineData(459, new String[] { "3", "9", "17" })]
        [InlineData(0, new String[] { "3", "9" })]
        [InlineData(459, new String[] { "3", "9", "17","20","30","21" })]
        [InlineData(27, new String[] { "3", "9", "a" })]
        [InlineData(-30, new String[] { "-3", "2", "5" })]
        public void TEST_Challenge1(int result , String[] arr )
        {

            Assert.Equal(result, Challenges.Challenge1_Mult_3_Num(arr));

        }



       

        [Theory]
        [InlineData(5,new int[] { 1, 5, 1, 3, 6, 7, 7, 5, 7, 3, 90, 5, 5, 5, 5, 5, 5, 8, 9, 12, 34})]
        [InlineData(7, new int[] { 1, 5, 1, 3, 6, 7, 7,7, 5, 50, 8, 9, 12, 34 })]
        [InlineData(4, new int[] { 4,4,4,4,4,4,4,4,4,4,4,4,4,4 })]
        [InlineData(1, new int[] { 1,2,3,4,5,6,7,8,9,10})]
        public void TEST_Challenge4(int result, int[] arr)
        {

            Assert.Equal(result, Challenges.Challenge4MostDuplicates(arr));

        }


        [Fact]
        public void TEST_Challenge5Fact()
        {


            DirectoryInfo directory = new DirectoryInfo("../Lab03System.IObin/Debug/net5.0/words.txt");
            Assert.Equal(directory.Name, Challenges.Challenge6_fileWrite("test1"));

        }


        [Theory]
        [InlineData(90 ,new int[] { 1, 5, 1, 3, 6, 7, 7, 5, 7, 3, 90, 5, 5, 5, 5, 5, 5, 8, 9, 12, 34 })]
        [InlineData(34, new int[] { -1, -5, -1, -3, -6, -7, -7, -5, -7, -33, -90, -5, 5, 5, 5, 5, 5, 8, 9, 12, 34 })]
        [InlineData(-1, new int[] { -1, -5, -1, -3, -6, -7, -7, -5, -7, -33, -90, -5, -5, -5, -5, -5 })]
        [InlineData(5, new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 })]

        public void TEST_Challenge5Theory(int result ,int[] arr)
        {


          
            Assert.Equal(result, Challenges.Challenge5_MaxNum(arr));

        }
       
        [Fact]
        public void TEST_Challenge6Fact1()
        {


            DirectoryInfo directory = new DirectoryInfo("../Lab03System.IObin/Debug/net5.0/words.txt");
            Assert.Equal(directory.Name,  Challenges.Challenge6_fileWrite("test1"));

        }

        //[Fact]
        //public void TEST_Challenge8Fact1()
        //{


        //    DirectoryInfo filePath = new DirectoryInfo("../Lab03System.IObin/Debug/net5.0/words.txt");
        //    Challenges.Challenge8_fileEditLine(filePath.Name, "hello Word", 0);
        //  //  File.ReadAllText(filePath.FullName);
            
        //    Assert.Equal("hello Word", File.ReadAllText(filePath.FullName));

        //}

        [Fact]
        public void TEST_Challenge9Fact1()
        {
            String[] strArr = { "hello : 5", "Wolrd : 5" };
            Assert.Equal(strArr, Challenges.Challenge9_arrayWordLength("hello Wolrd"));

        }
  



        string[] arr2 = { "this: 4", "is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6" };

        [Theory]
        [InlineData(new string[] { "This : 4", "is : 2", "a : 1", "sentance : 8", "about : 5", "important : 9", "things : 6" }, "This is a sentance about important things")]
        [InlineData(new string[] { "this : 4", "TEST : 4" ,"for : 3" ,"Challenge : 9" ,"9 : 1" }, "this TEST for Challenge 9")]

        public void TEST_Challenge9Theory(String[] arrResult, String str)
        {

            Assert.Equal(arrResult, Challenges.Challenge9_arrayWordLength(str));

        }


    }
}
