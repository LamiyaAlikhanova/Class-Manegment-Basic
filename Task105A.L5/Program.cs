using System.Reflection.Metadata;

namespace Task105A.L5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             bool exit=false;
             Group group = new Group();

            do
            {
                Console.WriteLine("Welcome.");
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Show info");
                Console.WriteLine("2.Create new group");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter you chooice");
                string input= Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Student student = createstudent();
                        student.StudentInfo();
                        break;
                    case "2":
                        Group group1 = new Group();
                        break;
                    default:
                        Console.WriteLine("Duzgun islemir");
                        break;
                    case "3":
                        break;
                        bool exit2=true;
                        do
                        {
                            Console.WriteLine("1.Show all students");
                            Console.WriteLine("2.Get student by id");
                            Console.WriteLine("3.Add student");
                            Console.WriteLine("0.Quit");
                            string input2=Console.ReadLine();

                            switch (input2)
                            {
                                case "1":
                                    group.GetAllStudents();
                                    break;
                                case "2":          
                                    Console.WriteLine("Enter user ID:");
                                       int id=
                                    Convert.ToInt32(Console.ReadLine());
                                      var student2 =group.GetStudent(id);

                                    group.GetStudent(id);
                                    break;
                                case "3":
                                    Student newstudent1=createstudent();
                                    group.AddStudent(newstudent1);
                                    break;
                                case "0":
                                exit=false;
                                    break;
                            }
                            
                        } while (exit2!=false);
 

                        

                }

            } while (exit!=true);
        }
        public static Student createstudent()
        {
            Student user = new Student();

            Console.WriteLine("Enter user details:");
            Console.WriteLine("Enter user ID:");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter user Fullname:");
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter user Point:");
            Convert.ToDouble(Console.ReadLine());

            return user;
        }
    }
}
