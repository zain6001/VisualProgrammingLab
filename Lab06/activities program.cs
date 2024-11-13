using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6ac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary where key is a string (name) and value is a list of integers (marks)
            Dictionary<string, List<int>> studentsDictionary = new Dictionary<string, List<int>>()
            {
                { "Alice", new List<int> { 85, 90, 88 } },   // Alice's marks
                { "Bob", new List<int> { 78, 82, 91 } },     // Bob's marks
                { "Charlie", new List<int> { 92, 87, 94 } }  // Charlie's marks
            };

            DisplayDictionary(studentsDictionary);

            // Adding a new student and their marks
            AddStudent(studentsDictionary, "David", new List<int> { 88, 93, 85 });

            // Removing a student and their marks
            RemoveStudent(studentsDictionary, "Bob");

            // Displaying the students in ascending order of average grades
            Console.WriteLine("\nStudents sorted by ascending average grade:");
            DisplaySortedByAverage(studentsDictionary, ascending: true);

            // Displaying the students in descending order of average grades
            Console.WriteLine("\nStudents sorted by descending average grade:");
            DisplaySortedByAverage(studentsDictionary, ascending: false);

            // Displaying the highest and lowest average students
            DisplayHighestAndLowestAverage(studentsDictionary);

            // Displaying the final dictionary with averages
            Console.WriteLine("\nFinal student records with average grades:");
            DisplayDictionary(studentsDictionary);

            Console.ReadLine();
        }

        // Method to display the dictionary along with average grades
        static void DisplayDictionary(Dictionary<string, List<int>> dict)
        {
            Console.WriteLine("\nStudent names, their marks, and average grade:");
            foreach (var entry in dict)
            {
                double average = CalculateAverageGrade(entry.Value);
                Console.WriteLine($"{entry.Key}: Marks: {string.Join(", ", entry.Value)} | Average grade: {average:F2}");
            }
        }

        // Method to add a new student and their marks to the dictionary
        static void AddStudent(Dictionary<string, List<int>> dict, string name, List<int> marks)
        {
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, marks);
                Console.WriteLine($"\n{name} has been added with marks {string.Join(", ", marks)}.");
            }
            else
            {
                Console.WriteLine($"\n{name} already exists.");
            }

            DisplayDictionary(dict);
        }

        // Method to remove a student and their marks from the dictionary
        static void RemoveStudent(Dictionary<string, List<int>> dict, string name)
        {
            if (dict.ContainsKey(name))
            {
                dict.Remove(name);
                Console.WriteLine($"\n{name} has been removed from the dictionary.");
            }
            else
            {
                Console.WriteLine($"\n{name} not found in the dictionary.");
            }

            DisplayDictionary(dict);
        }

        // Simple method to calculate and return the average grade of a student
        static double CalculateAverageGrade(List<int> marks)
        {
            if (marks.Count == 0) return 0;

            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;  // Add each mark to the sum
            }

            return (double)sum / marks.Count;  // Calculate and return the average
        }

        // Method to display students sorted by their average grades
        static void DisplaySortedByAverage(Dictionary<string, List<int>> dict, bool ascending)
        {
            // Sort students based on their average grade
            var sortedStudents = dict
                .Select(entry => new
                {
                    Name = entry.Key,
                    Average = CalculateAverageGrade(entry.Value)
                })
                .OrderBy(student => student.Average)
                .ToList();

            if (!ascending)
            {
                sortedStudents.Reverse();  // Reverse the list for descending order
            }

            // Display the sorted students
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name}: Average grade: {student.Average:F2}");
            }
        }

        // Method to display the student with the highest and lowest average grades
        static void DisplayHighestAndLowestAverage(Dictionary<string, List<int>> dict)
        {
            // Calculate averages and order students
            var sortedStudents = dict
                .Select(entry => new
                {
                    Name = entry.Key,
                    Average = CalculateAverageGrade(entry.Value)
                })
                .OrderBy(student => student.Average)
                .ToList();

            // Display the student with the lowest average
            var lowestStudent = sortedStudents.First();
            Console.WriteLine($"\nStudent with the lowest average grade: {lowestStudent.Name} | Average grade: {lowestStudent.Average:F2}");

            // Display the student with the highest average
            var highestStudent = sortedStudents.Last();
            Console.WriteLine($"Student with the highest average grade: {highestStudent.Name} | Average grade: {highestStudent.Average:F2}");
        }
    }
}
