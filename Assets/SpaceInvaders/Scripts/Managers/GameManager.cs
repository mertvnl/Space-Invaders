using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public UnityEvent OnGameWin = new UnityEvent();

    [HideInInspector]
    public UnityEvent OnGameLose = new UnityEvent();

    public void CompleteStage(bool status)
    {
        if (!LevelManager.Instance.IsLevelStarted)
            return;

        if (status)
        {
            OnGameWin.Invoke();
            LevelManager.Instance.ReloadLevel(0.5f);
        }
        else
        {
            OnGameLose.Invoke();
            LevelManager.Instance.ReloadLevel(0.5f);
        }
    }
}
