using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerInHome : HungMonobehavior
{
    [SerializeField] private static UIManagerInHome instance;
    public static UIManagerInHome Instance => instance;
    [SerializeField] protected GameObject option;
    public GameObject Option => option;
    protected override void Start()
    {
        this.SetActiveUI();
    }
    protected override void Only1Script()
    {
        if (UIManagerInHome.instance != null) Debug.LogError("only 1 UIManagerInGame to allow");
        UIManagerInHome.instance = this;
    }
    protected override void LoadComponent()
    {
        this.LoadOption();
    }
    protected virtual void LoadOption()
    {
        if (this.option != null) return;
        this.option = GameObject.Find("Option");
        Debug.LogWarning(transform.name + " :LoadOption", gameObject);
    }
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void OpenOption()
    {
        this.option.SetActive(true);
    }
    public void CloseOption()
    {
        this.option.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    protected virtual void SetActiveUI()
    {
        this.CloseOption();
    }
}
