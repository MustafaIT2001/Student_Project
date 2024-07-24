namespace Student_Project
{
    public class Course
    {
        // Backing field for the Hours property
        private int dHours;
        
        // Property for Hours with validation in the setter
        public int Hours
        {
            get
            {
                return dHours;
            }
            set
            {
                if (value >= 3) // Ensure the course hours are 3 or more
                {
                    dHours = value;
                }
            }
        }

        // Readonly property for Course ID
        public int dCourseId { get; }

        // Readonly property for Course Name
        public string CourseName { get; }

        // List to hold student courses
        public List<Course> MyStudentCoursesList;

        // Parameterized constructor to initialize properties with given values
        public Course(string name, int dHours)
        {
            CourseName = name;
            Hours = dHours;
            MyStudentCoursesList = new List<Course>();
        }

        // Copy constructor to create a new Course from an existing one
        public Course(Course myCourse)
        {
            CourseName = myCourse.CourseName;
            dCourseId = myCourse.dCourseId;
            Hours = myCourse.Hours;
        }
    }
}