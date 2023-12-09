using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BattleMng : MonoBehaviour
{
    public GameObject[] partyList = new GameObject[4];
    public GameObject[] monsterList = new GameObject[4];
    public GameObject[] monster = new GameObject[8];
    public List<int> attackProcedure = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        partyList = GameManager.Instance.party;
        SetParty();
    }

    // Update is called once per frame
    void Update()
    {
        Battle();
    }

    void SetParty()
    {
        for(int i = 0; i < 4; i++)
        {
            if (partyList[i] != null)
            {
                if (i == 0)
                {
                    partyList[0].transform.position = new Vector3(-119,-30,13);
                    
                }
                else if (i == 1)
                {
                    partyList[1].transform.position = new Vector3(-136, -30, -31);
                    
                }
                else if (i == 2)
                {
                    partyList[2].transform.position = new Vector3(-246, -30, -19);
                    
                }
                else
                {
                    partyList[3].transform.position = new Vector3(-201, -30, 13);
                    
                }
                partyList[i].transform.localScale = new Vector3(30, 30, 30);
                Instantiate(partyList[i]);
            }

            int select = Random.Range(0, monster.Length);
            print(select);

            monsterList[i] = monster[select];

            if (i == 0)
            {
                monsterList[0].transform.position = new Vector3(102, -60, -19.8f);
            }
            if (i == 1)
            {
                monsterList[1].transform.position = new Vector3(127.8f, -56, -44.3f);
            }
            if (i == 2)
            {
                monsterList[2].transform.position = new Vector3(219.7f, -56, 13);
            }
            if (i == 3)
            {
                monsterList[3].transform.position = new Vector3(224, -56, -31);
            }
            monsterList[i].transform.localScale = new Vector3(30, 30, 30);
            Instantiate(monsterList[i]);
        }
    }

    void Battle()
    {
        int procedure = Random.Range(0, 8);
        for (int i = 0;i < 8; i++) 
        { 
            if (attackProcedure.Contains(procedure))
            {
                procedure = Random.Range(0, 8);
            }
            else
            {
                attackProcedure.Add(procedure);
                i++;
            }
        }
        if (attackProcedure[0] % 2 == 0) //player turn
        {

        }
        else //monster turn
        {
            
        }
    }
}
