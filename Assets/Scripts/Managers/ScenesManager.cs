using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public static ScenesManager instance;
    
    private void Awake(){
        instance = this;
    }

    public enum Scene{
        MainMenuWithScenesManager,
        MapWithScenesManager,
        PauseMenuWithScenesManager,
        GameOverWithScenesManager
    }

    public void LoadScene(Scene scene){
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame(){
        SceneManager.LoadScene(Scene.MapWithScenesManager.ToString());
    }

    public void LoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene(Scene.MainMenuWithScenesManager.ToString());
    }

    public void LoadPauseMenu(){
        SceneManager.LoadScene(Scene.PauseMenuWithScenesManager.ToString());
    }
}
