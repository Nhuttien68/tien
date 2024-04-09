using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Student
    {
        private Dictionary<int, string> studentDictionary;

        public Student()
        {
            studentDictionary = new Dictionary<int, string>();
        }

        public void AddStudent(int studentID, string studentName)
        {
            if (!studentDictionary.ContainsKey(studentID))
            {
                studentDictionary.Add(studentID, studentName);
                Console.WriteLine($"Sinh vien co ma {studentID} da duoc them.");
            }
            else
            {
                Console.WriteLine($"Sinh vien co ma {studentID} da ton tai trong danh sach.");
            }
        }

        public string GetStudentInfo(int studentID)
        {
            if (studentDictionary.ContainsKey(studentID))
            {
                return studentDictionary[studentID];
            }
            else
            {
                return $"Khong tim thay sinh vien co ma {studentID} trong danh sach.";
            }
        }
    }
}

