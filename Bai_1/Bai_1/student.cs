class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }

    public Student(int id, string name)
    {
        StudentID = id;
        StudentName = name;
    }

    public override string ToString()
    {
        return $"Student ID: {StudentID}, Student Name: {StudentName}";
    }
}