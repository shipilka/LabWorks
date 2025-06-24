// Task1/Program.cs
using System;
using System.ComponentModel;
using Task1;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                User user = new User { Login = "initialLogin", Password = "initialPassword" };

                user.PropertyChanged += (sender, e) =>
                {
                    Console.WriteLine($"Свойство '{e.PropertyName}' было изменено.");
                };

                user.Login = "newLogin";
                user.Password = "newPassword";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nНажмите любую клавишу для завершения...");
                Console.ReadKey();
            }
        }
    }
}