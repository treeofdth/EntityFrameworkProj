using System;
using System.Linq;
using SmthProj.Models;
using SmthProj.Data;

namespace SmthProj
{
    class Prog
    {
        static void Main()
        {
            Console.WriteLine("=== Entity Framework Core + MS SQL Server ===\n");

            using (var db = new AppDbContext())
            {
                //СОЗДАНИЕ БД:
                //db.Database.EnsureCreated();

                //Console.WriteLine("Добавление пользователей:");

                //var user1 = new User { Name = "Mick Thomson", Age = 39, Email = "slipknot@gmail.com" };
                //var user2 = new User { Name = "Corey Taylor", Age = 40, Email = "corey@gmail.com" };
                //var user3 = new User { Name = "Jim Root", Age = 45, Email = "jim@icloud.com" };

                //db.Users.AddRange(user1, user2, user3);
                //db.SaveChanges();
                //Console.WriteLine($"Добавлено пользователей: {db.Users.Count()}");

                //Console.WriteLine("Все пользователи:");
                //foreach (var user in db.Users)
                //{
                //Console.WriteLine($"ID: {user.Id} | Name: {user.Name} | Age: {user.Age} | Email: {user.Email}");
                //}

                //Console.WriteLine("Обновление возраста:");
                //var jim = db.Users.FirstOrDefault(u => u.Name == "Jim Root");
                //if (jim != null)
                //{
                    //jim.Age = 35;
                    //db.SaveChanges();
                    //Console.WriteLine($"Новый возраст Jim: {jim.Age}");
                //}
            }
        }
    }
}