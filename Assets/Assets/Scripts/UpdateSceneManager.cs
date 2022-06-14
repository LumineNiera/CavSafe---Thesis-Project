using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AndriodBack();
	}

    public void NewsUpdate()
    {
        if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("NewsUpdatesYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("NewsUpdatesGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("NewsUpdatesRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("NewsUpdatesBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("NewsUpdatesViolet");
        }
        else
        {
            SceneManager.LoadScene("NewsUpdates");
        }
        }
        else
        {
            SceneManager.LoadScene("NewsUpdatesGuest");
        }
    }

    public void WeatherUpdate()
    {
        if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("WeatherUpdatesYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("WeatherUpdatesGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("WeatherUpdatesRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("WeatherUpdatesBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("WeatherUpdatesViolet");
        }
        else
        {
            SceneManager.LoadScene("WeatherUpdates");
        }
        }
        else
        {
            SceneManager.LoadScene("WeatherUpdatesGuest");
        }
    }
    public void CovidUpdate()
    {
        if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("CovidUpdatesYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("CovidUpdatesGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("CovidUpdatesRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("CovidUpdatesBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("CovidUpdatesViolet");
        }
        else
        {
            SceneManager.LoadScene("CovidUpdates");
        }
        }
        else
        {
            SceneManager.LoadScene("CovidUpdatesGuest");
        }
    }
    public void Map() {
        SceneManager.LoadScene("Map");
    }

    public void EmergencyHotline()

    {
        if (PlayerPrefs.GetString("Role") == "Normal")
        {
            if (PlayerPrefs.GetString("Theme") == "Yellow")
        {
            SceneManager.LoadScene("EmergencyHotlineYellow");
        }
        else if (PlayerPrefs.GetString("Theme") == "Green")
        {
            SceneManager.LoadScene("EmergencyHotlineGreen");
        }
        else if (PlayerPrefs.GetString("Theme") == "Red")
        {
            SceneManager.LoadScene("EmergencyHotlineRed");
        }
        else if (PlayerPrefs.GetString("Theme") == "Black")
        {
            SceneManager.LoadScene("EmergencyHotlineBlack");
        }
        else if (PlayerPrefs.GetString("Theme") == "Violet")
        {
            SceneManager.LoadScene("EmergencyHotlineViolet");
        }
        else
        {
            SceneManager.LoadScene("EmergencyHotline");
        }
        }
        else
        {
            SceneManager.LoadScene("EmergencyHotlineGuest");
        }
    }
    public void TitleScreen()
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


    private void AndriodBack(){

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


}
