using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageTrap : MonoBehaviour
{
    public GameObject knifeTrap;
    public GameObject panTrap;
    private bool inArea = false;
    // Update is called once per frame
    void Update()
    {
        if (inArea) {
            if(Input.GetKeyDown(KeyCode.Q)){
                if (GameStats.Money >= 10) {
                    GameStats.Money -= 10;
                    GameObject newObject = Instantiate(knifeTrap, gameObject.transform.position, transform.rotation);
                    Debug.Log(gameObject.transform);
                } else {
                    Debug.Log("Your Broke");
                }
            } else if (Input.GetKeyDown(KeyCode.E)) {
                if (GameStats.Money >= 15) {
                    GameStats.Money -= 15;
                    GameObject newObject = Instantiate(panTrap, new Vector3(transform.position.x,transform.position.y+10,transform.position.z), new Quaternion(transform.rotation.x,transform.rotation.y+180,transform.rotation.z,1f));
                    Debug.Log(gameObject.transform);
                } else {
                    Debug.Log("Your Broke");
                }
            }
        }
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
