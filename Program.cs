// author - macr0n

using System;
using System.Threading;

namespace ghoul
{
	class Program
	{
		static void Main(string[] args)
		{

			/*(( Введи никнейм гуля: *я ввожу*. ))
			(( Введи свой никнейм: *я ввожу*. ))
			*Clear**/

			Console.WriteLine("(( Введи никнейм гуля. ))");
			string Ghoul = Console.ReadLine();
			string RightGhoul = Ghoul.Replace(".", "");

			Console.Clear();

			Console.WriteLine("(( Введи свой никнейм. ))");
			string Person = Console.ReadLine();
			string RightPerson = Person.Replace(".", "");

			Console.Clear();

			// Гуль: 1000-7, я ауе гуль.

			int x = 1000;
			int y = 1;

			while (x > 6)
			{
				Console.Write($"{RightGhoul} говорит: {Convert.ToString(x)} - 7 = ");
				x = x - 7;
				Console.WriteLine($"{Convert.ToString(x)}.");
				Thread.Sleep(25);
			}

			Thread.Sleep(750);
			Console.Clear();

			while (y > 0)
			{
				x = x - 7;
				Console.WriteLine($"{RightGhoul} говорит: Я гуль.");
				Thread.Sleep(25);

				while (x < -252)
				{
					y = y - 1;
					x = 0;
				}
			}

			Thread.Sleep(750);
			Console.Clear();

			/*(( Ответить, или скипнуть?: *я ввожу ответить* ))
			*Clear последней строки*
			Я: Ответ.
			Гуль: Иди нахуй, я гуль.
			(( Ответить, или скипнуть?: *я ввожу скипнуть* ))
			*программа закрывается**/

			Console.WriteLine("(( Ответить, или пропустить? '/reply' что бы ответить, и '/skip' что бы пропустить. ))");
			string Answer = Console.ReadLine();

			if (Answer == "/reply")
			{
				Console.Clear();
				Console.WriteLine($"{RightGhoul} говорит: 1000 - 7, я гуль.");
				Console.Write($"{RightPerson} говорит: ");
				Console.ReadLine();
				Console.WriteLine($"{RightGhoul} говорит: Иди нахуй, я гуль.");
				Thread.Sleep(1500);
				Console.Clear();
				Console.WriteLine("(( Вы ответили гулю, нажмите на любую клавшу для закрытия приложения. ))");
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"        {RightGhoul} (993)");
				Console.WriteLine();
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀░░░░░░░░░░⠀⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒░░⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀▒█████░░░░▓▓▓▓░░░▒▒⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀███████░░░░░░░░░░▒▒⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀██████████████████⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀███▒▒▒▒█████████⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀██████████████⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀████████⠀⠀⠀⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀▓▓▓██████████████▓▓▓▓▓⠀⠀");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
			}

			else if (Answer == "/skip")
			{
				Console.Clear();
				Console.WriteLine("(( Вы решили не отвечать гулю, нажмите на любую клавишу для закрытия приложения. ))");
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"        {RightGhoul} (993)");
				Console.WriteLine();
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀░░░░░░░░░░⠀⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒░░⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀▒█████░░░░▓▓▓▓░░░▒▒⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀███████░░░░░░░░░░▒▒⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀██████████████████⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀███▒▒▒▒█████████⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀██████████████⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀████████⠀⠀⠀⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀▓▓▓██████████████▓▓▓▓▓⠀⠀");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
			}

			else
			{
				Console.Clear();
				Console.WriteLine("(( Вы не правильную комманду, нажмите на любую клавишу для закрытия приложения. ))");
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"        {RightGhoul} (993)");
				Console.WriteLine();
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀░░░░░░░░░░⠀⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒░░⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀▒█████░░░░▓▓▓▓░░░▒▒⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀███████░░░░░░░░░░▒▒⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀██████████████████⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀███▒▒▒▒█████████⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀██████████████⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀████████⠀⠀⠀⠀⠀⠀⠀⠀⠀");
				Console.WriteLine("⠀⠀⠀⠀▓▓▓██████████████▓▓▓▓▓⠀⠀");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");
				Console.WriteLine("⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓");

			}

			Console.ReadKey();
		}
	}
}
/* 
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀░░░░░░░░░░
⠀⠀⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒░
⠀⠀⠀⠀⠀⠀░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░
⠀⠀⠀⠀⠀⠀▒█████░░░░▓▓▓▓░░░▒▒
⠀⠀⠀⠀⠀⠀███████░░░░░░░░░░▒▒
⠀⠀⠀⠀⠀⠀██████████████████
⠀⠀⠀⠀⠀⠀⠀███▒▒▒▒█████████
⠀⠀⠀⠀⠀⠀⠀⠀██████████████
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀████████
⠀⠀⠀⠀▓▓▓██████████████▓▓▓▓▓
⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓
⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓
⠀⠀⠀▓▓▓▓██████████████▓▓▓▓▓▓▓

*/