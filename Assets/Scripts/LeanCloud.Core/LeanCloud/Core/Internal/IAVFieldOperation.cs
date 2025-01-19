namespace LeanCloud.Core.Internal
{
	public interface IAVFieldOperation
	{
		object Encode();

		IAVFieldOperation MergeWithPrevious(IAVFieldOperation previous);

		object Apply(object oldValue, string key);
	}
}
