using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocManage : MonoBehaviour
{
    [SerializeField] GameObject content;

    public void OpenDocument()
    {
        content.SetActive(true);
    }

    public void CloseDocument()
    {
        content.SetActive(false);
    }
}
