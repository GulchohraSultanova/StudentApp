using StudentApp.Controllers;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentController controller = new StudentController();
            Console.WriteLine("----------------------WELCOME!----------------------------");
        MENU:
            Console.WriteLine("Menu: ");
            Console.WriteLine("1.Sinife element elave et!");
            Console.WriteLine("2..Sinifdeki butun sagirdleri gor!");
            Console.WriteLine("3..Sinifdeki axtarilan nomreli sagirdi gor!");
            Console.WriteLine("4..Sinifden istediyin nomreli sagirdi sil!");
            Console.WriteLine("5.Sinifden istediyin nomreli sagirdin melumatlarini deyis!");
            Console.WriteLine();
            Console.WriteLine("Seciminizi daxil edin: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    controller.AddStudent();
                    goto MENU;
                case "2":
                    controller.GetAllStudents();
                    goto MENU;
                case "3":
                    Console.WriteLine(controller.GetStudent());
                    goto MENU;
                case "4":
                    controller.DeleteStudent();
                    goto MENU;
                case "5":
                    controller.UpdateStudent();
                    goto MENU;
                case "0":
                    Console.WriteLine("Program dayandi....");
                    break;
                default:
                    Console.WriteLine("Duzgun secim daxil edin!");
                    goto MENU;
            }
        }
    }
}
