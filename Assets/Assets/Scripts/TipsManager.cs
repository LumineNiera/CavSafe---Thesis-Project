using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipsManager : MonoBehaviour
{


    [SerializeField] private List<GameObject> Tips = new List<GameObject>();
    int currentTipDisplay;
   


    // Use this for initialization
    void Start()
    {

    }

    public void BeforeTips()
    {
        currentTipDisplay = 0;
        if (currentTipDisplay == 0)
        {
            CloseAlltips();
            Tips[currentTipDisplay].SetActive(true);
        }
    }

    public void DuringTips()
    {
        currentTipDisplay = 1;
        if (currentTipDisplay == 1)
        {
            CloseAlltips();
            Tips[currentTipDisplay].SetActive(true);
        }
    }



    public void AfterTips()
    {
        currentTipDisplay = 2;
        if (currentTipDisplay == 2)
        {
            CloseAlltips();
            Tips[currentTipDisplay].SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {

        AndroidBack();

    }

    public void CloseAlltips()
    {
        for (int i = 0; i < Tips.Count; i++)
        {
            if (Tips[i].activeInHierarchy)
            {
                Tips[i].SetActive(false);
            }
        }

    }

    public void SafetySCreen()
    {
        SceneManager.LoadScene("SafetyTips");
    }


    void AndroidBack()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (Tips[currentTipDisplay].activeInHierarchy)
                {
                    CloseAlltips();
                }
                else
                    SceneManager.LoadScene("SafetyTips");
                return;
            }

        }




    }



}
