using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LoadLevel(string sceneName)
    {
        // TODO: SceneManager ile sahneyi yükle
        SceneManager.LoadScene(sceneName);
    }
}