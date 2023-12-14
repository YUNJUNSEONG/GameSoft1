using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickNode : MonoBehaviour, IPointerClickHandler
{
    public List<GameObject> CheckEnd1;
    public List<GameObject> CheckEnd2;

    public GameObject RelaxActive;
    public GameObject TreasureActive;
    public GameObject O; // �޽ĳ��
    public GameObject X; // �޽ĳ��
    public GameObject O_T; // �������ڿ�
    public GameObject X_T; // �������ڿ�

    public Text relaxTXT;
    public Text TreasureTXT;
    public bool isEnter;
    public AudioClip enterNode;

    AudioSource audioSource;

    int percent;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            print("���䰡?");
            if (gameObject.tag == "Battle"/* && isEnter*/)
            {
                audioSource.PlayOneShot(enterNode);
                print("��Ʋ?");
                //isEnter = false;
                //foreach (GameObject go in CheckEnd1)
                //{
                //    go.GetComponent<ClickNode>().isEnter = true;
                //}
                //foreach (GameObject go in CheckEnd2)
                //{
                //    go.GetComponent<ClickNode>().isEnter = false;
                //}
                SceneManager.LoadScene("BattleScene");

            }
            else if (gameObject.tag == "Boss" && isEnter)
            {
                audioSource.PlayOneShot(enterNode);

                SceneManager.LoadScene("BattleScene");
            }
            else if (gameObject.tag == "Relax")
            {
                audioSource.PlayOneShot(enterNode);

                RelaxActive.SetActive(true);

                relaxTXT.text = "�� �� �ִ� ���� ã�Ҵ�\n ��ħ���� ����� ����?";
                O.SetActive(true); X.SetActive(true);
            }
            else if (gameObject.tag == "Treasure")
            {
                audioSource.PlayOneShot(enterNode);

                TreasureActive.SetActive(true);
                TreasureTXT.text = "���� ���ڸ� �߰��ߴ�";
                O_T.SetActive(true); X_T.SetActive(true);
            }
            else if(gameObject.tag == "Event")
            {
                audioSource.PlayOneShot(enterNode);

                percent = Random.Range(0, 100);
                percent++;
                if (percent >= 0 && 10 <= percent)
                {
                    print("����");
                }
                else if (percent >= 10 && 15 <= percent)
                {
                    print("�޽�");
                }
                else if (percent >= 15 && 20 <= percent)
                {
                    print("����");
                }
                else if (percent >= 20 && 55 <= percent)
                {
                    print("����");
                }
            }
        }

    }


}
