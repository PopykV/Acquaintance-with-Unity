using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{

    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform[] waypoints;

    int m_CurrentWaypointIndex;

    void Start()
    {
       navMeshAgent.SetDestination(waypoints[0].position);
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        }
    }

    void Update()
    {
        //if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        //{
        //    m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
        //    navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        //}
    }
}