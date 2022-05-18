using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : BaseAIInherits
{
    [SerializeField] public float damage = 5f;
    [SerializeField] public float attackDistance = 100.5f;
    [SerializeField] public float distanceThreshold;
    [SerializeField] private Animator m_Animator;
    private bool m_DoingDamage;

    public static event Action<float> DoDamage;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(ChasePlayer());
        m_DoingDamage = false;
    }

    private void Update()
    {
        ChasePlayer();
        if (aiState == TheStates.chasing)
        {
            m_Animator.SetBool("isWalking", true);
        }
        else if (aiState != TheStates.chasing)
        {
            m_Animator.SetBool("isWalking", false);
        }

        if (aiState == TheStates.attack)
        {
            m_Animator.SetBool("isAttacking", true);
        }
        else if (aiState != TheStates.attack)
        {
            m_Animator.SetBool("isAttacking", false);
        }
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
                    DamagePlayer();
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


    private void DamagePlayer()
    {
       DoDamage?.Invoke(damage);
       
    }
}
