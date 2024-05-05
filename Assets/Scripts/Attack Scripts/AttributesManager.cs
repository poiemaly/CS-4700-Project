using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    
    public int health;
    public int attack;
    public int currency;

    public void increaseCurrency(int amount)
    {

        GameStats.Money += amount;
    }


    public int getHealth(){
        return health;
    }


    public void setAttack(GameObject target, int attackDamage)
    {
        attack = attackDamage;
    }


    public void setHealth(GameObject target, int characterHealth)
    {
        health = characterHealth;
    }


    public void TakeDamage(int amount)
    {
        
        health -= amount;

    }
    

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if(atm != null)
        {   
            
            atm.TakeDamage(atm.attack);
            if(atm.health <=0)
            {
                target.SetActive(false);
            }   

        }
    }
}
