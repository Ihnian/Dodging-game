using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
