using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;



public class GameOver : MonoBehaviour
{
    [SerializeField] Button _restartGame;
    [SerializeField] Button _exitGame;
    

    // Start is called before the first frame update
    void Start()
    {
        _restartGame.onClick.AddListener(RestartGame);
        _exitGame.onClick.AddListener(ExitGame);
    }

    private void RestartGame(){
        Debug.Log("Restart");
        SceneManager.LoadScene("Map");
    }
    private void ExitGame(){
        Debug.Log("Exit");
        SceneManager.LoadScene("MainMenu");
    }
}
