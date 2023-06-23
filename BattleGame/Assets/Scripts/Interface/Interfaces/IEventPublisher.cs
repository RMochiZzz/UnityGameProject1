namespace Interface.Interfaces
{
    public interface IEventPublisher<T1, T2>
    {
        void PublishEvent(T1 eventData1, T2 eventData2);
    }
}