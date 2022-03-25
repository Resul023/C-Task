using System;

namespace _24Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string word = Console.ReadLine();
             var result = word.Split(" ");
             for (int i = 0; i < result.Length; i++)
             {
                 Console.WriteLine(result[i]);
                 break;
             }*/    //TASK3

            /*string word = Console.ReadLine();
            var result = word.Split(" ");
            
            Console.WriteLine(string.Concat(result)); */
            //TASK1

            /*    string word = Console.ReadLine();
            string newWord = "";
            int count = 0;
            int countTwo = 0;
            int countThree = 0;
            bool check = true;

            for (int i = 0; i < word.Length; i++)
            {

                


                    if (char.IsDigit(word[i]) == true && count <1)
                    {
                        count++;
                    

                    }
                    else if (char.IsUpper(word[i]) == true && countTwo<1)
                    {
                    countTwo++;


                    }
                    else if (char.IsLower(word[i]) == true && countThree<1)
                    {
                    countThree++;

                    }

                

            }
            int resultCount = count + countTwo + countThree;
            if (resultCount >= 3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
                       */ // TASK 2


            /* string word = Console.ReadLine();
             var result = word.Split(" ");
             int count = 0;
             for (int i = 0; i < result.Length; i++)
             {
                 if (i>=0 && i <2)
                 {
                     for (int j = 0; j < result[i].Length; j++)
                     {
                         if (char.IsUpper(result[i][0]) == true  )
                         {
                             count++;
                             break;
                         }
                         else
                         {
                             Console.WriteLine("Other word is not upperLecturer");
                             break;
                         }
                     }
                 }
                 else
                 {
                     Console.WriteLine("This word is not match with Task!");
                 }
             }
             if (count>=2)
             {
                 Console.WriteLine(word);
             }*/   //TASK4

           /* int numberTool = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[numberTool];
            
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            int addTool = 5;
            int[] result = addNumber(ref number, 5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/ //TASK5
           
        }

        static int[] addNumber(ref int[] number, int addTool) 
        {
            Array.Resize(ref number, number.Length + 1);
            number[number.Length - 1] = addTool;
            return number;
        }
    }
}
