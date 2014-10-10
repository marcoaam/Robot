using System;
using System.Collections;

namespace Robot
{
	public class Robot
	{
		private int _x_coordinate;
		private int _y_coordinate;
		private string _orientation;
		private Hashtable _orientations;

		public Robot(string x_coordinate, string y_coordinate, string orientation)
		{
			_x_coordinate = Convert.ToInt32(x_coordinate);
			_y_coordinate = Convert.ToInt32(y_coordinate);
			_orientation = orientation;
			_orientations = BuildOrientations ();
		}

		public string Position
		{
			get { return string.Format ("{0} {1} {2}", _x_coordinate, _y_coordinate, _orientation); }
		}

		public void Turn(string direction)
		{
			_orientation = (direction == "R") ? TurnRight() : TurnLeft ();
		}

		private Hashtable BuildOrientations()
		{
			return new Hashtable {{"N", "E"}, {"E", "S"}, {"S", "W"}, {"W", "N"}};  
		}

		private string TurnRight()
		{
			return _orientations [_orientation].ToString ();
		}

		private string TurnLeft()
		{
			string key = "";
			foreach (DictionaryEntry directions in _orientations)
			{
				if (directions.Value.ToString() == _orientation)
					key = directions.Key.ToString();
			}
			return key;
		}
	}
}

