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
        if((cenaName=="Casa")&&(ComparaSintomas.count==3)){
            Player.day++; 
            ComparaSintomas.count = 0;
            //Player.countFinalizouExame = 0;
            Debug.Log("Day:"+Player.day);
        } 
        SceneManager.LoadScene(cenaName);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
