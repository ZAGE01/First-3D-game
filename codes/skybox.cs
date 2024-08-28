using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox:MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.15f);
    }
}
