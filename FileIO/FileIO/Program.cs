using System;

namespace FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileOperation fileOperation = new FileOperation();
            Console.WriteLine("Welcome To File Operation Methods");
            Console.WriteLine("Select Below Option");
            bool flag = true;
            while (flag)
            {
               
                Console.WriteLine("1.Check Files Exists or Not \n2.ReadAllLines \n3.Exist");
                Console.WriteLine("---------------------------");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        fileOperation.FileExist();
                        break;
                    case 2:
                        fileOperation.ReadAllLines();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}