using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    //arrayList with Custom classes.
   public class Student
    {
        public string name { get; set; }
        public int rollno { get; set; }
        public float percentage { get; set; }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static void Main(string[] args)
        {
            //Product
            ArrayList products = new ArrayList()
            {
                new Product{Id=1,Name="mouse",Price=899},
                new Product{Id=2,Name="keyboard",Price=699},
                new Product{Id=3,Name="laptop",Price=34899},
                new Product{Id=4,Name="Pendrive",Price=1299},
                new Product{Id=5,Name="DVD",Price=99},
            };
            //               OR
            ArrayList productlist = new ArrayList();
            productlist.Add(new Product { Id = 1, Name = "mouse", Price = 899 });
            productlist.Add(new Product { Id = 2, Name = "keyboard", Price = 699 });
            productlist.Add(new Product { Id = 3, Name = "laptop", Price = 34899 });

            foreach (Product item in products)
            {
                if (item.Price >= 1000)
                {
                    Console.WriteLine($"{item.Id}- {item.Name} - {item.Price}");
                }

            }
            Console.WriteLine("-------------------------------");
            foreach (Product item in productlist)
            {
                Console.WriteLine($"{item.Id}- {item.Name} - {item.Price}");
            }

            //Student
            ArrayList stud = new ArrayList()
            {
                new Student{name="Alfred",rollno =12,percentage =67.66F},
                new Student{name="Bruce",rollno = 10,percentage=67.66F},
                new Student{name="Caitlin",rollno = 50,percentage=34.99F},
                new Student{name="Daina",rollno = 3,percentage=22.66F},
                new Student{name="Elizabeth",rollno = 40,percentage=33.66F},
            };
            //OR//   -----------------------------------------------------------
            ArrayList student = new ArrayList();
            student.Add(new Student{ name = "Finn", rollno = 1,percentage = 43.87F });
            student.Add(new Student { name = "Ginny", rollno = 23, percentage = 22.87F });
            student.Add(new Student { name = "Harry", rollno = 8, percentage = 88.87F });
            student.Add(new Student { name = "Ian", rollno = 19, percentage = 12.87F });
            student.Add(new Student { name = "Jack", rollno = 18, percentage = 98.87F });

            foreach(Student item in stud)
            {
                Console.WriteLine($"name = {item.name} roll no = {item.rollno} percentage is {item.percentage}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Passed students are:-");
            foreach (Student item in student)
            {
                if(item.percentage>35.00)
                {
                    Console.WriteLine($"name = {item.name} roll no = {item.rollno} percentage is {item.percentage}");
                }
               
            }
        }

    }
}
