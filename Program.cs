using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random Array
            // foreach (var item in RandomArray())
            // {
            //     System.Console.Write(item + " ");
            // }
            // System.Console.WriteLine();

            //Coin Flip
            // System.Console.WriteLine(CoinFlip());
            // System.Console.WriteLine(TossMultipleCoins(3));

            //Names
            // string[] Name = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            // foreach (var item in Names(Name))
            // {
            //     System.Console.WriteLine(item);
            // }
        }


        // Random Array
        // Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray(){
            int[] arr = new int [10];
            Random rand = new Random();
            // Place 10 random integer values between 5-25 into the array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
            }
            // Print the min and max values of the array
            int Max = arr[0];
            int Min = arr[0];
            // Print the sum of all the values
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if(arr[i] > Max){
                    Max = arr[i];
                }else if (Min > arr[i]){
                    Min = arr[i];
                }
            }
            System.Console.WriteLine("Max : " + Max);
            System.Console.WriteLine("Min : " + Min);
            System.Console.WriteLine("Sum : " + sum);
            return arr;
        }

        // Coin Flip
        public static string CoinFlip(){
            System.Console.WriteLine("Tossing a Coin!");
            string[] headTail = {"Heads", "Tails"};
            Random rand = new Random();
            int choice = rand.Next(headTail.Length);
            System.Console.WriteLine(headTail[choice]);
            return headTail[choice];
        }
        // mutiple times of tossing coin
        public static double TossMultipleCoins(int num){
            double total = 0;
            double head = 0; 
            double ratio = 0;
            
            for (int i = 0; i < num; i++)
            {
                total ++;
                string x = CoinFlip();
                if ( x == "Heads" ){
                    head++;
                }

            }
            ratio = head / total;
            System.Console.WriteLine(total);
            return ratio;
        }

        // Name
        public static string[] Names(string[] arr){
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int name = rand.Next(arr.Length);
                string temp = arr[i];
                arr[i] = arr[name];
                arr[name] = temp;
            }

            List<string> NameList = new List<string>();
            for(int i = 0; i<arr.Length; i++){
                if(arr[i].Length >=5){
                    NameList.Add(arr[i]);
                }
            }
            string[] newarr = NameList.ToArray();
            return newarr;

        }
    }
}
