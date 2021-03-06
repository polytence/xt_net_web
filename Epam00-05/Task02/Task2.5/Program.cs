﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Artem = new Employee("", new DateTime(2004, 07, 24), "Artem", "Danilkin", "Ur'evich", new DateTime(1997, 07, 24));
            Console.WriteLine("Фамилия: " + Artem.SecondName + " Имя: " + Artem.FirstName + " Отчество: " + Artem.Patronymic);
            Console.WriteLine("Дата рождения: " + Artem.Birthday.ToLongDateString() + " Возраст: " + Artem.Age());
            Artem.Position = "junior";
            Console.WriteLine("Должность: " + Artem.Position + " Стаж: " + Artem.Experience());
         }
    }
        class User
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string Patronymic { get; set; }
            public DateTime Birthday { get; set; }

            public int Age()
            {
                int CalculationAge = DateTime.Now.Year - Birthday.Year;
                return CalculationAge;
            }
            public int UserAge { get { return Age(); } }
            void NewUser(string UserFirstName, string UserSecondName, string UserPatronymic, DateTime UserBirthday)
            {
                FirstName = UserFirstName;
                SecondName = UserSecondName;
                Patronymic = UserPatronymic;
                Birthday = UserBirthday;
            }
            public User(string UserFirstName, string UserSecondName, string UserPatronymic, DateTime UserBirthday)
            {
                NewUser(UserFirstName, UserSecondName, UserPatronymic, UserBirthday);
            }
        }
    
}

