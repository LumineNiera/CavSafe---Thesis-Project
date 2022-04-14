using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

public class IPGrabber : MonoBehaviour
{
    string ipAddress;
    public string ipCountry, ipCity;
    public AppManager appManager;
    void Start()
    {
        StartCoroutine("GrabIP");
        StartCoroutine("IPLocation");
    }

    IEnumerator GrabIP()
    {
        var response = new UnityWebRequest("https://api.ipify.org")
        {
            downloadHandler = new DownloadHandlerBuffer()
        };

        if (response.isNetworkError || response.isHttpError)
        {
            yield break;
        }
        yield return response.SendWebRequest();
        
        yield return ipAddress = response.downloadHandler.text;
        
    }
    IEnumerator IPLocation()
    {
        var response = new UnityWebRequest("https://geo.ipify.org/api/v1?apiKey=at_xP1CQ4IuDawJQ1f1cOhl1g3qeVJDW&ipAddress="+ ipAddress)
            //("https://geo.ipify.org/api/v1?apiKey=at_FGzPAT0cEOBoBAdYtQh6rLF13POfE&ipAddress="+ipAddress)

        {
            downloadHandler = new DownloadHandlerBuffer()
        };
        yield return response.SendWebRequest();

        if(response.isNetworkError || response.isHttpError)
        {
            print("error");
            yield break;
        }

        JSONNode IPlocation = JSON.Parse(response.downloadHandler.text);
        yield return ipCity = IPlocation["location"]["city"];
        yield return ipCountry = IPlocation["location"]["country"];

        appManager.StartCoroutine("GetWeather");
    }

    
}
