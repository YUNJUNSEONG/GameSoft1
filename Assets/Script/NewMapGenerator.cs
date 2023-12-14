using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewMapGenerator : MonoBehaviour
{
    public int[,] map = new int[3, 5];
    public GameObject[] node = new GameObject[15];
    public Image[] nodeImg = new Image[15];
    public Sprite[] nodeTypeImag = new Sprite[6];
    int i = 0; int j = 0; int nodeType;
    void Start()
    {

        CheckMapArray();
    }

    void Update()
    {
        
    }

    void CheckMapArray()
    {
        for (i = 0; i < map.GetLength(0); i++) //i포문은 가로 길이만큼 돈다
        {
            
            for (j = 0; j < map.GetLength(1); j++) //j포문은 행렬의 세로 길이만큼 돈다
            {
                map[i, j] = Random.Range(0, 2); //1이면 노드 생성
            }

        }
        map[1, 0] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;
        map[1, 3] = 1;
        map[1, 4] = 1;

        for (int i = 0; i < 3; i++) // 생성할 때 무슨 타입의 노드인지도 결정
        {

            for (int j = 0; j < 5; j++)
            {
                if (map[i, j] == 1)
                {
                    nodeType = Random.Range(0, 5);
                    node[5*i + j].SetActive(true);

                    if (node[5*i + j] && nodeType == 0)
                    {
                        node[5 * i + j].tag = "Battle";
                        nodeImg[5 * i + j].sprite = nodeTypeImag[0];
                    }
                    if (node[5 * i + j] && nodeType == 1)
                    {
                        node[5 * i + j].tag = "Event";
                        nodeImg[5 * i + j].sprite = nodeTypeImag[1];
                    }
                    if (node[5 * i + j] && nodeType == 2)
                    {
                        node[5 * i + j].tag = "Friend";
                        nodeImg[5 * i + j].sprite = nodeTypeImag[2];
                    }
                    if (node[5 * i + j] && nodeType == 3)
                    {
                        node[5 * i + j].tag = "Relax";
                        nodeImg[5 * i + j].sprite = nodeTypeImag[3];
                    }
                    if (node[5 * i + j] && nodeType == 4)
                    {
                        node[5 * i + j].tag = "Treasure";
                        nodeImg[5 * i + j].sprite = nodeTypeImag[4];
                    }
                }
            }

        }

        node[0].tag = "Battle";
        nodeImg[0].sprite = nodeTypeImag[0];
        node[5].tag = "Battle";
        nodeImg[5].sprite = nodeTypeImag[0];
        node[10].tag = "Battle";
        nodeImg[10].sprite = nodeTypeImag[0];
    }
}
