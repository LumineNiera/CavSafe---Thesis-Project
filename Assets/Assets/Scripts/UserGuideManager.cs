using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserGuideManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AndriodBack();

    }
    public void Scene1()
    {
        if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("yellowhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("greenhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("redhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("blackhelp");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("violethelp");
        }
        else
        {
            SceneManager.LoadScene("bluehelp");
        }
    }

    public void TitleScreen()
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

    private void AndriodBack()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
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
        }


    }

}
