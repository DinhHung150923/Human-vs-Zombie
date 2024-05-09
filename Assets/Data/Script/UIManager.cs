using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : HungMonobehavior
{
    [SerializeField] private static UIManager instance;
    public static UIManager Instance => instance;
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
        if (UIManager.instance != null) Debug.LogError("only 1 UIManager to allow");
        UIManager.instance = this;
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
    protected virtual void SetAvtiveUI()
    {
        this.gameOverScreen.SetActive(false);
        this.victoryScreen.SetActive(false);
    }
}
