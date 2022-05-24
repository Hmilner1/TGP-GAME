using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Necromancer : BaseWizardInherits
{
    public Transform Player;
    [SerializeField]  NavMeshAgent agent;
    [SerializeField]  LayerMask player;

    [SerializeField]  Transform FirePoint;
    [SerializeField]  Transform SummonPoint;
    [SerializeField]  GameObject SpellOne;
    [SerializeField]  GameObject SpellTwo;

    [SerializeField] float ManaRegen = 0.75f;
    [SerializeField] float attackDistance = 20f;
    [SerializeField] float GrabDistance = 40f;
    [SerializeField] float PushBackRange = 10f;
    [SerializeField] bool isInGrabRange;
    [SerializeField] public float ManaCost;
    [SerializeField] public float MaxMana = 100f;
    [SerializeField] public float currentMana;

    // Start is called before the first frame update
    void Start()
    {
        currentMana = 10;
        manaRegenActive = true;
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        inFireRange = Physics.CheckSphere(transform.position, attackDistance, player);
        isInGrabRange = Physics.CheckSphere(transform.position, GrabDistance, player);
        isInMeleeRange = Physics.CheckSphere(transform.position, PushBackRange, player);

        if (!inFireRange && !isCastingSpell && !isInGrabRange) ChasePlayer();

        if(inFireRange && currentMana >= 10 && !CoolDownBeginSpell1 && !isCastingSpell)
        {
            StartCoroutine(FireDarkOrb());
            StartCoroutine(CoolDownSpell1(2));
            isCastingSpell = true;
        }


       if(!inFireRange && !isInGrabRange && currentMana >= 50 && !CoolDownBeginSpell4 && !isCastingSpell)
        {
            for (int i = 0; i < 10; i++)
            {
                StartCoroutine(SummonThings());
            }
            StartCoroutine(CoolDownSpell2(20));
            isCastingSpell = true;
        }


        if (manaRegenActive == true)
        {
            currentMana += ManaRegen * Time.deltaTime;
            if(currentMana >= MaxMana)
            {
                manaRegenActive = false;
            }
        }
    }

    IEnumerator FireDarkOrb()
    {

        if(CoolDownBeginSpell1 == false)
        {
            agent.SetDestination(transform.position);

            transform.LookAt(Player);


                ManaCost = 10f;
                currentMana -= ManaCost;
                yield return new WaitForSeconds(2);
                GameObject Orb = Instantiate(SpellOne, FirePoint.position, Quaternion.identity);
                Orb.GetComponent<Rigidbody>().AddForce(FirePoint.up + FirePoint.forward * 24f, ForceMode.Impulse);
                isCastingSpell = false;

        }

    }

    IEnumerator SummonThings()
    {
        if(CoolDownBeginSpell4 == false)
        {
            agent.SetDestination(transform.position);


                ManaCost = 50;
                currentMana -= ManaCost;

                yield return new WaitForSeconds(5);

            Vector3 SpawnSpread = SummonPoint.transform.position;
            SpawnSpread.x += Random.Range(-1, 50);
            SpawnSpread.z += Random.Range(-1, 50);

            Instantiate(SpellTwo, SpawnSpread,Quaternion.identity);
                
            isCastingSpell = false;
            

        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, PushBackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, attackDistance);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, GrabDistance);
    }



    void ChasePlayer()
    {
        agent.SetDestination(Player.position);
    }

    IEnumerator CoolDownSpell1(float CoolDownTimer)
    {
        CoolDownBeginSpell1 = true;
        yield return new WaitForSeconds(CoolDownTimer);
        CoolDownBeginSpell1 = false;
    }
    IEnumerator CoolDownSpell2(float CoolDownTimer)
    {
        CoolDownBeginSpell2 = true;
        yield return new WaitForSeconds(CoolDownTimer);
        CoolDownBeginSpell2 = false;
    }
}

