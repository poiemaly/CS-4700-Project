using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public AttributesManager playerAttack;
    public GameObject currentWeapon;
    public GameObject newWeapon;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(currentWeapon.activeSelf)
            {
                currentWeapon.SetActive(false);
                newWeapon.SetActive(true);
                playerAttack.setAttack(playerAttack.gameObject, 3);
            }
            else if(newWeapon.activeSelf)
            {
                newWeapon.SetActive(false);
                currentWeapon.SetActive(true);
                playerAttack.setAttack(playerAttack.gameObject, 1);
            }
        }

    }
}
