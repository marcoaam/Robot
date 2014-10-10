using NUnit.Framework;
using System;
using System.Collections;

namespace Robot.Tests
{
	[TestFixture ()]
	public class RobotTest
	{
		Robot robot;

		[Test ()]
		public void HasPossitionAndOrientation ()
		{
			robot = new Robot ("1", "1", "N");

			Assert.That (robot.Position, Is.EqualTo ("1 1 N"));
		}

		[TestCase ("1", "1", "N", "1 1 E")]
		public void CanTurnRight (string x_coordinate, string y_coordinate, string orientation, string expectedOutput)
		{
			robot = new Robot (x_coordinate, y_coordinate, orientation);
			robot.Turn ("R");
			Assert.That (robot.Position, Is.EqualTo (expectedOutput));
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

		public void Turn(string direction)
		{
			_orientation = direction == "R" ? "E" : _orientation;
		}
	}
}

