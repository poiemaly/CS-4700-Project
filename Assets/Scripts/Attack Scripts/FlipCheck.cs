using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCheck : MonoBehaviour
{
    private Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Enemy"))
        {
            PlayAnim();
        
        }
    }

    /*void Start ()
    {
        InvokeRepeating("PlayAnim", 1.05f, 8f);
    }*/
    
 
    void PlayAnim () 
    {
    //play your anim here

        anim = GetComponent<Animator>();
        anim.SetTrigger("Flip");
    }

}
