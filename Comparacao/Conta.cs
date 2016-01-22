﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao
{
	class Conta
	{
		public int Numero { get; set; }
		public double Saldo { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (obj == null || obj.GetType() != this.GetType())
			{
				return false;
			}
			Conta x = obj as Conta;

			return this.Numero == x.Numero;
		}
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}
	}
}
