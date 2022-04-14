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
        SceneManager.LoadScene("titleScreen");
    }


    public void FloodScene()
    {
        SceneManager.LoadScene("FloodScene");
    }
    public void EQScene()
    {
        SceneManager.LoadScene("EQScene");
    }
    public void FireScene()
    {
        SceneManager.LoadScene("FireScene");
    }
    public void CovidScene()
    {
        SceneManager.LoadScene("Covidscene");
    }

    void AndriodBack()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                TitleScene();
                return;
            }

        }


    }

}
