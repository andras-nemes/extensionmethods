using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions.Interfaces
{
	public abstract class FileSourceBase
	{
		public string FileName
		{
			get
			{
				return "source.xml";
			}
		}
	}
}
