using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCheck : MonoBehaviour
{
    

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("Flip");
        }
    }
}
