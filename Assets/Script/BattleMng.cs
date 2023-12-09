using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMng : MonoBehaviour
{
    GameObject[] partyList;
    // Start is called before the first frame update
    void Start()
    {
        partyList = GetComponent<GameManager>().party;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
