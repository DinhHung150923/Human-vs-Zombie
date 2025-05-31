using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnNextLevel : BaseButton
{
    protected override void Onclick()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
