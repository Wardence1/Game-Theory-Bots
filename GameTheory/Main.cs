﻿using System;
namespace Main
{
    class Program {
        static void Main(string[] args) {

            // Checks to see if you didn't input enough args
            if(args.Length < 2) {
                Console.WriteLine("Please input two players into the command line after starting the program");
                Environment.Exit(1);
            }

            Player ? player1 = null, player2 = null;
            bool choice1 = true, choice2 = true;

            // Player 1
            switch(args[0]) {
                
                case "bully":
                    player1 = new Bully();
                    break;
                case "smiley":
                    player1 = new Smiley();
                    break;
                case "either":
                    player1 = new Either();
                    break;
                case "retaliator":
                    player1 = new Retaliator();
                    break;
                case "baiter":
                    player1 = new Baiter();
                    break;
                case "vengeance":
                    player1 = new Vengeance();
                    break;
                default:
                    Console.WriteLine("Pick a valid player for player 1.\nOptions Include:\n");
                    Console.WriteLine("bully\nsmiley\neither\nretaliator\nbaiter\nvengeance");
                    Environment.Exit(1);
                    break;
            }

            // Player 2
            switch(args[1]) {
                
                case "bully":
                    player2 = new Bully();
                    break;
                case "smiley":
                    player2 = new Smiley();
                    break;
                case "either":
                    player2 = new Either();
                    break;
                case "retaliator":
                    player2 = new Retaliator();
                    break;
                case "baiter":
                    player2 = new Baiter();
                    break;
                case "vengeance":
                    player2 = new Vengeance();
                    break;
                default:
                    Console.WriteLine("Pick a valid player for player 2.\nOptions Include:\n");
                    Console.WriteLine("bully\nsmiley\neither\nretaliator\nbaiter\nvengeance");
                    Environment.Exit(1);
                    break;
            }

            
            for(int i = 0; i < 400; i++) {

                choice1 = player1.choice(choice2);
                choice2 = player2.choice(choice1);

                if(choice1 && choice2) {
                    player1.points += 5;
                    player2.points += 5;
                } else if(choice1 != choice2) {
                    if(!choice1)
                        player1.points += 10;
                    else if(!choice2)
                        player2.points += 10;
                }
            }

            Console.WriteLine(player1.name + " Score: " + player1.points);
            Console.WriteLine(player2.name + " Score: " + player2.points);
        }
    }
}
