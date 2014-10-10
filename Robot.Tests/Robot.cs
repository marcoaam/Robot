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
		[TestCase ("1", "1", "E", "1 1 S")]
		[TestCase ("1", "1", "S", "1 1 W")]
		[TestCase ("1", "1", "W", "1 1 N")]
		public void CanTurnRight (string x_coordinate, string y_coordinate, string orientation, string expectedOutput)
		{
			robot = new Robot (x_coordinate, y_coordinate, orientation);
			robot.Turn ("R");
			Assert.That (robot.Position, Is.EqualTo (expectedOutput));
		}

		[TestCase ("1", "1", "N", "1 1 W")]
		[TestCase ("1", "1", "W", "1 1 S")]
		[TestCase ("1", "1", "S", "1 1 E")]
		[TestCase ("1", "1", "E", "1 1 N")]
		public void CanTurnLeft (string x_coordinate, string y_coordinate, string orientation, string expectedOutput)
		{
			robot = new Robot (x_coordinate, y_coordinate, orientation);
			robot.Turn ("L");
			Assert.That (robot.Position, Is.EqualTo (expectedOutput));
		}
	}
		
}

