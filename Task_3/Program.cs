using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
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

                var error = new Error()
                {
                    Message = ex.Message,
                    Request = "Error",
                    Status = StatusCode.Server,
                    Time = DateTime.Now
                };


                using (MyDbContext db = new MyDbContext())
                {
                    db.Errors.Add(error);
                }

            }

           

        }
    }
}
