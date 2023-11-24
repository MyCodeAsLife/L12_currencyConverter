using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L12_currencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandRubToUsd = "1";
            const string CommandRubToEur = "2";
            const string CommandEurToUsd = "3";
            const string CommandEurToRub = "4";
            const string CommandUsdToRub = "5";
            const string CommandUsdToEur = "6";

            float rubToUsd = 88.15f;
            float rubToEur = 96.26f;
            float eurToUsd = 0.92f;
            float eurToRub = 0.01f;
            float usdToRub = 0.11f;
            float usdToEur = 1.09f;
            bool isOpen = true;
            float rubleWallet;
            float dollarWallet;
            float euroWallet;
            float amountOfMoneyToConvert;
            string selectCommand;

            Console.Write("Введите количество рублей: ");
            rubleWallet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество долларов: ");
            dollarWallet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество евро: ");
            euroWallet = Convert.ToInt32(Console.ReadLine());

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в обменник.");
                Console.WriteLine($"У вас на счетах: {rubleWallet} рублей. {dollarWallet} долларов. {euroWallet} евро.\n");
                Console.WriteLine("Выберите одну из следующих операций(введите номер операции):\n1 - Обменять рубли на долары\t" +
                                  "2 - Обменять рубли на евро\n3 - Обменять евро на доллары\t4 - Обменять евро на рубли\n" +
                                  "5 - Обменять доллары на рубли\t6 - Обменять доллары на евро\nДля выхода, введите exit");
                selectCommand = Console.ReadLine();

                switch (selectCommand)
                {
                    case CommandExit:
                        isOpen = false;
                        break;
                    case CommandRubToUsd:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());
                        if (amountOfMoneyToConvert < rubleWallet)
                        {
                            rubleWallet -= amountOfMoneyToConvert;
                            dollarWallet += amountOfMoneyToConvert / rubToUsd;
                        }
                        break;
                    case CommandRubToEur:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());
                        if (amountOfMoneyToConvert < rubleWallet)
                        {
                            rubleWallet -= amountOfMoneyToConvert;
                            euroWallet += amountOfMoneyToConvert / rubToEur;
                        }
                        break;
                    case CommandEurToUsd:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());
                        if (amountOfMoneyToConvert < euroWallet)
                        {
                            euroWallet -= amountOfMoneyToConvert;
                            dollarWallet += amountOfMoneyToConvert / eurToUsd;
                        }
                        break;
                    case CommandEurToRub:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());
                        if (amountOfMoneyToConvert < euroWallet)
                        {
                            euroWallet -= amountOfMoneyToConvert;
                            rubleWallet += amountOfMoneyToConvert / eurToRub;
                        }
                        break;
                    case CommandUsdToRub:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());
                        if (amountOfMoneyToConvert < dollarWallet)
                        {
                            dollarWallet -= amountOfMoneyToConvert;
                            rubleWallet += amountOfMoneyToConvert / usdToRub;
                        }
                        break;
                    case CommandUsdToEur:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());
                        if (amountOfMoneyToConvert < dollarWallet)
                        {
                            dollarWallet -= amountOfMoneyToConvert;
                            euroWallet += amountOfMoneyToConvert / usdToEur;
                        }
                        break;
                    default:
                        Console.WriteLine("Вы ввели неивестную команду. Повторите ввод пожалуйста.");
                        break;
                }
            }
        }
    }
}
