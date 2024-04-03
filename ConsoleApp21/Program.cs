using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[] { 2, 3, 4, 7 };
            //int[] arr2 = new int[] { 3, 4, 7};
            //bool contains = new ArrayCheck(arr1, arr2).IsArrayContains();

            //Console.WriteLine(contains);


            User[] users = new User[]
         {
            new User("Ali", "Huseynov", "hsnvali", "1234"),
            new User("Jale", "Aghayeva", "jl123", "5678"),
            new Student("Alisa", "Penahova", "alisa2", "abcd", 12),
            new Student("Aygun", "Penahova", "aygun", "12345", 30)
         };

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();


            User currentUser = User.CheckUser(users, username, password);

            if (currentUser != null && currentUser is Student)
            {
                Student student = (Student)currentUser;
                Console.WriteLine($"Grade: {student.Grade}");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }


        }
    }



}
   