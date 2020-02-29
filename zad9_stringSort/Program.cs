using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9_stringSort
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

			string text = "Ala ma kota i ma też psa, ale Ala nie ma papugi. Papugi ma Ola.";
			System.Console.WriteLine($"Original text: '{text}'");
			
			string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
			List<string> x = new List<string>();
			Dictionary<string, int> W = new Dictionary<string, int>();

			foreach (var w in words)
			{
				string searchTerm = w;
				var match = from word in words
							where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
							select word;
				if (W.ContainsKey(w.ToString()))
					continue;
				else
					W.Add(w.ToString(), match.Count());
			}
			//Console.WriteLine(match.Count());
			

			foreach (var word in words)
			{
				System.Console.WriteLine($"{word}");
				//Console.WriteLine(word.Length);
				;
			}
			foreach (var word in W)
			{
				Console.WriteLine("{0} - {1}",
	   word.Key, word.Value);
			}	

			//Console.WriteLine("Ala ma kota i ma też psa, ale Ala nie ma papugi. Papugi ma Ola. ");
			//string parse = "Ala ma kota i ma też psa, ale Ala nie ma papugi. Papugi ma Ola.";
			//string[] words = parse.Split(' ');
			//foreach (var x in parse)
			//{
			//	Console.WriteLine($"<{x}>");
			//}

			//IEnumerable<string> sortDescendingQuery =
			//  from w in words
			//  orderby w descending
			//  select w;
			//foreach (var s in sortDescendingQuery.Distinct())
			//{
			//	Console.WriteLine(s);
			//}
			Console.ReadKey();
		}
	}
}
