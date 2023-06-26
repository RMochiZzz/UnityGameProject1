using Interface.Interfaces;

namespace Interface.Clients
{
    public class EnemyDestroyIncrementHandler
    {
        public void DestroyIncrement(IIncrement Iincrement)
        {
            Iincrement.Increment();
        }
    }
}
