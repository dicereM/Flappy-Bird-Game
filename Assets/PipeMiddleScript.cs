using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LogicScript logic;
    private AudioSource scoreSound;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && GameObject.Find("the BIRD").GetComponent<BirdScript>().birdIsAlive == true)
        {
            logic.addScore(1);
            scoreSound = GameObject.FindGameObjectWithTag("Respawn").GetComponent<AudioSource>();
            scoreSound.Play();
        }


    }
}
