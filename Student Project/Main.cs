namespace Student_Project;

public class MyMainHardware
{
    private String sCourses;

    public static void Main(String[] args)
    {
        MyMainHardware Main = new MyMainHardware();

        Main.GetUserInfo();
    }

    /// <summary>
    /// Get the info that the user is going to put and store them in a generic list type string.
    /// </summary>
    public void GetUserInfo()
    {
        Student myStudents = new Student();

        DisplayMessageField("Welcome to my student info program!");

        DisplayMessageField("Please enter your name...");

        myStudents.Name = Console.ReadLine();


        int dUserAge = 0;
        while (true)
        {
            DisplayMessageField("Please enter your age...");

            if (int.TryParse(Console.ReadLine(), out dUserAge) && dUserAge >= 18)
            {
                myStudents.Age = dUserAge;
                break;
            }

            DisplayErrorMessageField("Please enter a valid number");

        }
        
        DisplayMessageField("Please enter your id");
        int dId = 0;

        if (!int.TryParse(Console.ReadLine(), out dId))
        {
            DisplayErrorMessageField("Please enter a valid ID");
            return;
        }

        myStudents.dStudentId = dId;


        DisplayMessageField("Please enter your Major...");
        

        myStudents.Major = new Major(Console.ReadLine(), "");

        bool bIsEnded = false;

        while (!bIsEnded)
        {
            DisplayMessageField("Please enter your course name... (n to stop. Anything else will add.");
            sCourses = Console.ReadLine().ToLower();
            if (!sCourses.Equals("n"))
            {
                myStudents.AddCourses(sCourses);
                DisplayMessageField(sCourses + " Added successfully");
            }
            else
            {

                bIsEnded = true;
            }

        }


        int dHours;
        char myChar;
        String sCourseName;

        bIsEnded = true;

        while (true)
        {
            DisplayMessageField("Please enter the courses names... Please press q to quit After you finish");
            sCourseName = Console.ReadLine();

            DisplayMessageField("Please enter the hours... ");
            bIsEnded = int.TryParse(Console.ReadLine(), out dHours);
            if (!bIsEnded)
            {
                DisplayErrorMessageField("Invalid input. Please try again");
                break;

            }
            
            if (dHours <= 3)
            {
                DisplayErrorMessageField("Invalid input. Please try again"); 
                break;
            }
                


            Course myStudentCourses = new Course(sCourseName, dHours);
            myStudentCourses.MyStudentCoursesList.Add(myStudentCourses);
            DisplayMessageField("Added Successfully");

            DisplayMessageField(
                "Please press q to quit After you finish. Press any other letter to add new courses and hours");

            myChar = Convert.ToChar(Console.ReadLine());

            if (myChar == 'q')
            {
                break;
            }
        }
        
        myStudents.Print();

        myStudents.PrintCourses();

    }

    public void DisplayMessageField(String sMessageField)
    {
        Console.WriteLine("**********************************************");
        Console.WriteLine(sMessageField);
        Console.WriteLine("**********************************************");
        
    }

    public void DisplayErrorMessageField(String sMessageField)
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine(sMessageField);
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        
    }
}