using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public class Airplane : Vehicle
	{
		public Airplane(string vehicleId, int makeYear) : base(vehicleId, makeYear)
		{
		}

		public override void DoStunt()
		{
			Console.WriteLine($"Look at me ma, I was created on {this.MakeYear} and I'm doing a wheelie");
		}
	}
}
