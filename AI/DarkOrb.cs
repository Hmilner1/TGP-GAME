using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkOrb : MonoBehaviour
{
    [SerializeField] float damage = 50f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        rb.velocity = Vector3.zero;
        if (collision.transform.tag == "Player")//or tag
        {
            gameObject.SetActive(false);
            rb.velocity = Vector3.zero;
            collision.gameObject.GetComponent<TheHealth>().TakeDamage(damage);
        }

    }
}
