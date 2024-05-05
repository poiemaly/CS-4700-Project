using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{   
    
    public AttributesManager atm;
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Enemy"))
        {
            atm.TakeDamage(other.GetComponent<AttributesManager>().attack);
            Destroy(other.gameObject);
        }
    }
}
