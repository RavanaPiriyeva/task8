using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //string value;
            //Console.WriteLine("sozu daxil et:");
            //value = Console.ReadLine();
            //string number = "1234567890";
            //bool m = true;
            //foreach (var x in value)
            //{
            //    foreach (var y in number)
            //    {
            //        if (x == y)
            //        {
            //            m = false;
            //        }
            //    }
            //}
            //if (m)
            //{
            //    Console.WriteLine("YOXDUR");
            //}
            //else
            //{
            //    Console.WriteLine("VAR");
            //}

            #endregion

            #region task 2
            //string word ;
            //Console.WriteLine("Sozu daxil et :");
            //word = Console.ReadLine();
            //bool x = false;
            //for(int i = 0; i < word.Length; i++)
            //{
            //    if(word[i] == 'a')
            //    {
            //        if (word[i + 1] == 'l')
            //        {
            //           x = true;
            //        }
            //    }
            //}
            //if (x)
            //{
            //    Console.WriteLine("VAR");
            //}
            //else
            //{
            //    Console.WriteLine("YOXDUR");
            //}
            #endregion

            #region task 3
            //int number ;
            //Console.WriteLine("Ededi daxil et:");
            //number = Convert.ToInt32(Console.ReadLine());
            //int  count = 0;
            //int   sum = 0;
            //while(number > 0)
            //{
            //    count++;
            //    sum += number % 10;
            //    number /= 10;

            //}
            //float avg=(float)sum/count;
            //Console.WriteLine(avg);

            #endregion

            #region task 4
            string[] word = { "s1a", "sa", "ag1ol", "salam" };
          
            int count = 0;
      
            bool result=true;
            
             
            for (int i = 0; i < word.Length; i++)
            {
                bool n = true;
                if (n) {
                for (int x = 0; x < word[i].Length;) {
                    
                    char m = word[i][x];
                   
              if(  result = char.IsDigit(m)) { 
                count++;
                    }
                  
                    x++;
                        n= false;

                }
             
            }
            }
            Console.WriteLine(count);






  
            #endregion
        }
    }
}
