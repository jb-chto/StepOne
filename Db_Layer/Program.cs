using System;
using Object_Library;
using Object_Library.Context;
using Object_Library.Entity;

namespace Db_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SkazatiDb())
            {
                db.ContactUses.Add(new ContactUs
                {
                    Name = Environment.UserName,
                    DateOfSend = DateTime.Now,
                    Email = "admin@skazati.com",
                    Message = "This is a test message.",
                    Subject = "This is a subject"
                });
                db.SaveChanges();

                foreach (var blog in db.ContactUses)
                {
                    Console.WriteLine(blog.Name);
                }
            }
        }
    }
}
