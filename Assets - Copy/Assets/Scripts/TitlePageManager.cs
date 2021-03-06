using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TitlePageManager : MonoBehaviour 
{
    [SerializeField] private List<GameObject> SkySlideUp = new List<GameObject>();
    private int currentSlideupdisplay;

    public Animator titleScreen;
    public float transitionTime = 1f;


    public GameObject  displayMorning;
    public GameObject displayAfternoon;
    public GameObject displayEvening;

    /*
    public GameObject skyMorning;
    public GameObject skyAfternoon;
    public GameObject skyEvening;
*/
  

	// Use this for initialization
	void Start (){

       
     }

    void RealTimeDisplay()
    {
        int sysHour = System.DateTime.Now.Hour;
        if ((sysHour >= 13) && (sysHour < 18))
        {

            AfternoonDisplay();
            /*
            displayAfternoon.SetActive(true);
            skyAfternoon.SetActive(true);

            displayMorning.SetActive(false);
            skyMorning.SetActive(false);

            displayEvening.SetActive(false);
            skyEvening.SetActive(false);

            Debug.Log("Good Afternoon!");
            */
        }

        else if ((sysHour >= 1) && (sysHour < 12))
        {

            MorningDisplay();
            /*
            displayMorning.SetActive(true);
            skyMorning.SetActive(true);

            displayAfternoon.SetActive(false);
            skyAfternoon.SetActive(false);

            displayEvening.SetActive(false);
            skyEvening.SetActive(false);
            Debug.Log("Good Morning!");
            */

        }

        else if ((sysHour >=19) && (sysHour < 24))
        {

            EveningDisplay();
         //   EveningDisplay();
            /*
            displayEvening.SetActive(true);
            skyEvening.SetActive(true);

            displayAfternoon.SetActive(false);
            skyAfternoon.SetActive(false);

            displayMorning.SetActive(false);
            skyMorning.SetActive(false);
            Debug.Log("Evening");
            */

        }

        else
            
            displayEvening.SetActive(true);
       //skyEvening.SetActive(true);
            
    }


    private void MorningDisplay(){
        displayMorning.SetActive(true);
        currentSlideupdisplay = 0;

        if (currentSlideupdisplay == 0)
        {
            disableALLSlide();
            SkySlideUp[currentSlideupdisplay].SetActive(true);

        }
           
    }


    private void AfternoonDisplay() {
        displayAfternoon.SetActive(true);
        currentSlideupdisplay = 1;

        if (currentSlideupdisplay == 1)
        {
            disableALLSlide();
            SkySlideUp[currentSlideupdisplay].SetActive(true);

        }
    }

    private void EveningDisplay() {
        displayEvening.SetActive(true);
        currentSlideupdisplay = 2;

        if (currentSlideupdisplay == 2)
        {
            disableALLSlide();
            SkySlideUp[currentSlideupdisplay].SetActive(true);

        }
    }





   



    private void disableALLSlide()
    {
        for (int i = 0; i < SkySlideUp.Count; i++)
        {
            SkySlideUp[i].SetActive(false);
        }
    }
	


    //MAIN BUTTONS
    public void SafetyTipsScene (){
        SceneManager.LoadScene("SafetyTips"); 
    }
    public void  UpdateScene(){
        SceneManager.LoadScene("UpdateScene"); 
    }
    public void UserGuideScene()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void loginScene()
    {
        SceneManager.LoadScene("Login");
    }

    public void titleScreenDisplay(){
            titleScreen.SetTrigger("titleScreen");
    }

    

    public void Map(){
        SceneManager.LoadScene("Map");
    }
    public void CompassScene()
    {
        SceneManager.LoadScene("CompassScene");
    }



	// Update is called once per frame
	void Update () {


        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
       RealTimeDisplay();
	}



     
}
