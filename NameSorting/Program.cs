using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> unsortedName = new List<String>();
            List<String> unsortedLastName = new List<String>();
            List<String> fullNameList = new List<String>();

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\venkiJ\Documents\Jaya\NameSorting\unsorted-names-list.txt");
            using StreamWriter file = new(@"C:\Users\venkiJ\Documents\Jaya\NameSorting\sorted-names-list.txt");

            // Getting the names from File to List
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                unsortedName.Add(line);
            }

            // Getting the Last Name from Full Name
            for (int i = 0; i < unsortedName.Count; i++)
            {
                string[] parts = unsortedName[i].Split(' ');
                string lastName = parts[parts.Length - 1];

                unsortedLastName.Add(lastName);
            }

            // Sorting the Last Name
            unsortedLastName.Sort();

            // Sorting the Full Name, Printing in console 
            for (int i = 0; i < unsortedLastName.Count; i++)
            {

                for (int j = 0; j < unsortedName.Count; j++)
                {
                    string[] parts = unsortedName[j].Split(' ');
                    string lastName = parts[parts.Length - 1];
                    string FullName;

                    if (lastName == unsortedLastName[i])
                    {
                        Console.WriteLine("\t" + unsortedName[j]);
                        FullName = unsortedName[j];
                        fullNameList.Add(FullName);

                    }
                }

            }

            // Writing in to new file sorted names list
            System.IO.File.WriteAllLines(@"/Users/manikandan/Documents/Jaya/sorted-names-list.txt", fullNameList);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
