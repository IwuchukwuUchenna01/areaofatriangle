using System.Diagnostics.Metrics;

namespace StudentArray
{
    internal class Student
    {
        class AgeBracket
        {
            public string? name { get; set; }
            public int age { get; set; }

        }
        //use of Arrays and Lists in collections 
        string[] class1 = { "jude", "james", "uchenna", "luke", "femi" };
        List<AgeBracket> classical = new List<AgeBracket>() {
            new AgeBracket(){name = "jude", age = 16},
            new AgeBracket(){name = "james", age = 19},
            new AgeBracket(){name = "uchenna", age = 10},
            new AgeBracket(){name = "luke", age = 18},
            new AgeBracket(){name = "femi", age = 16},
            new AgeBracket(){name = "otedola", age = 18 },
            new AgeBracket(){name = "okereke", age = 18 },
            new AgeBracket(){name = "falana", age = 25 },
            new AgeBracket(){name = "olusola", age = 34 },
            new AgeBracket(){name = "ogungbenro", age = 34 },
            new AgeBracket(){name = "adesanya", age = 16},

        };
        
        public static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write("Enter your name to be added to the list: ");
            string b = Console.ReadLine();
            Array.Resize(ref student.class1,6);
            student.class1[5] = b;
            for (int i = 0; i <student.class1.Length; i++) {
                Console.Write($"{ student.class1[i]}");
                if (i < student.class1.Length - 1) {
                    Console.Write(",");
                }
                if (i == student.class1.Length -1) {
                    Console.WriteLine();
                }
            }
            //Displays Users the age of 18 from the list above
            Console.Write("Enter the age you want to query: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"Users above {m}:");
            int counted = 0;
            foreach (var x in student.classical) {
                

                if (x.age == m)
                {
                    Console.WriteLine($"{x.name}");
                    counted++;
                }
                
                
            }
            Console.WriteLine($"{counted} Users found!");



        }
    }
}