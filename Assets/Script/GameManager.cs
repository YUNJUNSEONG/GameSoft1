using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] party = new GameObject[4];
    public GameObject[] partys = new GameObject[4];

    public int rand;
    // Start is called before the first frame update
    void Start()
    {
        NPCGen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NPCGen()
    {
        rand = Random.Range(0, 4);
        party[0] = Instantiate(partys[rand]);
    }
}
