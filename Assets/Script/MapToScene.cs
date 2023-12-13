using Map;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapToScene : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.Find("Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        MousePos();
    }

    void MousePos()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.gameObject.GetComponent<MapNode>().Node.nodeType == NodeType.Battle)
                {
               
                }
            }
        }
    }
}
