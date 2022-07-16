using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLEditor
{
	public static class Editor
	{
		public static void Show()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("MODO EDITOR");
			Console.WriteLine("========================");
			Start();
		}
		
		private static void Start()
		{
			var file = new StringBuilder();
			
			do 
			{
				file.Append(Console.ReadLine());
				file.Append(Environment.NewLine);
			} 
			while (Console.ReadKey().Key != ConsoleKey.Escape);
			
			Console.WriteLine("========================");
			Console.WriteLine(" Deseja salvar o arquivo? S/N");
			var save = Console.ReadLine().ToUpper()[0];
			if (save == 'S')
				Save(file.ToString());

			Viewer.Show(file.ToString());
		}
		
		private static void Save(string text)
		{
			using (var file = new StreamWriter("./texto.txt"))
			{
				file.Write(text);
			}
			Console.WriteLine("Arquivo salvo com sucesso!");
			Console.ReadKey();
		}
	}
}