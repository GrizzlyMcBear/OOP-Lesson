using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
	public class Car : Vehicle
	{
		public string PlateNumber
		{
			get { return plateNumber; }
			set
			{
				if (!value.Equals(string.Empty))
				{
					plateNumber = value;
				}
				else
				{
					Console.WriteLine("You cannot set the `plateNumber` to an empty string!");
				}
			}
		}
		public Car(string vehicleId) : base(vehicleId)
		{
			this.MakeYear = 1950;
		}

		public override void DoStunt()
		{
			Console.WriteLine($"Look at me {MakeYear}- driving on just 2 wheels!");
		}
	}
}
