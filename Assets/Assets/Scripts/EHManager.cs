using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EHManager : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    public void UpdateScene()
    {
        if (PlayerPrefs.GetString("Role") == "Normal")
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
    // Update is called once per frame
    void Update(){
        if (Application.platform == RuntimePlatform.Android){
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (PlayerPrefs.GetString("Role") == "Normal")
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
        }
    }

    public void Dial()
    {
        Application.OpenURL("tel://09275017109");
    }

    public void Dial2()
    {
        Application.OpenURL("tel://09275017109");
    }

    public void Dial3()
    {
        Application.OpenURL("tel://09275017109");
    }

    public void SAMPLE()
    {
        Application.OpenURL("tel://09274073781");
    }

    public void SAMPLE2()
    {
        Application.OpenURL("tel://09274073781");
    }
    public void DialCell()
    {
        Application.OpenURL("tel://09274073781");
    }
}
