using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public static class TypeExtensions
	{
		public static string GetTypeMetadata(this Type target)
		{
			return string.Concat("Assembly: ", target.AssemblyQualifiedName, ", name: ", target.FullName);
		}
	}
}
