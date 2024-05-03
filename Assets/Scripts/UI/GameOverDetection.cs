using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverDetection : MonoBehaviour
{
    public GameObject player;
    public GameObject HUDUI;

    // Update is called once per frame
    void OnTriggerEnter(Collider Player){
        Debug.Log("Gameover");
        HUDUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        SceneManager.LoadScene("GameOverWithScenesManager");
    }

}
