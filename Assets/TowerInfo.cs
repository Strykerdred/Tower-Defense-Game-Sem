using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerInfo : MonoBehaviour
{
    public void TowerInfoLoad()
    {
        SceneManager.LoadScene("TowerInfo2");
    }
    public void TowerInfoScreen()
    {
        SceneManager.LoadScene("TowerInfo1");
    }
}
