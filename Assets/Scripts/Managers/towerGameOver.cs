using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class towerGameOver : MonoBehaviour
{
    public AttributesManager atm;

    void Update() {
        if(atm.getHealth() <= 0)
        {
            // Add game scene name
            SceneManager.LoadScene("GameOver");
           
        }
    }
}
