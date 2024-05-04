using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject CuttingBoardTrap;
    public GameObject panTrap;
    public Vector3 positionOffSet;
    private Vector3 location;
    
    private bool inArea = false;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Q)){
            if(GameStats.Money >= 10){
                //PurchaseCuttingBoard();
                GameStats.Money -= 10;
                Debug.Log(GameStats.Money);
            }
                
        }
        if(Input.GetKeyDown(KeyCode.E)){
            if(GameStats.Money >= 15){
                //PurchaseFryingPan();
                GameStats.Money -= 15;
                Debug.Log(GameStats.Money);
            }
        }
    }

    public void PurchaseCuttingBoard(){
        Debug.Log("Buying Cutting Board");
        Instantiate(CuttingBoardTrap, GetBuildPosition(), Quaternion.identity);
        //Instantiate(CuttingBoardTrap, currentPosition);
    }

    public void PurchaseFryingPan(){

        Instantiate(panTrap, GetBuildPosition(), Quaternion.identity);
        
        Debug.Log("Buying Frying Pan");
    }

    public Vector3 GetBuildPosition(){
        location = GameObject.FindGameObjectWithTag("Player").transform.position;
        return location + positionOffSet;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) {
            inArea = true;
        }
    }
    private void OnTriggerExit() {
        if (inArea) {
            inArea = false;
        }
    }


    
}
