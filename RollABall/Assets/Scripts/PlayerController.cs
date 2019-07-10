﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    public Text scoreText;
    public Text livesText;

    private Rigidbody rb;
    private int count;
    private int score;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
       count = 0;
       score = 0;
       lives = 3;
       SetCountText ();
       winText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     float moveHorizontal = Input.GetAxis ("Horizontal");
     float moveVertical = Input.GetAxis ("Vertical");

     Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);

     rb.AddForce (movement*speed);

     if (Input.GetKey("escape"))
     {
       Application.Quit();
     }   
    }
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag ("Pickup"))
       {
           other.gameObject.SetActive (false);
           count = count + 1;
           score = score + 1;
           SetCountText ();
       }
       else if (other.gameObject.CompareTag("Enemy"))
       {
           other.gameObject.SetActive(false);
           count = count + 1;
           score = score - 1;
           lives = lives - 1;
           SetCountText();
       }
       if (count == 12)
       {
          transform.position = new Vector3(13.7f, transform.position.y,7.66f); 
       }
       if (lives == 0)
       {
           Destroy(this);
       }
    }
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        scoreText.text = "Score: " + score.ToString ();
        livesText.text = "Lives: " + lives.ToString ();
        if (score >= 18)
        {
            winText.text = "You Win!";
        }
    }
}
