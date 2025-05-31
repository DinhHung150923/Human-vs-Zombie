using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerInHome : HungMonoBehaviour
{
    [SerializeField] private static UIManagerInHome instance;
    public static UIManagerInHome Instance => instance;
    protected override void Only1Script()
    {
        if (UIManagerInHome.instance != null) Debug.LogError("only 1 UIManagerInGame to allow");
        UIManagerInHome.instance = this;
    }
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
