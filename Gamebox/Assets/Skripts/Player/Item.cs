using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    float distance = 3;

    private void OnMouseDrag()
    {
        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPossition = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = objPossition;
    }
}
