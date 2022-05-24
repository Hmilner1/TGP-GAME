using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FireWizard : BaseWizardInherits
{
    public Transform Player;
    [SerializeField] public NavMeshAgent agent;
    [SerializeField] public LayerMask player;

    [SerializeField] Transform DropPoint;
    [SerializeField] public Transform FirePoint;
    [SerializeField] public GameObject SpellOne;
    [SerializeField] public GameObject SpellTwo;
    [SerializeField] public GameObject SpellThree;


    [SerializeField] float ManaRegen = 0.75f;
    [SerializeField] float attackDistance = 20f;
    [SerializeField] float ManaCost;
    [SerializeField] float MaxMana = 100f;
    [SerializeField] float currentMana;
    [SerializeField] float PushBackRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        currentMana = 10;
        manaRegenActive = true;
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("player").transform;
        DropPoint = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        inFireRange = Physics.CheckSphere(transform.position, attackDistance, player);
        isInMeleeRange = Physics.CheckSphere(transform.position, PushBackRange, player);

        if (!inFireRange && !isCastingSpell) ChasePlayer();

        if (inFireRange && currentMana >= 10 && !CoolDownBeginSpell1 && !isCastingSpell)
        {
            StartCoroutine(FireBall());
            StartCoroutine(CoolDownSpell1(5));
            isCastingSpell = true;
        }

        if (isInMeleeRange && !isCastingSpell && currentMana >= 5 && !CoolDownBeginSpell3)
        {
            StartCoroutine(FireBeam());
            StartCoroutine(CoolDownSpell2(10));
            isCastingSpell = true;
        }

        if (!inFireRange && !isCastingSpell && currentMana >= 60 && !CoolDownBeginSpell4)
        {
            StartCoroutine(DropMeteor());
            StartCoroutine(CoolDownSpell3(20));
            isCastingSpell = true;
        }


        if (manaRegenActive == true)
        {
            currentMana += ManaRegen * Time.deltaTime;
            if (currentMana >= MaxMana)
            {
                manaRegenActive = false;
            }
        }
    }

    IEnumerator FireBall()
    {

        if (CoolDownBeginSpell1 == false)
        {

            transform.LookAt(Player);

            agent.SetDestination(transform.position);

            ManaCost = 10f;
            currentMana -= ManaCost;
            yield return new WaitForSeconds(2);
            GameObject Ball = Instantiate(SpellOne, FirePoint.position, Quaternion.identity);
            Ball.GetComponent<Rigidbody>().AddForce(FirePoint.up + FirePoint.forward * 32f, ForceMode.Impulse);
            isCastingSpell = false;

        }

    }

    IEnumerator FireBeam()
    {
        agent.SetDestination(transform.position);


        if (CoolDownBeginSpell2 == false)
        {
            transform.LookAt(Player);
            ManaCost = 30;
            currentMana -= ManaCost;
            yield return new WaitForSeconds(2);
            GameObject Beam = Instantiate(SpellTwo, FirePoint.position, Quaternion.identity);
            Beam.GetComponent<Rigidbody>().AddForce(FirePoint.forward * 24f, ForceMode.Impulse);
        }
        isCastingSpell = false;
    }

    IEnumerator DropMeteor()
    {
        agent.SetDestination(transform.position);

        if(CoolDownBeginSpell4 == false)
        {
            transform.LookAt(transform);
            ManaCost = 50;
            currentMana -= ManaCost;
            yield return new WaitForSeconds(2);

            GameObject Rock = Instantiate(SpellThree, DropPoint.position, Quaternion.identity);
            Rock.GetComponent<Rigidbody>().AddForce(DropPoint.forward * 24, ForceMode.Impulse);
        }
        isCastingSpell = false;
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

    IEnumerator CoolDownSpell3(float CoolDownTimer)
    {
        CoolDownBeginSpell3 = true;
        yield return new WaitForSeconds(CoolDownTimer);
        CoolDownBeginSpell3 = false;
    }

}
