using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task105A.L5
{
    internal class Group
    {
        Student [] Students;
        public string GroupNo { get; set; }
        private int studentlimit;
        public int StudentLimit 
        {
            get 
            { 
               return studentlimit;
            }
            set 
            {
                if(value>=5 && value <= 18)
                {
                    studentlimit = value;
                }
            }
        }

        public Group( string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[0];
        }
        public bool CheckGroupNo(string groupNo)
        {   
            bool uppercharacter1= false;
            bool uppercharacter2= false;
            bool number1= false;
            bool number2= false;
            bool number3= false;
            if(groupNo.Length< 5)
            {
                return false;
            }
            foreach (var character in groupNo)
            {
               if (char.IsUpper(groupNo[0]))
                {
                    uppercharacter1 = true;
                    continue;
                }
                if(char.IsUpper(groupNo[1]))
                { 
                    uppercharacter2 = true;
                    continue;
                }
                if(char.IsDigit(groupNo[2]))
                {
                    number1 = true;
                    continue;
                }
               if( char.IsDigit(groupNo[3]))
                {
                    number2 = true;
                    continue;
                }
                if(char.IsDigit(groupNo[4]))
                {
                    number3 = true;
                    break;
                }
                    
            }
            return uppercharacter1 && uppercharacter2 && number1 && number2 && number3;


        }
        public void AddStudent(Student student)
        {
            if (Students.Length<studentlimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length-1] = student;
            }

        }

        public Student GetStudent(int id)
        {
            if (id==null)
            {
                foreach (var student in Students)
                {
                    if (student.Id == id)
                    {
                        return student;
                    }
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }

        public Group()
        {
            
        }

    }
}
