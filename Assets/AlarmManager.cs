using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlarmManager : MonoBehaviour {

    public GameObject OFFalarm;
    public GameObject ONalarm;
    public AudioClip siren;
    AudioSource audioSource;


	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        //   AlarmToggle();

       
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("titleScreen");
            }
        }
	}


    public void AlarmToggle()
    {
        
        if(!audioSource.isPlaying)
        {
            OFFalarm.SetActive(false);
            ONalarm.SetActive(true);

            audioSource.clip = siren;
            audioSource.Play();
        }else if (audioSource.isPlaying)
        {
            

            OFFalarm.SetActive(true);
            ONalarm.SetActive(false);

            audioSource.clip = siren;
            audioSource.Stop();
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
}
