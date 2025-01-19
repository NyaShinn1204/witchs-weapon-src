internal interface ILoggerModual
{
	string Name { get; set; }

	string RunFunction(int loglevel, string funcName, object self, params object[] obj);
}
