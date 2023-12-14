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
    public GameObject O; // 휴식노드
    public GameObject X; // 휴식노드
    public GameObject O_T; // 보물상자용
    public GameObject X_T; // 보물상자용

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
            print("여긴가?");
            if (gameObject.tag == "Battle"/* && isEnter*/)
            {
                audioSource.PlayOneShot(enterNode);
                print("배틀?");
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

                relaxTXT.text = "쉴 수 있는 곳을 찾았다\n 불침번을 세우고 쉴까?";
                O.SetActive(true); X.SetActive(true);
            }
            else if (gameObject.tag == "Treasure")
            {
                audioSource.PlayOneShot(enterNode);

                TreasureActive.SetActive(true);
                TreasureTXT.text = "보물 상자를 발견했다";
                O_T.SetActive(true); X_T.SetActive(true);
            }
            else if(gameObject.tag == "Event")
            {
                audioSource.PlayOneShot(enterNode);

                percent = Random.Range(0, 100);
                percent++;
                if (percent >= 0 && 10 <= percent)
                {
                    print("동료");
                }
                else if (percent >= 10 && 15 <= percent)
                {
                    print("휴식");
                }
                else if (percent >= 15 && 20 <= percent)
                {
                    print("보물");
                }
                else if (percent >= 20 && 55 <= percent)
                {
                    print("전투");
                }
            }
        }

    }


}
