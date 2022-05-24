using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpike : MonoBehaviour
{
    [SerializeField] float damage = 20f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")//or tag
        {
            collision.gameObject.GetComponent<TheHealth>().TakeDamage(damage);
        }

    }
}
