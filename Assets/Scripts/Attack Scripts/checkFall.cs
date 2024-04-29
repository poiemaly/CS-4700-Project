using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkFall : MonoBehaviour
{
    public AttributesManager atm;
    
    void Start()
    {
  
    Time.timeScale = 1;
    }
    

    private void OnTriggerEnter(Collider other)
    {
       

        if(other.CompareTag("Enemy"))
        {
            
            other.GetComponent<AttributesManager>().setHealth(atm.gameObject, 0);
        }
        
        if(other.CompareTag("Player"))
        {
           
            SceneManager.LoadScene("GameOver");
        }
    }
}
