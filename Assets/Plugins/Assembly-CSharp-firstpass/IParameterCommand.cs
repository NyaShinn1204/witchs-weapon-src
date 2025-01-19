using UniRx;

public interface IParameterCommand : ICommand, ISubject<Unit>, ISubject<Unit, Unit>, IObserver<Unit>, IObservable<Unit>
{
	object Parameter { get; set; }
}
