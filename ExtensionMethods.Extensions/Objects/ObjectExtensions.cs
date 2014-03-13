using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public static class ObjectExtensions
	{
		public static string ToXmlRepresentation(this object target)
		{
			return string.Concat("<xml>", target.ToString(), "</xml>");

		}
	}
}
