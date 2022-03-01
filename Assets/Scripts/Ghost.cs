using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ghost : MonoBehaviour
{
    public GameOver gOver;
    NavMeshAgent agent;
    GameObject target;
    [SerializeField] private float stopPoint;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if(dist < 8 && dist > stopPoint) {
            FollowTarget();
        }
        else if (dist < stopPoint)
        {
            StopEnemy();
            GameOver();
        }
        else if(dist > 8)
        {
            agent.SetDestination(-target.transform.position);
        }
        
    }

    public void GameOver()
    {
        gOver.EndGame();
    }
    private void StopEnemy()
    {
        agent.isStopped = true;
        
    }
    private void FollowTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }
}
