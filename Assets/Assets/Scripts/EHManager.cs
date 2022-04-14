using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EHManager : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    public void UpdateScene()
    {
        SceneManager.LoadScene("UpdateScene");
    }
    // Update is called once per frame
    void Update(){
        if (Application.platform == RuntimePlatform.Android){
            if (Input.GetKeyDown(KeyCode.Escape)){
                UpdateScene();
            }
        }
    }

    public void Dial()
    {
        Application.OpenURL("tel://09274073781");
    }

    public void Dial2()
    {
        Application.OpenURL("tel://09274073781");
    }

    public void Dial3()
    {
        Application.OpenURL("tel://09274073781");
    }

    public void SAMPLE()
    {
        Application.OpenURL("tel://09274073781");
    }

    public void SAMPLE2()
    {
        Application.OpenURL("tel://09274073781");
    }
    public void DialCell()
    {
        Application.OpenURL("tel://09274073781");
    }
}
