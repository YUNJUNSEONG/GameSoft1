using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragMap : MonoBehaviour
{
    private Vector3 lastMousePosition;

    private void Start()
    {

    }

    void Update()
    {
        DragMouse();
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 10f) pos.x = 10f;
        if (pos.x > 100f) pos.x = 100f;
        if (pos.y < 0f) pos.y = 0;
        if (pos.y > 550f) pos.y = 550f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    void DragMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 deltaMouse = Input.mousePosition - lastMousePosition;
            transform.Translate(deltaMouse.x, 0, 0);
            lastMousePosition = Input.mousePosition;
        }
    }
}
