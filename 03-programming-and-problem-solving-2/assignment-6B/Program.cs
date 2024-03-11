using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6B
{
    class Program
    {
        static void StartUpCode()
        {
            char answer = 'y';
            do
            {
                Console.Write("What is the name of the existing file? "); // textfile.txt
                string original = Console.ReadLine();
                Console.Write("What is the name of the copy file? ");
                string copy = Console.ReadLine();
                try
                {
                    using (var reader = new StreamReader(@original))
                        if (File.Exists(copy) == true)
                        {
                            Console.Write($"Do you wish to overwrite the existing file {copy}?(y/n) ");
                            char reply = Console.ReadKey().KeyChar;
                            if (reply == 'y')
                            {
                                using (var writer = new StreamWriter(@copy, append: false))
                                {
                                    writer.Write(reader.ReadToEnd());
                                }
                            }
                            else if (reply == 'n')
                            {
                                Console.WriteLine();
                                Console.Write($"Please enter another name for {original} to be copied too. ");
                                string newName = Console.ReadLine();
                                using (var reader2 = new StreamReader(original))
                                using (var writer2 = new StreamWriter(@newName, append: false))
                                {
                                    writer2.Write(reader.ReadToEnd());
                                }
                                copy = newName;
                            }
                            else
                            {
                                Console.WriteLine("You did not enter a 'y' or 'n'.");
                                answer = 'n';
                            }
                        }
                        else
                        {
                            using (var writer = new StreamWriter(@copy, append: false))
                            {
                                writer.Write(reader.ReadToEnd());
                            }
                            Console.WriteLine($"New file {copy} was created.");
                        }
                }

                catch (System.Exception e)
                {
                    Console.WriteLine($"Unable to locate existing file {original}");
                    Console.Write("Again?(y/n) ");
                    answer = Console.ReadKey().KeyChar;
                    if (answer == 'y')
                    {
                        Console.WriteLine();
                        StartUpCode();
                    }
                    else
                    {
                        break;
                    }
                }
                if (answer == 'y')
                {
                    Console.WriteLine();
                    Console.WriteLine("The copy was successfully!");
                    Console.WriteLine($"Original file: {original}\nCopy file: {copy}");
                    Console.Write("Again?(y/n) ");
                    answer = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            } while (answer == 'y');
            Console.WriteLine();
            Console.WriteLine("Thank you – end of program.");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            StartUpCode();
        }
    }
}
