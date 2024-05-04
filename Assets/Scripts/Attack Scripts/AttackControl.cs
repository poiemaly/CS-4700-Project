using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControl : MonoBehaviour
{


    private Animator anim;
    public float attackTimer;
    public GameObject weapon;
    public GameObject weapon2;
    

    private void Awake()
    {
        anim = GetComponent<Animator>();
        
    }
    
    private void stopAttack()
    {
        var col = weapon.GetComponent<Collider>();
        col.enabled = false;

    }

    private void weaponCollider()
    {
        var col = weapon.GetComponent<Collider>();
        col.enabled = true;

    }

    // Update is called once per frame
    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(weapon.activeSelf)
            {
                weaponCollider();
                Invoke(nameof(stopAttack), attackTimer);
                anim.SetTrigger("Attack");
            }

            if(weapon2.activeSelf)
            {
                weaponCollider();
                Invoke(nameof(stopAttack), attackTimer);
                anim.SetTrigger("AttackRollingPin");
            }
        }
    }

    
}
