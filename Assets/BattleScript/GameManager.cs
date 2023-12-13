using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject[] party = new GameObject[4];
    public GameObject[] partys = new GameObject[4];

    public int rand;
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if(Instance == null)
            Instance = this;
        NPCGen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NPCGen()
    {
        rand = Random.Range(0, 4);
        party[0] = partys[rand]; //Instantiate(partys[rand]);
    }
}
