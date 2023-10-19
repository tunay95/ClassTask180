using System;

namespace ClassTask18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter HUMAN name : ");
                string input = Console.ReadLine();

                Human human1 = new Human("Tunay", "Huseynli",19);
                Human human2 = new Human("Ilkin", "Racabov", 19);
                Human human3 = new Human("Miraga", "Aliyev", 19);

                Human[] arr = { human1, human2, human3 };

                bool found = false;
                foreach (var item in arr)
                {
                    if (item.Name == input)
                    {
                        Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age);
                        found = true;
                    }
                }
                if (!found)
                {
                    throw new DataNotFoundException(" Data Not Founded ! ");
                }
            }
            catch (DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
