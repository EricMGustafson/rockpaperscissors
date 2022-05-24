// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Threading;

bool game = true;
bool choose = false;
char computerChoice = 'a';
char playerChoice = 'a';

Console.WriteLine("Hello, What is your name?");
string name = Console.ReadLine();

while (game)
{
  Console.WriteLine($"Welcome {name}. Would you like to play Rock/Paper/Scissors? (y/n)");
  char answer = Console.ReadKey().KeyChar;
  if (answer == 'n')
  {
    Console.WriteLine("\nThat's too bad.");
    Thread.Sleep(1000);
    Console.Clear();
    game = false;
  }
  else if (answer == 'y')
  {
    Console.WriteLine("\nChoose your play...\n(p) Paper\n(r) Rock\n(s) Scissors");
    game = false;
    choose = true;
  }
  else
  {
    Console.WriteLine("\nYou must answer with (y) or (n).");
    game = false;

  }
}

while (choose)
{
  char choice = Console.ReadKey().KeyChar;
  switch (choice)
  {
    case 'p':
      Console.WriteLine($"\n{name} chooses Paper!");
      playerChoice = 'p';
      break;
    case 'r':
      Console.WriteLine($"\n{name} chooses Rock!");
      playerChoice = 'r';
      break;
    case 's':
      Console.WriteLine($"\n{name} chooses Scissors!");
      playerChoice = 's';
      break;
    default:
      Console.WriteLine("You must choose (p)Paper, (r)Rock, or (s)Scissors.");
      break;

  }
  Random dice = new Random();
  int roll = dice.Next(1, 4);
  switch (roll)
  {
    case 1:
      Console.WriteLine("The computer chooses Paper!");
      computerChoice = 'p';
      break;
    case 2:
      Console.WriteLine("The computer chooses Rock!");
      computerChoice = 'r';
      break;
    case 3:
      Console.WriteLine("The computer chooses Scissorss!");
      computerChoice = 's';
      break;
    default:
      Console.WriteLine("What happened to computer choice???");
      break;
  }

  if (playerChoice == computerChoice)
  {
    Console.WriteLine("You've both chosen the same, try again.");
    choose = false;
    game = true;
    Thread.Sleep(1000);
  }
  while (playerChoice == 'r')
  {
    if (computerChoice == 's')
    {
      Console.WriteLine("Rock crush scissors!  Player wins!");
      playerChoice = 'a';
      computerChoice = 'a';
      choose = false;
      game = true;
      Thread.Sleep(1000);
    }
    else
    {
      Console.WriteLine("Paper grinds down rock!  Computer wins!");
      playerChoice = 'a';
      computerChoice = 'a';
      choose = false;
      game = true;
      Thread.Sleep(1000);
    }
  }
  while (playerChoice == 'p')
  {
    if (computerChoice == 's')
    {
      Console.WriteLine("Scissors cut up paper!  Computer wins!");
      playerChoice = 'a';
      computerChoice = 'a';
      choose = false;
      game = true;
      Thread.Sleep(1000);
    }
    else
    {
      Console.WriteLine("Paper grinds down rock!  Player wins!");
      playerChoice = 'a';
      computerChoice = 'a';
      choose = false;
      game = true;
      Thread.Sleep(1000);
    }
  }
  while (playerChoice == 's')
  {
    if (computerChoice == 'r')
    {
      Console.WriteLine("Rock crush scissors!  Computer wins");
      playerChoice = 'a';
      computerChoice = 'a';
      choose = false;
      game = true;
      Thread.Sleep(1000);
    }
    else
    {
      Console.WriteLine("Scissors cut up paper!  Player wins");
      playerChoice = 'a';
      computerChoice = 'a';
      choose = false;
      game = true;
      Thread.Sleep(1000);
    }
  }
}