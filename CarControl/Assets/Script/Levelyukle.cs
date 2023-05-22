using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelyukle : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    }
}
