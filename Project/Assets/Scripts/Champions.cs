using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Champions : MonoBehaviour
{

    string serviceData;
    Server[] playerInstance;
    private TextMesh FirstPlace;
    private TextMesh SecondPlace;
    private TextMesh ThirdPlace;
    private TextMesh FourthPlace;
    private TextMesh FifthPlace;
    public GameObject Back;
    void Awake()
    {
        StartCoroutine(LoadFromServer());
        FirstPlace = GameObject.Find("FirstPlace").GetComponent<TextMesh>();
        SecondPlace = GameObject.Find("SecondPlace").GetComponent<TextMesh>();
        ThirdPlace = GameObject.Find("ThirdPlace").GetComponent<TextMesh>();
        FourthPlace = GameObject.Find("FourthPlace").GetComponent<TextMesh>();
        FifthPlace = GameObject.Find("FifthPlace").GetComponent<TextMesh>();
        if (GiveDamage.time < 60)
        {
            Back.SetActive(true);
        }
        else
        {
            Back.SetActive(false);
        }
    }

    private void Update()
    {
        Places();


    }
    IEnumerator LoadFromServer()
    {
        var request = UnityWebRequest.Get("https://api.myjson.com/bins/1amu7o");

        yield return request.SendWebRequest();

        serviceData = (request.downloadHandler.text.Replace("players", "Items").Replace("d\":", "d\":" + "\"").Replace("ime\":", "ime\":\"").Replace(",\"n", "\",\"n").Replace("}", "\"}").Replace("]\"}", "]}"));

        Debug.Log(serviceData);
        playerInstance = JsonHelper.FromJson<Server>(serviceData);
        Debug.Log(playerInstance[0].id);
        request.Dispose();
    }

    void Places()
    {
        FirstPlace.text = ("1   " + playerInstance[4].name.ToString() + "   " + playerInstance[4].best_time.ToString());
        SecondPlace.text = ("2   " + playerInstance[3].name.ToString() + "   " + playerInstance[3].best_time.ToString());
        ThirdPlace.text = ("3   " + playerInstance[2].name.ToString() + "   " + playerInstance[2].best_time.ToString());
        FourthPlace.text = ("4   " + playerInstance[1].name.ToString() + "   " + playerInstance[1].best_time.ToString());
        FifthPlace.text = ("5   " + playerInstance[0].name.ToString() + "   " + playerInstance[0].best_time.ToString());
    }
}
