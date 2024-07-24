namespace Student_Project
{
    public class MyMainHardware
    {
        // Properties to store course information and enrollment details
        private string sCourses;
        private Enrollment enrollment;
        private Course course1;
        private int dGrade = 0;

        public static void Main(string[] args)
        {
            // Create an object from the MyMainHardware class
            MyMainHardware main = new MyMainHardware();

            // Call the GetUserInfo method to start user interaction
            main.GetUserInfo();
        }

        /// <summary>
        /// This method gets user information and stores it in a generic list type string.
        /// It creates a student object, welcomes the user to the application, and prompts the user to enter their name.
        /// </summary>
        public void GetUserInfo()
        {
            // Create a student object
            Student myStudents = new Student();

            // Display a welcome message
            DisplayMessageField("Welcome to my student info program!");

            // Prompt the user to enter their name
            DisplayMessageField("Please enter your name...");
            myStudents.Name = Console.ReadLine();

            int dUserAge = 0;

            // Loop to prompt the user to enter their age until a valid age (18 or older) is entered
            while (true)
            {
                DisplayMessageField("Please enter your age...");

                if (int.TryParse(Console.ReadLine(), out dUserAge) && dUserAge >= 18)
                {
                    // If the age is valid, store it in the student's Age property
                    myStudents.Age = dUserAge;
                    break;
                }

                // Display an error message if the age is invalid
                DisplayErrorMessageField("Please enter a valid number");
            }

            // Prompt the user to enter their ID
            DisplayMessageField("Please enter your ID...");
            int dId = 0;

            if (!int.TryParse(Console.ReadLine(), out dId))
            {
                // Display an error message if the ID is invalid and return
                DisplayErrorMessageField("Please enter a valid ID");
                return;
            }

            // If the ID is valid, store it in the student's dStudentId property
            myStudents.dStudentId = dId;

            // Prompt the user to enter their major
            DisplayMessageField("Please enter your Major...");
            myStudents.Major = new Major(Console.ReadLine(), "Keith");

            bool bIsEnded = false;
            int dClassHours = 0;

            // Ask the user about their courses
            DisplayMessageField("Now I'm going to ask you about your courses...\n");

            while (!bIsEnded)
            {
                DisplayMessageField("Please enter your course name or press (n) to exit:");
                sCourses = Console.ReadLine().ToUpper();

                if (sCourses.Equals("N"))
                {
                    bIsEnded = true;
                }
                else
                {
                    // Prompt the user to enter course hours
                    DisplayMessageField("Please enter course hours:");
                    if (!int.TryParse(Console.ReadLine(), out dClassHours))
                    {
                        // Display an error message if the input is invalid
                        DisplayErrorMessageField("Invalid input. Please try again.");
                        continue;
                    }

                    // Ask the user to enter the course grade
                    DisplayMessageField("Please enter course grade:");
                    if (!int.TryParse(Console.ReadLine(), out dGrade))
                    {
                        // Display an error message if the input is invalid
                        DisplayErrorMessageField("Please enter a valid number");
                        continue;
                    }

                    // Add the course to the student
                    AddingObject(myStudents, dClassHours);
                }
            }

            // Print the student details and their courses
            myStudents.Print();
            myStudents.PrintCourses();
        }

        /// <summary>
        /// This method adds a course to a student object with the specified class hours.
        /// </summary>
        /// <param name="student">The student object to add the course to.</param>
        /// <param name="dClassHours">The number of class hours for the course.</param>
        public void AddingObject(Student student, int dClassHours)
        {
            // Create a new course object with the course name and class hours
            course1 = new Course(sCourses, dClassHours);

            // Create a new enrollment object with the student, course, and current date
            enrollment = new Enrollment
            {
                Student = student,
                Grade = dGrade,
                StudnetCourses = course1,
                DateTime = DateTime.Now
            };

            // Add the enrollment object to the student's courses list
            student.AddCourses(enrollment);

            // Display a message indicating the course was added successfully
            DisplayMessageField(sCourses + " added successfully");
        }

        /// <summary>
        /// This method displays a message surrounded by a border of asterisks.
        /// </summary>
        /// <param name="sMessageField">The message to display.</param>
        public void DisplayMessageField(string sMessageField)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine(sMessageField);
            Console.WriteLine("**********************************************");
        }

        /// <summary>
        /// This method displays an error message surrounded by a border of x's.
        /// </summary>
        /// <param name="sMessageField">The error message to display.</param>
        public void DisplayErrorMessageField(string sMessageField)
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine(sMessageField);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
    }
}
