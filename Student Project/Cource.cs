namespace Student_Project
{
    class Course
    {
        private int dHours;

        public int Hours
        {
            get
            {
                return dHours;
            }
            set
            {
                if (value >= 3)
                {
                    dHours = value;
                }
            }
        }

        public int dCourseId { get; set; }

        public string CourseName { get; set; }

        public List<Course> MyStudentCoursesList { get; set; }

        public Course(string name, int dHours)
        {
            CourseName = name;
            this.dHours = dHours;
            MyStudentCoursesList = new List<Course>();
        }

        public void AddCourse(string courseName, int hours)
        {
            MyStudentCoursesList.Add(new Course(courseName, hours));
        }
    }
}