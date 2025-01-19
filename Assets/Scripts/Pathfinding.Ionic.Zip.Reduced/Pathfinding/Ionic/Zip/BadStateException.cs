using System;

namespace Pathfinding.Ionic.Zip
{
	public class BadStateException : ZipException
	{
		public BadStateException(string message)
		{
		}

		public BadStateException(string message, Exception innerException)
		{
		}
	}
}
