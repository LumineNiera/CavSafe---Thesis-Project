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

    public void NewsUpdate(){
        SceneManager.LoadScene("NewsUpdates");
    }
    public void WeatherUpdate(){
        SceneManager.LoadScene("WeatherUpdates");
    }
    public void CovidUpdate(){
        SceneManager.LoadScene("CovidUpdates");
    }
    public void Map() {
        SceneManager.LoadScene("Map");
    }

    public void SearchNavigation(){
        SceneManager.LoadScene("SearchNavigation");
    }

    public void EmergencyHotline(){
        SceneManager.LoadScene("EmergencyHotline");
    }
    public void TitleScreen(){
        SceneManager.LoadScene("titleScreen");
    }
    public void CompassScene()
    {
        SceneManager.LoadScene("CompassScene");
    }
    public void AlarmScene()
    {
        SceneManager.LoadScene("Alarm");
    }


    private void AndriodBack(){
        if (Application.platform == RuntimePlatform.Android){
            if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene("titleScreen");
            }
        }
    }


}
