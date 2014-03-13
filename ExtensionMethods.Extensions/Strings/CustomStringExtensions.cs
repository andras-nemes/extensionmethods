using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public static class CustomStringExtensions
	{
		public static string ToXmlName(this string name)
		{
			return string.Concat("<name>", name, "</name>");
		}

		public static string ToXmlName(this string name, string customAttrib)
		{
			return string.Concat("<name attrib=", customAttrib, ">", name, "</name>");
		}
	}
}
