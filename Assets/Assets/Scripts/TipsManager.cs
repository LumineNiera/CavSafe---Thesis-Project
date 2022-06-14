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
    //start
    {
        if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
            {
                SceneManager.LoadScene("SafetyTipsYellow");
            }
            else if (PlayerPrefs.GetString("Theme") == "Green")
            {
                SceneManager.LoadScene("SafetyTipsGreen");
            }
            else if (PlayerPrefs.GetString("Theme") == "Red")
            {
                SceneManager.LoadScene("SafetyTipsRed");
            }
            else if (PlayerPrefs.GetString("Theme") == "Black")
            {
                SceneManager.LoadScene("SafetyTipsBlack");
            }
            else if (PlayerPrefs.GetString("Theme") == "Violet")
            {
                SceneManager.LoadScene("SafetyTipsViolet");
            }
            else
            {
                SceneManager.LoadScene("SafetyTips");
            }
        }
        else
        {
            SceneManager.LoadScene("SafetyTipsGuest");
        }
    }
    //end

    public void TitleScreen()
    //start
    {
        if (PlayerPrefs.GetString("Role") == "Admin")
        {

            if (PlayerPrefs.GetString("Theme") == "Yellow")
            {
                SceneManager.LoadScene("AdminYellow");
            }
            else if (PlayerPrefs.GetString("Theme") == "Green")
            {
                SceneManager.LoadScene("AdminGreen");
            }
            else if (PlayerPrefs.GetString("Theme") == "Red")
            {
                SceneManager.LoadScene("AdminRed");
            }
            else if (PlayerPrefs.GetString("Theme") == "Black")
            {
                SceneManager.LoadScene("AdminBlack");
            }
            else if (PlayerPrefs.GetString("Theme") == "Violet")
            {
                SceneManager.LoadScene("AdminViolet");
            }
            else
            {
                SceneManager.LoadScene("adminScreen");
            }
        }
        else if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
            {
                SceneManager.LoadScene("NormalYellow");
            }
            else if (PlayerPrefs.GetString("Theme") == "Green")
            {
                SceneManager.LoadScene("NormalGreen");
            }
            else if (PlayerPrefs.GetString("Theme") == "Red")
            {
                SceneManager.LoadScene("NormalRed");
            }
            else if (PlayerPrefs.GetString("Theme") == "Black")
            {
                SceneManager.LoadScene("NormalBlack");
            }
            else if (PlayerPrefs.GetString("Theme") == "Violet")
            {
                SceneManager.LoadScene("NormalViolet");
            }
            else
            {
                SceneManager.LoadScene("titleScreen");
            }
        }
        else
        {
            SceneManager.LoadScene("GuestScreen");
        }
    }
    //end

    public void CovidScene()
    //start
    {
       if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
            {
                SceneManager.LoadScene("CovidSceneYellow");
            }
            else if (PlayerPrefs.GetString("Theme") == "Green")
            {
                SceneManager.LoadScene("CovidSceneGreen");
            }
            else if (PlayerPrefs.GetString("Theme") == "Red")
            {
                SceneManager.LoadScene("CovidSceneRed");
            }
            else if (PlayerPrefs.GetString("Theme") == "Black")
            {
                SceneManager.LoadScene("CovidSceneBlack");
            }
            else if (PlayerPrefs.GetString("Theme") == "Violet")
            {
                SceneManager.LoadScene("CovidSceneViolet");
            }
            else
            {
                SceneManager.LoadScene("CovidScene");
            }
        }
        else
        {
            SceneManager.LoadScene("CovidGuest");
        }
    }
    //end

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
                //start
                {
                     if (PlayerPrefs.GetString("Role") == "Normal")
                    {
                        if (PlayerPrefs.GetString("Theme") == "Yellow")
                        {
                            SceneManager.LoadScene("SafetyTipsYellow");
                        }
                        else if (PlayerPrefs.GetString("Theme") == "Green")
                        {
                            SceneManager.LoadScene("SafetyTipsGreen");
                        }
                        else if (PlayerPrefs.GetString("Theme") == "Red")
                        {
                            SceneManager.LoadScene("SafetyTipsRed");
                        }
                        else if (PlayerPrefs.GetString("Theme") == "Black")
                        {
                            SceneManager.LoadScene("SafetyTipsBlack");
                        }
                        else if (PlayerPrefs.GetString("Theme") == "Violet")
                        {
                            SceneManager.LoadScene("SafetyTipsViolet");
                        }
                        else
                        {
                            SceneManager.LoadScene("SafetyTips");
                        }
                    }
                    else
                    {
                        SceneManager.LoadScene("SafetyTipsGuest");
                    }
                }
                //end
            }

        }




    }



}
