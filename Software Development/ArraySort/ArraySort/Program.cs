using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Пользовательский интерфейс консоли для начала работы
            Console.WriteLine("|-------------------------------------------------|");
            Console.WriteLine("|------Программа сортировки массивов данных-------|");
            Console.WriteLine("|---------сортирует вводимые целые числа----------|");
            Console.WriteLine("|может работать в консоли или в графическом режиме|");
            Console.WriteLine("|-------------------------------------------------|");
            Console.WriteLine(" выберите режим:");
            Console.WriteLine(" 1 - создать окно");
            Console.WriteLine(" иное - продолжать в консоли");
            Console.Write(" ваш выбор: ");
            
            // обработка начальной ситуации, проверка необходимости открытия окна
            int MC;
            string ModeChoose = System.Console.ReadLine();
            MC = int.Parse(ModeChoose);
            
            // формирование окна GUI? 
            if (MC == 1)
            {
                InitWindow();
                // После выполнение задачи в GUI - закрытие консоли
                return;
            }

            // Или продолжение работы в консоли
            ConsoleSolution();
        }

        static void InitWindow()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        static void ConsoleSolution()
        {
            Console.Clear();
            Console.WriteLine("Начинаем");
        }
    }
}
