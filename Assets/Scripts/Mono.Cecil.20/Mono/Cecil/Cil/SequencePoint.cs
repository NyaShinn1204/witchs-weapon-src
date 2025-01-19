namespace Mono.Cecil.Cil
{
	public sealed class SequencePoint
	{
		private Document document;

		private int start_line;

		private int start_column;

		private int end_line;

		private int end_column;

		public int StartLine
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int StartColumn
		{
			set
			{
			}
		}

		public int EndLine
		{
			set
			{
			}
		}

		public int EndColumn
		{
			set
			{
			}
		}

		public Document Document
		{
			get
			{
				return null;
			}
		}

		public SequencePoint(Document document)
		{
		}
	}
}
