using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Map1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Map2()
    {
        SceneManager.LoadScene("Map2");
    }
}
