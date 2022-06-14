using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafetyTitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AndriodBack();
	}
    public void TitleScene()
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


    public void FloodScene()
    {
        if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("FloodSceneYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("FloodSceneGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("FloodSceneRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("FloodSceneBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("FloodSceneViolet");
        }
        else
        {
            SceneManager.LoadScene("FloodScene");
        }
        }
        else
        {
            SceneManager.LoadScene("FloodSceneGuest");
        }
    }

    public void EQScene()
    {
            if (PlayerPrefs.GetString("Role") == "Normal")
            {
                if (PlayerPrefs.GetString("Theme") == "Yellow")
                {
                    SceneManager.LoadScene("EQSceneYellow");
                }
                else if (PlayerPrefs.GetString("Theme") == "Green")
                {
                    SceneManager.LoadScene("EQSceneGreen");
                }
                else if (PlayerPrefs.GetString("Theme") == "Red")
                {
                    SceneManager.LoadScene("EQSceneRed");
                }
                else if (PlayerPrefs.GetString("Theme") == "Black")
                {
                    SceneManager.LoadScene("EQSceneBlack");
                }
                else if (PlayerPrefs.GetString("Theme") == "Violet")
                {
                    SceneManager.LoadScene("EQSceneViolet");
                }
                else
                {
                    SceneManager.LoadScene("EQScene");
                }
            }
            else
            {
                SceneManager.LoadScene("EQSceneGuest");
            }
     }
    public void FireScene()
    {
            if (PlayerPrefs.GetString("Role") == "Normal")
            {
                if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("FireSceneYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("FireSceneGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("FireSceneRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("FireSceneBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("FireSceneViolet");
        }
        else
        {
            SceneManager.LoadScene("FireScene");
        }
        }
            else
        {
            SceneManager.LoadScene("FireSceneGuest");
        }
    }

    public void CovidScene()
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
                    SceneManager.LoadScene("CovidSceneGuest");
                }
        }
    

    private void AndriodBack()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                if (PlayerPrefs.GetString("Role") == "Normal")
                {
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
                else
                {
                    SceneManager.LoadScene("GuestScreen");
                }
                }
        }
    }

