﻿using System;
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
                Console.WriteLine($"Выберите одну из следующих операций(введите номер операции):\n{CommandRubToUsd} - Обменять рубли на долары\t" +
                                  $"{CommandRubToEur} - Обменять рубли на евро\n{CommandEurToUsd} - Обменять евро на доллары\t{CommandEurToRub} - Обменять евро на рубли\n" +
                                  $"{CommandUsdToRub} - Обменять доллары на рубли\t{CommandUsdToEur} - Обменять доллары на евро\nДля выхода, введите {CommandExit}");
                selectCommand = Console.ReadLine();

                switch (selectCommand)
                {
                    case CommandExit:
                        isOpen = false;
                        break;

                    case CommandRubToUsd:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                        if (amountOfMoneyToConvert <= rubleWallet)
                        {
                            rubleWallet -= amountOfMoneyToConvert;
                            dollarWallet += amountOfMoneyToConvert / rubToUsd;
                        }
                        else
                            Console.WriteLine("У вас на счету недостаточно средств для операции.");
                        break;

                    case CommandRubToEur:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                        if (amountOfMoneyToConvert <= rubleWallet)
                        {
                            rubleWallet -= amountOfMoneyToConvert;
                            euroWallet += amountOfMoneyToConvert / rubToEur;
                        }
                        else
                            Console.WriteLine("У вас на счету недостаточно средств для операции.");
                        break;

                    case CommandEurToUsd:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                        if (amountOfMoneyToConvert <= euroWallet)
                        {
                            euroWallet -= amountOfMoneyToConvert;
                            dollarWallet += amountOfMoneyToConvert / eurToUsd;
                        }
                        else
                            Console.WriteLine("У вас на счету недостаточно средств для операции.");
                        break;

                    case CommandEurToRub:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                        if (amountOfMoneyToConvert <= euroWallet)
                        {
                            euroWallet -= amountOfMoneyToConvert;
                            rubleWallet += amountOfMoneyToConvert / eurToRub;
                        }
                        else
                            Console.WriteLine("У вас на счету недостаточно средств для операции.");
                        break;

                    case CommandUsdToRub:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                        if (amountOfMoneyToConvert <= dollarWallet)
                        {
                            dollarWallet -= amountOfMoneyToConvert;
                            rubleWallet += amountOfMoneyToConvert / usdToRub;
                        }
                        else
                            Console.WriteLine("У вас на счету недостаточно средств для операции.");
                        break;

                    case CommandUsdToEur:
                        Console.WriteLine("Введите количество средств для обмена: ");
                        amountOfMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                        if (amountOfMoneyToConvert <= dollarWallet)
                        {
                            dollarWallet -= amountOfMoneyToConvert;
                            euroWallet += amountOfMoneyToConvert / usdToEur;
                        }
                        else
                            Console.WriteLine("У вас на счету недостаточно средств для операции.");
                        break;

                    default:
                        Console.WriteLine("Вы ввели неивестную команду. Повторите ввод пожалуйста.");
                        break;
                }
            }
        }
    }
}
