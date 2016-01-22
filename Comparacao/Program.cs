using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao
{
	class Program
	{
		static void Main(string[] args)
		{
			Conta a = new Conta();
			a.Numero = 123;
			a.Saldo = 5000;

			Conta b = new Conta();
			b.Numero = 123;
			b.Saldo = 5000;

			Console.WriteLine(a.Equals("olá"));
			Console.WriteLine(a.Equals(a));
			Console.WriteLine(a.Equals(null));
			Console.WriteLine(a.Equals(b));


		}
	}
}
