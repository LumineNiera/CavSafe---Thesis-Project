using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class TitlePageManager : MonoBehaviour 
{
    [Header("UI")]
    public Text notifText ;

    void Start()
    {       
        notifText.text = PlayerPrefs.GetString("Message");

    }

    //MAIN BUTTONS
    public void SafetyTipsScene ()
    
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

    public void UserGuideScene()
    
    //start
    {
       if (PlayerPrefs.GetString("Role") == "Normal")
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
        else
        {
            SceneManager.LoadScene("Guesthelp");
        }
    }
    //end

    public void titleScreen()
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
    public void GuestScreen()
    {
        PlayerPrefs.SetString("Role", "Guest");
        PlayerPrefs.Save();

        PlayerPrefs.SetString("Message", "");
        PlayerPrefs.Save();

        SceneManager.LoadScene("GuestScreen");
    }

    public void Map()
    {
        SceneManager.LoadScene("Map");
    }
  
    void Update () {

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        Start();
	}
}
