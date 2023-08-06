using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                // Обработка исключения, например, добавление ошибки в коллекцию Error
                var error = new Error
                {
                    Message = ex.Message,
                    Time = DateTime.Now,
                    Request = "Your request data", // Здесь можно добавить дополнительные данные о запросе
                    Status = StatusCode.Server // Здесь указываете нужный статус код ошибки
                };

                // Добавление ошибки в коллекцию Error
                using (var context = new AppDbContext())
                {
                    context.errors.Add(error);
                    context.SaveChanges();
                }
            }

            //using (var context = new AppDbContext())
            //{
            //   var res = context.errors.ToList();

            //    foreach (var item in res)
            //    {
            //        Console.WriteLine(item.Message);
            //    }

            //}


            Console.ReadKey();
        }
    }
}
