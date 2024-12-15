using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button startGame;
    [SerializeField] Button exitGame;

    void Start()
    {
        startGame.onClick.AddListener(StartGame);
        exitGame.onClick.AddListener(QuitGame);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ScenesManager.Instance.QuitGame();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ScenesManager.Instance.LoadNewGame();
        }
    }

    private void StartGame()
    {
        // ScenesManager.Instance.LoadScene(ScenesManager.Scene.Game);
        ScenesManager.Instance.LoadNewGame();
    }

    private void QuitGame()
    {
        ScenesManager.Instance.QuitGame();
    }
}