namespace Student_Project
{
    // The Enrollment class represents the enrollment details of a student in a course.
    public class Enrollment
    {
        // Property representing the student enrolled in the course.
        public Student Student { get; set; }
        
        // Property representing the course the student is enrolled in.
        public Course StudnetCourses { get; set; }
        
        // Private field to store the enrollment date and time.
        private DateTime _dateTime;
        
        // Property to get and set the enrollment date and time.
        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
            set
            {
                // Ensure the new date is not earlier than the current date.
                if (_dateTime.Date > value)
                    _dateTime = value;
            }
        }
        
        // Property representing the grade the student received in the course.
        public double Grade { get; set; }

        // Default constructor initializing properties with default values.
        public Enrollment()
        {
            // Initialize a new student object.
            Student = new Student();
            
            // Initialize a new course object using the student's name and a default value of 0 for course hours.
            StudnetCourses = new Course(Student.Name, 0);
            
            // Set the enrollment date and time to the current date and time.
            DateTime = DateTime.Now;
            
            // Initialize the grade to 0.
            Grade = 0;
        }
        
        // Copy constructor to create a new Enrollment object from an existing one.
        public Enrollment(Enrollment studentEnrollment)
        {
            // Copy the student object from the existing enrollment.
            Student = studentEnrollment.Student;
            
            // Copy the course object from the existing enrollment.
            StudnetCourses = studentEnrollment.StudnetCourses;
            
            // Copy the enrollment date and time from the existing enrollment.
            DateTime = studentEnrollment.DateTime;
            
            // Copy the grade from the existing enrollment.
            Grade = studentEnrollment.Grade;
        }
    }
}
