using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lecture8
{
	public  class Person
	{
		// field
		public string name;
		public DateTime DateOfBirth;

		// method = function
		public void PrintPersonData()
		{
			WriteLine($" name : {name} , date of birth : {DateOfBirth}");
		}
	}
}
