using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LampFlicker : MonoBehaviour
{
    public Light2D Light;
    private float random;

    public float AcceratedTime;

    private void Start()
    {
        random = Random.Range(0.0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        float maxInt = 15.2f;
        float minInt = 2.0f;
        float noise = Mathf.PerlinNoise(random, Time.time * AcceratedTime);

        Light.intensity = Mathf.Lerp(minInt,maxInt, noise);
    }
}
