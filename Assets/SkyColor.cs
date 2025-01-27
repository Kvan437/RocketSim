using System;
using UnityEngine;

public class SkyColor : MonoBehaviour
{

    public GameObject rocket;
    private float goal_altitude = 1000f;
    private Camera camera;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main.GetComponent<Camera>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        float current_altitude = rocket.transform.position.y;
        float red = ((((current_altitude / goal_altitude) * 177f) / 255f) / current_altitude * 100f) / 255;
        float green = (128-(current_altitude / goal_altitude)*128f)/255f;
        float blue = (255 - (current_altitude / goal_altitude) * 255f)/255f;

        camera.backgroundColor = new Color(red,green,blue);

        



    }
}
