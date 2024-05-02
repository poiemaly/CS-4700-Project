using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttributes : MonoBehaviour
{
    public AttributesManager atm;

    private void OnTriggerEnter(Collider other)
    {
        
        
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<AttributesManager>().TakeDamage(atm.attack);

            if(other.GetComponent<AttributesManager>().getHealth() <= 0){
                other.gameObject.SetActive(false);
                atm.increaseCurrency(10);
            }
            
        }
    }
}
