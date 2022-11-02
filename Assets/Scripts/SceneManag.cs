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
        if(cenaName == "MesaMonitor"){
            Player.pontoConfianca = 1f;
        } 
        if(cenaName == "ExameCoracao"){
            if(KidInstante.kid!=null){
                SceneManager.LoadScene(cenaName);
            }
        } else {
            SceneManager.LoadScene(cenaName);
        }
        
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
