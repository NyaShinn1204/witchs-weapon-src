using UniRx;

public interface ICommandWith<T> : IParameterCommand, ICommand, ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
}
