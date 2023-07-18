using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {

                try
                {
                    Console.WriteLine("** welcome to User Registration System **");

                    // Prompt user for input
                    Console.Write("Enter your Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter your E-mail: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter your Password: ");
                    string password = Console.ReadLine();

                    // Validate user input
                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ValidationException("Name is required.");
                    }

                    if (string.IsNullOrEmpty(email))
                    {
                        throw new ValidationException("Email is required.");
                    }

                    if (string.IsNullOrEmpty(password))
                    {
                        throw new ValidationException("Password is required.");
                    }

                    if (name.Length < 6)
                    {
                        throw new ValidationException("Name must have at least 6 characters.");
                    }

                    if (password.Length < 8)
                    {
                        throw new ValidationException("Password must have at least 8 characters.");
                    }

                    // Registration successful
                    Console.WriteLine("User registration success.");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Email: " + email);
                    Console.WriteLine("Password: " + password);
                }
                catch (ValidationException ex)
                {
                    // Validation exception occurred
                    Console.WriteLine("Validation error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Other exceptions occurred
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                Console.ReadKey();

            }
        }
    }
