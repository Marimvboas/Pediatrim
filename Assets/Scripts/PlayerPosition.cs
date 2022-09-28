using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public static int pos = 1;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject player;

    void Start()
    {
        if(pos == 1)
        {
            player.transform.position = pos1.transform.position;
        }
        if (pos == 2)
        {
            player.transform.position = pos2.transform.position;
        }
    }
}
