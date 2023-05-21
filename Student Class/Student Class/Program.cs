using Student_Class;
using System.Drawing;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\t\t\t1. Create Student.");
        Console.WriteLine("\t\t\t2. Get Student");
        Console.WriteLine("\t\t\t3. Get All Students");
        Console.WriteLine("\t\t\t4. Exit");

        Student student1 = new Student(1,"Inəğşi","Rüstəmli","InciRustamli");
        CreateStudent(student1);
    }
    static void CreateStudent(Student student1)
    {
        Student[] AllStudents = new Student[0];
       
        int choice = 0;
        while (choice != 4)
        {
            Console.Write("\n\nEnter your choice >> ");

            Console.ForegroundColor = ConsoleColor.Blue;
            bool True = int.TryParse(Console.ReadLine().Trim(), out choice);

            Console.ForegroundColor = ConsoleColor.White;
            if (True)
            {
                int count = 0;
                if (choice == 1)
                {
                    count++;
                    Console.Write("\nId: ");
                    
                    if (int.TryParse(Console.ReadLine().Trim(), out student1.Id))
                    {
                       
                        Console.Write("Name: ");
                        student1.Name = Console.ReadLine().Trim();

                        Console.Write("Surname: ");
                        student1.Surname = Console.ReadLine().Trim();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nCreated student.\n");

                        student1.Username = student1.Name + student1.Surname;

                        student1.Username.Replace('ə', 'e');// 
                        student1.Username.Replace('ü', 'u');
                        student1.Username.Replace('ş', 's');
                        student1.Username.Replace('ç', 'c');
                        student1.Username.Replace('ğ', 'g');
                        student1.Username.Replace('ö', 'o');
                        student1.Username.Replace('ı', 'i'); //
                        student1.Username.Replace('Ə', 'E'); 
                        student1.Username.Replace('Ü', 'U');
                        student1.Username.Replace('Ş', 'S');
                        student1.Username.Replace('Ç', 'C');
                        student1.Username.Replace('Ğ', 'G');
                        student1.Username.Replace('Ö', 'O');


                        for(int i = 0; i < count; i++)
                        {
                            Array.Resize(ref AllStudents, AllStudents.Length + 1);
                            AllStudents[AllStudents.Length - 1] = student1;
                            Array.Sort(AllStudents);
                        }
             
                    }
                   else
                        Console.WriteLine("\nId-ni duzgun daxil edin!");
                }
                if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGetting student.");
                    Console.WriteLine($"\n{student1.Name} {student1.Surname} {student1.Username}\n");
                }
                if(choice == 3)
                {

                    for(int i=0;i< AllStudents.Length;i++)
                    {
                        Console.WriteLine($" {AllStudents[i].Id} {AllStudents[i].Name} {AllStudents[i].Surname} {AllStudents[i].Username}");
                    }
                }
                if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nExciting program.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            else
            {
                Console.WriteLine("\nDuzgun secim edin!");
            }

        }
    }
}