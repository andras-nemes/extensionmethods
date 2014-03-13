using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions.Enumerations
{
	public enum Difficulty
	{
		[Description("This is the easy level")]
		Easy
		, Medium
		, Hard
		, Master
	}
}
