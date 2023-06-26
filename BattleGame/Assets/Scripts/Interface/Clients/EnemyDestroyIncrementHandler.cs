using Interface.Interfaces;

namespace Interface.Clients
{
    public class EnemyDestroyIncrementHandler
    {
        public void PerformDecrement(IIncrement Iincrement)
        {
            Iincrement.increment();
        }
    }
}
