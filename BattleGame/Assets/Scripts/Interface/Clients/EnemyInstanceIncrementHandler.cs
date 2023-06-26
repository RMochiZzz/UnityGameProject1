using Interface.Interfaces;

namespace Interface.Clients
{
    public class EnemyInstanceIncrementHandler
    {
        public void InstanceIncrement(IIncrement iIncrement)
        {
            iIncrement.Increment();
        }
    }
}
