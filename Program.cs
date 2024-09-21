using LR1.Races;
using LR1.Vehicles.AirVehicles;
using LR1.Vehicles.GroundVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/* 
Виды ТС для реализации:
    Ступа Бабы Яги;
    Метла;
    Сапоги-скороходы;
    Карета-тыква;
    Ковер-самолет;
    Избушка на курьих ножках;
    Кентавр;
    Летучий корабль.
*/

namespace LR1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            // выбранные транспортные средства
            Console.WriteLine("Выберите тип гонки: 1 - общая, 2 - наземная, 3 - воздушная");

            while (true)
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Ошибка: Введите число от 1 до 3.");
                    }
                    else
                    {
                        break; // Выход из цикла, если ввод корректен
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение.");
                }
            }

            
            Race race;

            switch (choice)
            {
                case 1:
                    race = new CommonRace();
                    break;
                case 2:
                    race = new GroundRace();
                    break;
                case 3:
                    race = new AirRace();
                    break;
                default:
                    throw new InvalidOperationException("Неверный выбор гонки");
            }

            Console.WriteLine("Выберите транспортное средство, которое будет участвовать в гонке:");
            Console.WriteLine("1 - Ступа; 2 - Метла; 3 - Сапоги-скороходы; 4 - Карета-тыква;");
            Console.WriteLine("5 - Ковер-самолет; 6 - Избушка на курьих ножках; 7 - Кентавр; 8 - Летучий корабль;");
            Console.WriteLine("Чтобы завершить выбор, введите пустую строку.");
            
            // Список выбранных ТС
            List<int> vehicles = new List<int>();

            int vehicleType;

            while (true)
            {

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {   while (true)
                    {
                        try
                        {
                            vehicleType = int.Parse(input);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Введите корректное значение.");
                            input = Console.ReadLine();
                        }
                    }
                }
                


                if (vehicles.Contains(vehicleType))
                {
                    Console.WriteLine("Это транспортное средство уже зарегистрировано на гонку! Выберите другое!");
                }
                else
                {
                    try
                    {
                        switch (vehicleType)
                        {
                            case 1:
                                Stupa stupa = new Stupa();
                                race.AddRacer(stupa);
                                break;
                            case 2:
                                Broomstick broomstck = new Broomstick();
                                race.AddRacer(broomstck);
                                break;
                            case 3:
                                BootsRunners boots = new BootsRunners();
                                race.AddRacer(boots);
                                break;
                            case 4:
                                Pumpkin pumpkin = new Pumpkin();
                                race.AddRacer(pumpkin);
                                break;
                            case 5:
                                MagicCarpet magicCarpet = new MagicCarpet();
                                race.AddRacer(magicCarpet);
                                break;
                            case 6:
                                HutChicken hutChicken = new HutChicken();
                                race.AddRacer(hutChicken);
                                break;
                            case 7:
                                Centaur centaur = new Centaur();
                                race.AddRacer(centaur);
                                break;
                            case 8:
                                FlyingShip flyingShip = new FlyingShip();
                                race.AddRacer(flyingShip);
                                break;
                            default:
                                Console.WriteLine("Неверный номер транспортного средства.");
                                continue;
                        }
                        vehicles.Add(vehicleType);
                    }
                    catch (InvalidOperationException ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    

                    

                }
            }
            Console.WriteLine("Введите длину трассы:");

            int distance;

            while (true)
            {
                try
                {
                    distance = Convert.ToInt32(Console.ReadLine());
                    if (distance < 0)
                    {
                        Console.WriteLine("Введите корректную длину");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректную длину");
                }
            }
            race.Distance = distance;
            race.StartRace();       
                    
        }
    }
}
