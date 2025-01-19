namespace Mono.Cecil.Cil
{
	public sealed class ExceptionHandler
	{
		private Instruction try_start;

		private Instruction try_end;

		private Instruction filter_start;

		private Instruction handler_start;

		private Instruction handler_end;

		private TypeReference catch_type;

		private ExceptionHandlerType handler_type;

		public Instruction TryStart
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Instruction TryEnd
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Instruction FilterStart
		{
			set
			{
			}
		}

		public Instruction HandlerStart
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Instruction HandlerEnd
		{
			set
			{
			}
		}

		public TypeReference CatchType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExceptionHandlerType HandlerType
		{
			get
			{
				return default(ExceptionHandlerType);
			}
		}

		public ExceptionHandler(ExceptionHandlerType handlerType)
		{
		}
	}
}
