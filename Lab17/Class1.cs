using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class  BankAccount<T>
    {
        private int balance;
        private string name;
        private T number;
        public int Balance { get { return balance; } set { balance = value; } }
        public string Name { get { return name; } set { name = value; } }
        public T Number { get { return number; } set { number = value; } }

        public void Input() 
        {
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номер счета");
            Number = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс");
            Balance= Convert.ToInt32(Console.ReadLine());

        }

        public void GetInfo() 
        {
            Console.WriteLine($"Фио:{Name}, Номер счета:{Number}, Баланс счета:{Balance}");
        }
    }
}
