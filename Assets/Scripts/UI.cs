using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is create
    public GameObject Settings;
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
    public void Settings_MM()
    {

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
    public void Settings_GM()
    {
        
    }
    public void resume(){
        Settings.SetActive(false);
    }

}
