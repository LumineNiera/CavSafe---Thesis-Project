using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserGuideManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AndriodBack();

    }
    public void Scene1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void TitleScreen()
    {
        SceneManager.LoadScene("titleScreen");
    }

    private void AndriodBack()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("titleScreen");
            }

        }


    }

}
