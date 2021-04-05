using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMapMenu : MonoBehaviour
{
    [SerializeField] string mapName;

    public void LoadMap (string mapName)
    {
        SceneManager.LoadScene(mapName);
    }
}