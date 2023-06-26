using UnityEngine;
using UnityEngine.AI;

namespace Core.Character.Enemy.AI
{
    public class EnemyAINormal : MonoBehaviour
    {
        private GameObject player;
        private NavMeshAgent agent;

        void Start()
        {
            player = GameObject.Find("Player");
            agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {
            if (player != null)
            {
                Vector3 targetPosition = new Vector3(player.transform.position.x, player.transform.position.y, 0);
                agent.SetDestination(targetPosition);
            }
        }
    }
}
