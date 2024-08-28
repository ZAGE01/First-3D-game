using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endScreenText:MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float time1 = PlayerPrefs.GetFloat("time");
        int coins = PlayerPrefs.GetInt("collected");
        GameObject.Find("timeText").GetComponent<TextMeshProUGUI>().text = "Your time: " + time1.ToString("0.00") + " seconds";
        GameObject.Find("coinsText").GetComponent<TextMeshProUGUI>().text = "Collected coins: " + coins + "/5";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
