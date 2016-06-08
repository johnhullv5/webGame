using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BloggingContext();
            Console.Write("pls enter the name:");
            var name = Console.ReadLine();

            var blog = new Blog { Name = name };

            db.Blogs.Add(blog);
            db.SaveChanges();

            var query = from b in db.Blogs
                        orderby b.Name
                        select b;
            Console.WriteLine("all blogs in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("press any key to process...");
            Console.ReadKey();

        }
    }


}
