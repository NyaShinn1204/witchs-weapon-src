public class LanguageSetManager
{
	public enum LanguageSet
	{
		chinese_mainland = 0
	}

	public static readonly string DictTableName;

	public static readonly string DictTablePKName;

	private static LanguageSet CurrLanguage;

	private static string[] DictLanguageColums;

	public static string getCurrDictLangColName()
	{
		return null;
	}
}
