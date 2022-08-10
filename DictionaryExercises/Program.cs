using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newID;
            string studentName;

            Console.WriteLine("Enter your students' names and ID numbers (or ENTER to finish):");
            do
            {
                Console.WriteLine("ID: ");
                newID = Console.ReadLine();

                if (!Equals(newID, ""))
                {
                    Console.WriteLine("Student Name: ");
                    studentName = Console.ReadLine();
                    students.Add(int.Parse(newID), studentName);
                }

            } while (!Equals(newID, ""));

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }

            Console.WriteLine("Number of students in roster: " + students.Count);
        }
    }
}

