using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseWizardInherits : MonoBehaviour
{
    [SerializeField] public bool inFireRange;
    [SerializeField] public bool isCastingSpell;
    [SerializeField] public bool CoolDownBeginSpell1;
    [SerializeField] public bool CoolDownBeginSpell2;
    [SerializeField] public bool CoolDownBeginSpell3;
    [SerializeField] public bool CoolDownBeginSpell4;
    [SerializeField] public bool manaRegenActive;
    [SerializeField] public bool isInMeleeRange;
}
