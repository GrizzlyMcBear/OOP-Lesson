using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public class Submarine : Vehicle
	{
		public Submarine(string vehicleId) : base(vehicleId)
		{
		}

		public Submarine(string vehicleId, int makeYear) : base(vehicleId, makeYear)
		{ 
		}


	}
}
