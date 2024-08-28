using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class playerPoints:MonoBehaviour
{
    private float timer = 0f;
    public int collectibles = 0;

    public GameObject t1 = null;
    public GameObject t2 = null;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.timer += Time.deltaTime;
        this.t1.GetComponent<TextMeshProUGUI>().text = "Time: " + this.timer.ToString("0");
        this.t2.GetComponent<TextMeshProUGUI>().text = "Collectibles: " + this.collectibles + "/5";

        PlayerPrefs.SetFloat("time", this.timer);
        PlayerPrefs.SetInt("collected", this.collectibles);
    }
}
