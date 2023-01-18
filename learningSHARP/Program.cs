using System;

namespace learningSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace learningSHARP
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // BANK ACCOUNT APP
                int[] amount = new int[0];
                string[] operation = new string[0];
                int balance = 0;

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Тинькофф Банк");
                    Console.ResetColor();

                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine($"Ваш баланс: {balance}");

                    Console.WriteLine("Что вы хотите сделать с счётом?\n" +
                        "1. Внести наличные\n" +
                        "2. Получить наличные в банкомате\n" +
                        "3. Сделать перевод\n" +
                        "4. Посмотреть историю операций.");

                    string userChoise = Console.ReadLine();
                    switch (userChoise)
                    {
                        case "1":
                            Console.WriteLine("Введите сумму для внесения через банкомат: ");
                            int amountAdd = Convert.ToInt32(Console.ReadLine());
                            if (amountAdd > 0)
                            {
                                balance = balance + amountAdd;
                                Array.Resize(ref amount, amount.Length + 1);
                                Array.Resize(ref operation, operation.Length + 1);
                                amount[amount.Length - 1] = amountAdd;
                                operation[operation.Length - 1] = "Внесение наличных.";
                                Console.WriteLine("Наличные успешно внесены. \nНажмите любую клавишу для продожения.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Ошибка внесения наличных, введите верную сумму.\n" +
                                    "Нажмите любую клавишу для продожения.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;

                        case "2":
                            Console.WriteLine("Введите сумму для получения наличных:");
                            int amountGetCash = Convert.ToInt32(Console.ReadLine());
                            if (balance > amountGetCash)
                            {
                                balance = balance - amountGetCash;
                                Array.Resize(ref amount, amount.Length + 1);
                                Array.Resize(ref operation, operation.Length + 1);
                                amount[amount.Length - 1] = amountGetCash;
                                operation[operation.Length - 1] = "Получение наличных.";
                                Console.WriteLine("Получите ваши наличные в блишайшем банкомате по QR коду, отправленному вам на почту.\n" +
                                    "Приятного пользования нашим банком!\nНажмите любую клавишу для продожения.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Ошибка. Вашего баланса не хватает для снятия наличных.\nНажмите любую клавишу для продожения.");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;

                        case "3":
                            Console.WriteLine("Введите, кому вы хотите сделать перевод.");
                            string recipientName = Console.ReadLine();
                            Console.WriteLine("Введите сумму перевода.");
                            int amountTransfer = Convert.ToInt32(Console.ReadLine());
                            if (balance > amountTransfer)
                            {
                                balance = balance - amountTransfer;
                                Array.Resize(ref amount, amount.Length + 1);
                                Array.Resize(ref operation, operation.Length + 1);
                                amount[amount.Length - 1] = amountTransfer;
                                operation[operation.Length - 1] = "Перевод средств.";
                                Console.WriteLine("Перевод успешно выполнен.\nНажмите любую клавишу для продолжения.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода.\nНажмите любую клавишу для продолжения.");
                                Console.ReadKey();
                            }
                            Console.Clear();

                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Ваша история операций.\nНажмите любую клавишу для продожения.");
                            int x = 5;
                            int y = 10;
                            for (int i = 0; i < amount.Length; i++)
                            {
                                Console.SetCursorPosition(x, y++);
                                Console.Write(amount[i] + " | ");
                                Console.WriteLine(operation[i]);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;




                        default:
                            Console.WriteLine("Вы ввели не верный вариант.\nНажмите любую клавишу для продожения.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }

            }
        }
    }
}
    }
}
