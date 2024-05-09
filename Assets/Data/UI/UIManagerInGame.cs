using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerInGame : HungMonobehavior
{
    [SerializeField] private static UIManagerInGame instance;
    public static UIManagerInGame Instance => instance;
    [SerializeField] protected GameObject gameOverScreen;
    public GameObject GameOverScreen => gameOverScreen;
    [SerializeField] protected GameObject victoryScreen;
    public GameObject VictoryScreen => victoryScreen;
    protected override void Start()
    {
        this.SetAvtiveUI();
    }
    protected override void Only1Script()
    {
        if (UIManagerInGame.instance != null) Debug.LogError("only 1 UIManagerInGame to allow");
        UIManagerInGame.instance = this;
    }
    protected override void LoadComponent()
    {
        this.LoadGameOverScenen();
        this.LoadVictoryScreen();
    }
    protected virtual void LoadGameOverScenen()
    {
        if (this.gameOverScreen != null) return;
        this.gameOverScreen = GameObject.Find("GameOverScreen");
        Debug.LogWarning(transform.name + " :LoadgameOverScreen", gameObject);
    }
    protected virtual void LoadVictoryScreen()
    {
        if (this.victoryScreen != null) return;
        this.victoryScreen = GameObject.Find("VictoryScreen");
        Debug.LogWarning(transform.name + " :LoadVictoryScreen", gameObject);
    }
    public void ReStartLevel()
    {
        GameManager.Instance.ReloadScenen();
    }
    protected virtual void SetAvtiveUI()
    {
        this.gameOverScreen.SetActive(false);
        this.victoryScreen.SetActive(false);
    }
}
