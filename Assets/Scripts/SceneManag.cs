using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManag : MonoBehaviour
{
    [SerializeField] string cenaName;
    public void Change()
    {
        SceneManager.LoadScene(cenaName);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
