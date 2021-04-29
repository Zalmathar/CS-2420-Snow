using HashMap;
using System;
using System.Diagnostics;

namespace DataU
{

    public interface DataU
    {
        Student Get(int id);
        Student Get(string name);
        void Put(Student student);
    }

    public class Student
    {
        public int id;
        public string name;
        public double gpa;

        public Student(int id, string name, double gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }
    }

    public class StudentDB : DataU
    {

        HashMap<int, Student> dataB;

        public StudentDB()
        {
            dataB = new HashMap<int, Student>(10);
        }
        public Student Get(int id)
        {
            // TODO: 
            return dataB.get(id);
        }

        public Student Get(string name)
        {
            // TODO: 
            foreach (Student student in dataB.values())
            {
                if (student.name == name)
                {
                    return student;
                }
            }
            return null; // if not found return null
        }

        public void Put(Student student)
        {
            dataB.put(student.id, student);
        }
    }

    public class StudentDBTest
    {
        public static void RunTests()
        {
            StudentDB db = new StudentDB();
            testPut(db);
        }

        private static void testPut(StudentDB db)
        {
            Student student1 = new Student(1, "one", 4.0);
            Student student2 = new Student(2, "two", 4.0);
            Student student3 = new Student(3, "three", 4.0);
            Student student4 = new Student(4, "four", 4.0);
            Student student5 = new Student(5, "five", 4.0);
            Student student6 = new Student(6, "six", 4.0);
            Student student7 = new Student(7, "seven", 4.0);
            Student student8 = new Student(8, "eight", 4.0);
            Student student9 = new Student(9, "nine", 4.0);
            Student student10 = new Student(10, "ten", 4.0);
            Student student11 = new Student(11, "eleven", 4.0);
            Student student12 = new Student(12, "twelve", 4.0);
            try
            {

                db.Put(student1);
                db.Put(student2);
                db.Put(student3);
                db.Put(student4);
                db.Put(student5);
                db.Put(student6);
                db.Put(student7);
                db.Put(student8);
                db.Put(student9);
                db.Put(student10);
                db.Put(student11);
                db.Put(student12);
            }
            catch (Exception e)
            {
                Console.WriteLine($"test DatU Put Failed. {e.Message}");
            }

            try
            {
                Debug.Assert(db.Get(1) == student1);
                Debug.Assert(db.Get(2) == student2);
                Debug.Assert(db.Get(3) == student3);
                Debug.Assert(db.Get(4) == student4);
                Debug.Assert(db.Get(5) == student5);
                Debug.Assert(db.Get(6) == student6);
                Debug.Assert(db.Get(7) == student7);
                Debug.Assert(db.Get(8) == student8);
                Debug.Assert(db.Get(9) == student9);
                Debug.Assert(db.Get(10) == student10);
                Debug.Assert(db.Get(11) == student11);
                Debug.Assert(db.Get(12) == student12);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Test DatU GetKey Failed. {e.Message}");
            }

            try
            {
                Debug.Assert(db.Get("one") == student1);
                Debug.Assert(db.Get("two") == student2);
                Debug.Assert(db.Get("three") == student3);
                Debug.Assert(db.Get("four") == student4);
                Debug.Assert(db.Get("five") == student5);
                Debug.Assert(db.Get("six") == student6);
                Debug.Assert(db.Get("seven") == student7);
                Debug.Assert(db.Get("eight") == student8);
                Debug.Assert(db.Get("nine") == student9);
                Debug.Assert(db.Get("ten") == student10);
                Debug.Assert(db.Get("eleven") == student11);
                Debug.Assert(db.Get("twelve") == student12);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Test DatU GetValue failed. {e.Message}");
            }
        }
    }
}