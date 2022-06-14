using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdminThemesManager : MonoBehaviour
{
    [Header("UI")]
    public Text messageText;

    void Start()
    {

    }

    void Update()
    {
        AndroidBack();
    }


    public void ThemesClick()
    {
        
                    if (PlayerPrefs.GetString("Theme") == "Yellow")
                    {
                        SceneManager.LoadScene("ThemesYellow");
                    }
                    else if (PlayerPrefs.GetString("Theme") == "Green")
                    {
                        SceneManager.LoadScene("ThemesGreen");
                    }
                    else if (PlayerPrefs.GetString("Theme") == "Red")
                    {
                        SceneManager.LoadScene("ThemesRed");
                    }
                    else if (PlayerPrefs.GetString("Theme") == "Black")
                    {
                        SceneManager.LoadScene("ThemesBlack");
                    }
                    else if (PlayerPrefs.GetString("Theme") == "Violet")
                    {
                        SceneManager.LoadScene("ThemesViolet");
                    }
                    else
                    {
                        SceneManager.LoadScene("Themes");
                    }
                
    }

    public void Back()
    {
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
    }


    public void DefaultButton()

{
        SaveBlue();


}
    public void SaveBlue()
    {
        PlayerPrefs.SetString("Theme", "Blue");
        PlayerPrefs.Save();

        messageText.text = "Successfully Changed!!! Please relogin.";

    }

    public void BlackButton()

{
        SaveBlack();
}

    public void SaveBlack()
    {
        PlayerPrefs.SetString("Theme", "Black");
        PlayerPrefs.Save();

        messageText.text = "Successfully Changed!!! Please relogin.";

    }

    public void RedButton()

{
    SaveRed();
}

public void SaveRed()
{
    PlayerPrefs.SetString("Theme", "Red");
    PlayerPrefs.Save();

    messageText.text = "Successfully Changed!!! Please relogin.";

}


public void PurpleButton()

{
        SavePurple();

}
    public void SavePurple()
    {
        PlayerPrefs.SetString("Theme", "Violet");
        PlayerPrefs.Save();

        messageText.text = "Successfully Changed!!! Please relogin.";

    }



    public void YellowButton()

{
    SaveYellow();
}

public void SaveYellow()
{
    PlayerPrefs.SetString("Theme", "Yellow");
    PlayerPrefs.Save();

    messageText.text = "Successfully Changed!!! Please relogin.";

}

public void GreenButton()

{
        SaveGreen();
}

    public void SaveGreen()
    {
        PlayerPrefs.SetString("Theme", "Green");
        PlayerPrefs.Save();

        messageText.text = "Successfully Changed!!! Please relogin.";

    }

    void AndroidBack()
{

    if (Application.platform == RuntimePlatform.Android)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
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
        }
    }
}
}