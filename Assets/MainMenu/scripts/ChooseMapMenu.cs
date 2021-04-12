using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseMapMenu : MonoBehaviour
{
    [SerializeField] string mapName;

    public GameObject panel;
    public Slider slider;

    public void LoadMap (string mapName)
    {
        StartCoroutine(LoadAsync(mapName));
    }

    IEnumerator LoadAsync(string mapName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(mapName);
        panel.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;

            yield return null;
        }
    }
}