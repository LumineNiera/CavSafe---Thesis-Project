using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class TitlePageManager : MonoBehaviour 
{
    [Header("UI")]
    public Text notifText ;

    [SerializeField] private List<GameObject> SkySlideUp = new List<GameObject>();
    private int currentSlideupdisplay;

    /*public Animator titleScreen;
    public float transitionTime = 1f;
    */

    public GameObject displayMorning;
    public GameObject displayAfternoon;
    public GameObject displayEvening;

    public GameObject skyMorning;
    public GameObject skyAfternoon;
    public GameObject skyEvening;


   

	// Use this for initialization
	void Start (){

        
     }

    void RealTimeDisplay()
    {
        notifText.text = PlayfabManager.strEmail;

        //int sysHour = System.DateTime.Now.Hour;
        //if ((sysHour >= 12) && (sysHour < 17))
        //{

        //    AfternoonDisplay();
            
        //    displayAfternoon.SetActive(true);
        //    //skyAfternoon.SetActive(true);

        //    displayMorning.SetActive(false);
        //    //skyMorning.SetActive(false);

        //    displayEvening.SetActive(false);
        //    //skyEvening.SetActive(false);

        //  //  Debug.Log("Good Afternoon!");
            
        //}

        //else if ((sysHour >= 0) && (sysHour < 11))
        //{

        //    MorningDisplay();
            
        //    displayMorning.SetActive(true);
        //    //skyMorning.SetActive(true);

        //    displayAfternoon.SetActive(false);
        //    //skyAfternoon.SetActive(false);

        //    displayEvening.SetActive(false);
        //    //skyEvening.SetActive(false);
        //    //Debug.Log("Good Morning!");
            

        //}

        //else if ((sysHour >=18) && (sysHour < 23))
        //{

        //    EveningDisplay();
            
        //    displayEvening.SetActive(true);
        //    //skyEvening.SetActive(true);

        //    displayAfternoon.SetActive(false);
        //    //skyAfternoon.SetActive(false);

        //    displayMorning.SetActive(false);
        //    //skyMorning.SetActive(false);
        //    //Debug.Log("Good Evening");
            

        //}

        //else
            
        //    displayEvening.SetActive(true);
            
    }


    //private void MorningDisplay(){
    //    displayMorning.SetActive(true);
    //    currentSlideupdisplay = 0;

    //    if (currentSlideupdisplay == 0)
    //    {
    //        disableALLSlide();
    //        SkySlideUp[currentSlideupdisplay].SetActive(true);

    //    }
           
    //}


    //private void AfternoonDisplay() {
    //    displayAfternoon.SetActive(true);
    //    currentSlideupdisplay = 0;

    //    if (currentSlideupdisplay == 1)
    //    {
    //        disableALLSlide();
    //        SkySlideUp[currentSlideupdisplay].SetActive(true);

    //    }
    //} 

    //private void EveningDisplay() {
    //    displayEvening.SetActive(true);
    //    currentSlideupdisplay = 0;

    //    if (currentSlideupdisplay == 2)
    //    {
    //        disableALLSlide();
    //        SkySlideUp[currentSlideupdisplay].SetActive(true);

    //    }
    //}


    //private void disableALLSlide()
    //{
    //    for (int i = 0; i < SkySlideUp.Count; i++)
    //    {
    //        SkySlideUp[i].SetActive(false);
    //    }
    //}
	


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
    public void Login()
    {
        SceneManager.LoadScene("Login");
    }
    public void loginregisterScreen()
    {
        SceneManager.LoadScene("LoginRegister");
    }
    public void titleScreen()
    {
        SceneManager.LoadScene("titleScreen");
    }
    public void GuestScreen()
    {
        SceneManager.LoadScene("GuestScreen");
    }
    public void Map()
    {
        SceneManager.LoadScene("Map");
    }

    /*
    public void titleScreenDisplay(){
            titleScreen.SetTrigger("titleScreen");
    }
    */



    /*
    public void CompassScene()
    {
        SceneManager.LoadScene("CompassScene");
    }
    */


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
