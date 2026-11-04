using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    private NavMeshAgent _navMeshAgent;
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (_player != null)
        {
            _navMeshAgent.SetDestination(_player.position);
        }
    }
}
