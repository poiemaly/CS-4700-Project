using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switch : MonoBehaviour
{
    public void sceneChanger(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
