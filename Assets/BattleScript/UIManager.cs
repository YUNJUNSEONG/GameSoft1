using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button party;
    public GameObject partyView;
    // Start is called before the first frame update
    void Start()
    {
        party.onClick.AddListener(PartyBTN);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            partyView.SetActive(false);
        }
    }

    public void PartyBTN()
    {
        partyView.SetActive(true);
    }
}
