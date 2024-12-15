using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    public enum Scene
    {
        Main,
        Game
    }
    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Game.ToString());
    }
    public void LoadMain()
    {
        SceneManager.LoadScene(Scene.Main.ToString());
    }
    public void RetryGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}