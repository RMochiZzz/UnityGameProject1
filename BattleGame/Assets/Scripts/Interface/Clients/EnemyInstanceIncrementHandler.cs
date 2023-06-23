using Interface.Interfaces;

namespace Interface.Clients
{
    public class EnemyInstanceIncrementHandler
    {
        public void PerformIncrement(IIncrement iIncrement)
        {
            iIncrement.Increment();
        }
    }
}
