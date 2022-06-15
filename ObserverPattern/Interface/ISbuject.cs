namespace ObserverPattern.Interface
{
    public interface ISbuject
    {
         void registerObserver(IObserver o);
         void removeObserver(IObserver o);
         void nodifyObserver();
    }
}