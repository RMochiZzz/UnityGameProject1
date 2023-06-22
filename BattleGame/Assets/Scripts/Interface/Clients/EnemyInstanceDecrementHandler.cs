namespace Interface.Clients
{
    public class EnemyInstanceDecrementHandler
    {
        public void PerformDecrement(IDecrement Idecrement)
        {
            Idecrement.Decrement();
        }
    }
}
