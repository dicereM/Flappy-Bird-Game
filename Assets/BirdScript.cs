using System;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float offScreen;
    private AudioSource flap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && birdIsAlive == true)
        {
            Time.timeScale = 1;
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
            flap = GetComponent<AudioSource>();
            flap.Play();
        }


        // if bird goes offscreen, it dies
        if (transform.position.y > offScreen || transform.position.y < -offScreen)
        {
            if (birdIsAlive == true)
            {
               logic.gameOver();
                birdIsAlive = false;
                Debug.Log("Player went off Screen"); 
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive == true)
        {
           logic.gameOver();
            birdIsAlive = false;
            Debug.Log("Player hit a pipe"); 
        }   
    }

}
