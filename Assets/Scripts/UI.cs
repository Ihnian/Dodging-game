using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject settings;
    public bool i;
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
    public void Settings()
    {
        i = true;
        if (i)
        {
            settings.SetActive(true);
            i = false;       
        }
        if (i == false)
        {
            settings.SetActive(false);
            i = true;
        }

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }

}
