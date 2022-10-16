using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEstetoscopio : MonoBehaviour
{
    private Vector2 mousePosition;

    private float deltaX, deltaY;

    private void OnMouseDown()
    {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
    }



}
