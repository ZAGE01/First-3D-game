using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleCode:MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("soundclass/coins").GetComponent<AudioSource>().Play();

            GameObject.Find("codestorage").GetComponent<playerPoints>().collectibles++;
            Debug.Log("Collected!");
            Destroy(this.gameObject);
        }
    }


}
