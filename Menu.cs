using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLEditor
{
	public static class Menu
	{
		public static void Show(int ncols = 30, int nrows = 10)
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;

			DrawScreen(ncols, nrows);
			WriteOptions();

			var option = short.Parse(Console.ReadLine());
			HandleMenuOption(option);
		}

		private static void HandleMenuOption(short option)
		{
			switch (option)
			{
				case 1:
					Editor.Show();
					break;
				case 2:
					Viewer.Show("");
					break;
				case 0: 
					Console.Clear();
					Environment.Exit(0);
					break;
				default:
					Show();
					break;
			}
		}

		private static void WriteOptions()
		{
			SetCursorAndWriteMessage(3, 2, "Editor HTML");
			SetCursorAndWriteMessage(3, 3, "========================");
			SetCursorAndWriteMessage(3, 4, "Selecione uma opção abaixo");
			SetCursorAndWriteMessage(3, 6, "1 - Novo arquivo");
			SetCursorAndWriteMessage(3, 7, "2 - Abrir arquivo");
			SetCursorAndWriteMessage(3, 9, "0 - Sair");
			SetCursorAndWriteMessage(3, 10, "Opção: ", false);
		}

		private static void SetCursorAndWriteMessage(int left, int top, string msg, bool jumpLine = true)
		{
			Console.SetCursorPosition(left, top);
			if (jumpLine)
				Console.WriteLine(msg);
			else
				Console.Write(msg);
		}

		private static void DrawScreen(int ncols, int nrows)
		{
			DrawBaseLine(ncols);
			DrawMargins(ncols, nrows);
			DrawBaseLine(ncols);
		}

		private static void DrawBaseLine(int ncols)
		{
			Console.Write("+");
			for (var i = 0; i <= ncols; i++)
				Console.Write("-");

			Console.Write("+");
			Console.Write("\n");
		}

		private static void DrawMargins(int ncols, int nrows)
		{
			for (var i = 0; i <= nrows; i++)
			{
				Console.Write("|");
				for (var j = 0; j <= ncols; j++)
					Console.Write(" ");

				Console.Write("|");
				Console.Write("\n");
			}
		}
	}
}