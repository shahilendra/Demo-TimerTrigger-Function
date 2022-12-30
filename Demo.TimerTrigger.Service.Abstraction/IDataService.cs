namespace Demo.TimerTrigger.Service.Abstraction
{
    public interface IDataService
    {
        Task ProcessData(string data);
    }
}