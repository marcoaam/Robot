using NUnit.Framework;
using System;

namespace Robot.Tests
{
	[TestFixture ()]
	public class RobotTest
	{
		[Test ()]
		public void HasPossitionAndOrientation ()
		{
			var robot = new Robot ("1", "1", "N");

			Assert.That (robot.Position, Is.EqualTo ("1 1 N"));
		}
	}

	public class Robot
	{
		private int _x_coordinate;
		private int _y_coordinate;
		private string _orientation;

		public Robot(string x_coordinate, string y_coordinate, string orientation)
		{
			_x_coordinate = Convert.ToInt32(x_coordinate);
			_y_coordinate = Convert.ToInt32(y_coordinate);
			_orientation = orientation;
		}

		public string Position
		{
			get { return string.Format ("{0} {1} {2}", _x_coordinate, _y_coordinate, _orientation); }
		}
	}
}

