using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : HungMonoBehaviour
{
    [SerializeField] private static GameManager instance;
    public static GameManager Instance => instance;
    protected override void Start()
    {
        base.Start();
        this.ResumeGame();
    }
    protected override void Only1Script()
    {
        if (GameManager.instance != null) Debug.LogError("only 1 GameManager to allow");
        GameManager.instance = this;
    }
    public void ReloadScenen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
