using System;
using System.Collections.Generic;
using Student_Project;

public class Student
{
    // Auto-implemented property for Student ID
    public int dStudentId { get; set; }

    // Backing field for the Name property
    private string sName;

    // Property for Name with validation in the setter
    public string Name
    {
        get { return sName; }
        set
        {
            if (value.Length <= 20) // Ensure the name length is 20 characters or less
                sName = value;
        }
    }

    // Auto-implemented property for Major
    public Major Major { get; set; }

    // Backing field for the Age property
    private int dAge;

    // Property for Age with validation in the setter
    public int Age
    {
        get { return dAge; }
        set
        {
            if (value >= 18) // Ensure the age is 18 or older
                dAge = value;
            else
                Console.WriteLine("Your age did not match the requirement.");
        }
    }

    // Readonly property for CoursesList
    public List<Enrollment> CoursesList { get; }

    // Default constructor initializing properties
    public Student()
    {
        dStudentId = 0;
        dAge = 0;
        CoursesList = new List<Enrollment>();
        Major = new Major("", "");
    }

    // Copy constructor to create a new Student from an existing one
    public Student(Student myStudent)
    {
        this.dStudentId = myStudent.dStudentId;
        this.sName = myStudent.sName;
        this.dAge = myStudent.dAge;
        Major = new Major(myStudent.Major.sMajorName, myStudent.Major.sDrName);

        // Creating a new list from the existing list
        CoursesList = new List<Enrollment>(myStudent.CoursesList);
    }

    // Parameterized constructor to initialize properties with given values
    public Student(string sName, int dAge, string major, String sMajorSName)
    {
        Name = sName;
        Age = dAge;
        Major = new Major(major, sMajorSName);
        CoursesList = new List<Enrollment>();
    }

    // Method to print student details
    public void Print()
    {
        Console.WriteLine($"""
                           ************ Student's information ******
                           Student name: {Name}
                           Student major: {Major.sMajorName}
                           Student age: {Age}
                           *****************************************
                           """);
    }

    // Method to add a course to the CoursesList
    public void AddCourses(String sCourseName, double grade)
    {
        Enrollment studentEnrollment = new Enrollment();

        // Adding all the fields of the student class inside the object of studentEnrollment.
        studentEnrollment.Student = this;

        studentEnrollment.StudnetCourses = new Course(sCourseName, 10);

        studentEnrollment.DateTime = DateTime.Now;

        studentEnrollment.Grade = grade;

        CoursesList.Add(studentEnrollment);
    }

    public void AddCourses(Enrollment myCourse)
    {
        CoursesList.Add(myCourse);
    }

    // Method to print the list of courses
    public void PrintCourses()
    {

        int courseNum = 0;
        Console.WriteLine("********* Your Courses **********");
        Console.WriteLine($""""
                           Name: {sName}
                           """");
        foreach (var sStudentCourses in CoursesList)
        {
            courseNum++;
            Console.WriteLine($"""
                              Course number {courseNum}: {sStudentCourses.StudnetCourses.CourseName}
                              """);
        }
        Console.WriteLine("*********************************");
    }
}
