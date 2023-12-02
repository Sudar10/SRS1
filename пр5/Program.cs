using HashPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using пр5.models;

namespace пр5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NapitkiEntities napitkiEntities = new NapitkiEntities();
                       
            Console.WriteLine("Ввежите имя пользователя: ");
            string Name = Console.ReadLine();     
            while(Name == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                Name = Console.ReadLine();
            }

            Console.WriteLine("Ввежите фамилию пользователя: ");
            string Surname = Console.ReadLine();
            while (Surname == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                Surname = Console.ReadLine();
            }

            Console.WriteLine("Ввежите Отчество пользователя: ");
            string Patronomyc = Console.ReadLine();
            while (Patronomyc == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                Patronomyc = Console.ReadLine();
            }

            int idpost;

            while (true)
            {
                Console.WriteLine("Введите ID должности\n1 - Бухгалтер 2 - Менеджер 3 - Директор 4 - Управляющий:");
                var idPost = Console.ReadLine();
                if (int.TryParse(idPost, out idpost))
                {
                    if (idpost >= 1 && idpost <= 4) break;
                }
                
            }

            Console.WriteLine("Ввежите Email пользователя: ");
            string Email = Console.ReadLine();
            while (Email == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                Email = Console.ReadLine();
            }

            Console.WriteLine("Ввежите серию паспорта пользователя: ");
            string PassS = Console.ReadLine();
            while (PassS == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                PassS = Console.ReadLine();
            }

            Console.WriteLine("Ввежите номер паспорта пользователя: ");
            string PassN = Console.ReadLine();
            while (PassN == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                PassN = Console.ReadLine();
            }

            Console.WriteLine("Ввежите логин пользователя: ");
            string login = Console.ReadLine();
            while (login == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                login = Console.ReadLine();
            }

            Console.WriteLine("Ввежите пароль пользователя: ");
            string password = Console.ReadLine();
            while (password == string.Empty)
            {
                Console.WriteLine("Повторите ввод, введено пустое значение.");
                password = Console.ReadLine();
            }

            hash hasher = new hash();
            string hashpassword = hasher.Hashh(password);
            Console.WriteLine(hashpassword);
            var sot = new models.Sotrudnik
            {

                Name = Name,
                Familia = Surname,
                Otchestvo = Patronomyc,
                IDDolznost = idpost,
                Email = Email,
                PasportNumber = PassN,
                PasportSeries = PassS,
                
            };
            napitkiEntities.Sotrudnik.Add(sot);
            napitkiEntities.SaveChanges();

            var users = new models.Users
            {
                ID = sot.ID,
                Login = login,
                Parol = hashpassword
            };
            napitkiEntities.Users.Add(users);
            napitkiEntities.SaveChanges();
                        
            Console.WriteLine("Учетная запись добавлена");
            Console.WriteLine($"Логин сотрудника {login} Пароль сотрудника {hashpassword}");

            Console.WriteLine("Нажмите Enter для закрытия окна.");
            Console.ReadLine();
        }
    }
}
