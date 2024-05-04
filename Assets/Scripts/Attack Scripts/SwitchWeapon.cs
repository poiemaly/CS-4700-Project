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
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon.SetActive(false);
            newWeapon.SetActive(true);
            playerAttack.setAttack(playerAttack.gameObject, 3);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            newWeapon.SetActive(false);
            currentWeapon.SetActive(true);
            playerAttack.setAttack(playerAttack.gameObject, 1);
        }

    }
}
