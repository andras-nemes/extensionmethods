using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public static class ExceptionExtensions
	{
		public static string UserFriendlyFullMessage(this Exception exception)
		{
			StringBuilder exceptionBuilder = new StringBuilder();
			while (exception != null)
			{
				exceptionBuilder.AppendLine(exception.Message);
				exception = exception.InnerException;
			}
			return exceptionBuilder.ToString();
		}
	}
}
