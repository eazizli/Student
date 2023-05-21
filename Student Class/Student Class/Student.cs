using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    internal class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Username;

        public Student(int Id, string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Id = Id;
        }
        public Student(int Id,string Name ,string Surname,string username) :this(Id, Name, Surname)
        {
            this.Username = username;   
        }
       
    }
}