using System.Net.Sockets;
using UnityEngine;

public class RocketControlScript : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity += new Vector2(0, 10);
        }
        float lin_vel = rb.linearVelocity.magnitude;
        float rocket_col = (lin_vel / 200f);

        gameObject.GetComponent<SpriteRenderer>().color = new Color(rocket_col, 0, 0);
    }
}
