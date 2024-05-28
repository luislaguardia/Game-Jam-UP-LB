using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;


    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHealth.TakeDamage(damage);
    }



}
