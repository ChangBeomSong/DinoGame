using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIGameMenu : MonoBehaviour
{
    [SerializeField] Button mainMenu;
    //[SerializeField] Button retryGame;

    void Start()
    {
        mainMenu.onClick.AddListener(StartGame);
        //retryGame.onClick.AddListener(RetryGame);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ScenesManager.Instance.QuitGame();
        }

        if (Input.GetKey(KeyCode.M))
        {
            ScenesManager.Instance.LoadMain();
        }
    }

    private void StartGame()
    {
        ScenesManager.Instance.LoadMain();
    }

    private void RetryGame()
    {
        ScenesManager.Instance.RetryGame();
    }
}