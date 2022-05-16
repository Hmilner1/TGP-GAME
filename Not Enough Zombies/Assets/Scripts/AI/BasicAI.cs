using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : BaseAIInherits
{
    [SerializeField] public float damage = 5f;
    [SerializeField] public float attackDistance = 0.5f;
    [SerializeField] public float distanceThreshold;

    public static event Action<float> DoDamage;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(ChasePlayer());
    }

    private void Update()
    {
       ChasePlayer();
    }

    IEnumerator ChasePlayer()
    {
        while (true)
        {
            switch (aiState)
            {
                case TheStates.chasing:
                    float dist = Vector3.Distance(player.position, transform.position);
                    agent.speed = 8;
                    if (dist < attackDistance)
                    {
                        aiState = TheStates.attack;

                    }
                    agent.SetDestination(player.position);
                    break;
                case TheStates.attack:
                    agent.SetDestination(transform.position);
                    dist = Vector3.Distance(player.position, transform.position);
                    if(dist > attackDistance)
                    {
                        aiState = TheStates.chasing;
                    }
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(0f);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "player")//or tag
        {
            DoDamage?.Invoke(damage);
            Debug.Log("Collided");
        }
    }
}
