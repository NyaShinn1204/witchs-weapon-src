public interface ITemplate
{
	string Format(int type, string content, int indent = 0);

	string Color(string content, int color);

	string Bold(string content);

	string Italic(string content);

	string Indent(string content, int level);

	string LineEnd();
}
