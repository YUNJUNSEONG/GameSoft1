using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UICon : MonoBehaviour
{
    public Button OBTN;
    public Button XBTN;
    public Button button;

    public Text relaxText;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ClickBTN);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBTN()
    {
        SceneManager.LoadScene("NewMap");
    }

    public void ClickO()
    {
        relaxText.text = "불침번을 세운다.";
    }

    public void ClickX()
    {
        relaxText.text = "불침번을 세우지 않았다.";
    }
}
