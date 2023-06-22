namespace Interface.Clients
{
    public class IncrementOperationHandler
    {
        public void PerformIncremant(Iincrement iincrement)
        {
            iincrement.Increment();
        }
    }
}
