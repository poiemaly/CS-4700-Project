using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageTrap : MonoBehaviour
{
    private bool inArea = false;
    private Collider col;
    // Update is called once per frame
    void Update()
    {
        if (inArea) {
            if(Input.GetKeyDown(KeyCode.E))
                Debug.Log("The left mouse button was pressed");       

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) {
            inArea = true;
            col = other;
        }
    }
    private void OnTriggerExit() {
        if (inArea) {
            inArea = false;
        }
    }
}
