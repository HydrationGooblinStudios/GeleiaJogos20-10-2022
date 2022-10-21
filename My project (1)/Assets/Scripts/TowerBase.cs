using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    [SerializeField] private GameObject Projectile;
    [SerializeField] private float range;

    private float fireRate;
    private float fireCooldown;

    private void Start()
    {
        fireCooldown = fireRate;
    }

    private void Update()
    {
        //fire rate timer
        if(fireCooldown >= 0)
        {
            fireCooldown -= Time.deltaTime;
        }else
        //enemy targeting and attack
        {
            Attack();
        }
    }

    private void Attack()
    {

    }
}
