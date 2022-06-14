using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CovidManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
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

    public void titleScreen()
    {
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
