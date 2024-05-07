using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {
    public void OnSceneChange(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}