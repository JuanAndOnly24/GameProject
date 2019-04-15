using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double playerHP1 = 2000;
            int playerHP2 = 2000;
            int i;
            double dmg;
            int x;
            int power;

            Random DmgGenerator = new Random();
            Random PercentageGen = new Random();

            do
            {
                Console.WriteLine("Choose Move:\n1.Right Hand Punch.\n2.Left Hand Punch.\n3.Right Foot Kick.\n4.Left Foot Kick.\n5.Spin Foot Kick\n6.Uppercut.");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        {
                            power = DmgGenerator.Next(150, 401);
                            x = PercentageGen.Next(-15, 61);
                                dmg = power - (power * x / 100);
                                playerHP1 = playerHP1 - dmg;
                                Console.WriteLine("You Did -" + dmg + "-DMG to the opponent with Right Hand Punch.");
                                Console.WriteLine("Opponents life is: " + playerHP1 + ".");
                            break;
                        }
                    case 2:
                        {
                            power = DmgGenerator.Next(90, 251);
                            x = PercentageGen.Next(-15, 61);
                                dmg = power - (power * x / 100);
                                playerHP1 = playerHP1 - dmg;
                                Console.WriteLine("You Did -" + dmg + "-DMG to the opponent with Left Hand Punch.");
                                Console.WriteLine("Opponents life is: " + playerHP1 + ".");
                            break;
                        }
                    case 3:
                        {
                            power = DmgGenerator.Next(70, 321);
                            x = PercentageGen.Next(-15, 61);
                                dmg = power - (power * x / 100);
                                playerHP1 = playerHP1 - dmg;
                                Console.WriteLine("You Did -" + dmg + "-DMG to the opponent with Right Foot Kick.");
                                Console.WriteLine("Opponents life is: " + playerHP1 + ".");
                            break;
                        }
                    case 4:
                        {
                            power = DmgGenerator.Next(40, 201);
                            x = PercentageGen.Next(-15, 61);
                                dmg = power - (power * x / 100);
                                playerHP1 = playerHP1 - dmg;
                                Console.WriteLine("You Did -" + dmg + "-DMG to the opponent with Left Foot Kick.");
                                Console.WriteLine("Opponents life is: " + playerHP1 + ".");
                            break;
                        }
                    case 5:
                        {
                            power = DmgGenerator.Next(70, 301);
                            x = PercentageGen.Next(-15, 61);
                                dmg = power - (power * x / 100);
                                playerHP1 = playerHP1 - dmg;
                                Console.WriteLine("You Did -" + dmg + "-DMG to the opponent with Spin Foot Kick.");
                                Console.WriteLine("Opponents life is: " + playerHP1 + ".");
                            break;
                        }
                    case 6:
                        {
                            power = DmgGenerator.Next(90, 351);
                            x = PercentageGen.Next(-15, 61);
                                dmg = power - (power * x / 100);
                                playerHP1 = playerHP1 - dmg;
                                Console.WriteLine("You Did -" + dmg + "-DMG to the opponent with Uppercut.");
                                Console.WriteLine("Opponents life is: " + playerHP1 + ".");
                            break;
                        }

                }
            } while (playerHP1 >= 0);
        }
    }
}