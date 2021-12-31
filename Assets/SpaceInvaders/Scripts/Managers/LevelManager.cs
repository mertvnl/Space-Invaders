using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager>
{
    [HideInInspector]
    public UnityEvent OnLevelFinish = new UnityEvent();

    [HideInInspector]
    public UnityEvent OnLevelStart = new UnityEvent();

    public bool IsLevelStarted;

    private void OnEnable()
    {

        OnLevelStart.Invoke();
        IsLevelStarted = true;
    }

    private void OnDisable()
    {

        OnLevelStart.Invoke();
        IsLevelStarted = true;
    }

    public void ReloadLevel(float delay)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int currentSceneIndex = currentScene.buildIndex;

        StartCoroutine(LoadLevelCo(delay, currentSceneIndex));
    }

    private IEnumerator LoadLevelCo(float delay, int levelIndex)
    {
        OnLevelFinish.Invoke();
        IsLevelStarted = false;

        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene(levelIndex);
    }
}
