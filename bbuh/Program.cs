namespace bbuh;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        
        int[] positivenegativenumbers = { -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6 };

        
            for (int i = 0; i < positivenegativenumbers.Length; i++)
                if (positivenegativenumbers[i] < 0)
                {
                 count++;

                    {
                        sum += positivenegativenumbers[i];
                    }
                }

            Console.WriteLine(sum) ;
        Console.WriteLine(count);
            

            
            
            





        

    }
}

