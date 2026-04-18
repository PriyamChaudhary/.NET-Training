// Base constraints
public interface IStudent
{
    int StudentId { get; }
    string Name { get; }
    int Semester { get; }
}

public interface ICourse
{
    string CourseCode { get; }
    string Title { get; }
    int MaxCapacity { get; }
    int Credits { get; }
}

// 1. Generic enrollment system
public class EnrollmentSystem<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<TCourse, List<TStudent>> _enrollments = new();
    
    // TODO: Enroll student with constraints
    public bool EnrollStudent(TStudent student, TCourse course)
    {
        if (!_enrollments.ContainsKey(course))
        {
            _enrollments[course]=new List<TStudent>();
        }
        var students=_enrollments[course];

        if (students.Count >= course.MaxCapacity)
        {
            Console.WriteLine("Enrollemnt failed : Course max capacity reached");
            return false;
        }
        if (students.Contains(student))
        {
            Console.WriteLine("Student Already enrolled");
            return false;
        }
        if(course is LabCourse labCourse)
        {
            if (student.Semester < labCourse.RequiredSemester)
            {
                Console.WriteLine("Prerequisites not satisfied");
                return false;
            }
        }
        students.Add(student);
        Console.WriteLine("Enrollement Successful");
        return true;

        // Rules:
        // - Course not at capacity
        // - Student not already enrolled
        // - Student semester >= course prerequisite (if any)
        // - Return success/failure with reason
    }
    
    // TODO: Get students for course
    public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
    {
        // Return immutable list
        if(_enrollments.ContainsKey(course)){
        return _enrollments[course].AsReadOnly();
        }
        return new List<TStudent>().AsReadOnly();
    }
    
    // TODO: Get courses for student
    public IEnumerable<TCourse> GetStudentCourses(TStudent student)
    {
        // Return courses student is enrolled in
        return _enrollments.Where(e=>e.Value.Contains(student)).Select(e=>e.Key);
    }
    
    // TODO: Calculate student workload
    public int CalculateStudentWorkload(TStudent student)
    {
        // Sum credits of all enrolled courses
        return GetStudentCourses(student).Sum(c=>c.Credits);
    }
}

// 2. Specialized implementations
public class EngineeringStudent : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Semester { get; set; }
    public string Specialization { get; set; }
}

public class LabCourse : ICourse
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int MaxCapacity { get; set; }
    public int Credits { get; set; }
    public string LabEquipment { get; set; }
    public int RequiredSemester { get; set; } // Prerequisite
}

// 3. Generic gradebook
public class GradeBook<TStudent, TCourse>
where TStudent : IStudent
where TCourse : ICourse
{
    private Dictionary<(TStudent, TCourse), double> _grades = new();
    private EnrollmentSystem<TStudent, TCourse> _enrollmentSystem;

    public GradeBook(EnrollmentSystem<TStudent, TCourse> enrollmentSystem)
    {
        _enrollmentSystem=enrollmentSystem;
    }
    
    // TODO: Add grade with validation
    public void AddGrade(TStudent student, TCourse course, double grade)
    {
        // Grade must be between 0 and 100
        if(grade<0 || grade > 100)
        {
            Console.WriteLine("Invalid grade");
        }
        // Student must be enrolled in course  NOT POSSIBLE WITHOUT ENROLLEMENT DATA IN THIS CLASS
        _grades[(student, course)]=grade;
    }
    
    // TODO: Calculate GPA for student
    public double? CalculateGPA(TStudent student)
    {
        // Weighted by course credits
        // Return null if no grades
        var studentGrades=_grades.Where(g=>g.Key.Item1.StudentId==student.StudentId).ToList();
        if (!studentGrades.Any())
        {
            return null;
        }
        double totalCredits=studentGrades.Sum(g=>g.Key.Item2.Credits);
        double totalWeighted=studentGrades.Sum(g=>g.Value*g.Key.Item2.Credits);
        return totalWeighted/totalCredits;

    }
    
    // TODO: Find top student in course
    public (TStudent student, double grade)? GetTopStudent(TCourse course)
    {
        // Return student with highest grade
        var courseGrades=_grades.Where(g=>g.Key.Item2.CourseCode==course.CourseCode).ToList();
        var top=courseGrades.OrderByDescending(g=>g.Value).First();
        return (top.Key.Item1, top.Value);

    }
}

// 4. TEST SCENARIO: Create a simulation
// a) Create 3 EngineeringStudent instances
// b) Create 2 LabCourse instances with prerequisites
// c) Demonstrate:
//    - Successful enrollment
//    - Failed enrollment (capacity, prerequisite)
//    - Grade assignment
//    - GPA calculation
//    - Top student per course
