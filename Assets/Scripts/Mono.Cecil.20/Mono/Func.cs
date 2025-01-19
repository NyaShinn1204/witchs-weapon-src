namespace Mono
{
	internal delegate TResult Func<TResult>();
	internal delegate TResult Func<T, TResult>(T arg1);
	internal delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
}
