using UnityEngine;
using UnityEngine.Rendering;

public class PipesScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public float deadZone = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = GameObject.Find("Logic Manager").GetComponent<LogicScript>().playerScore * 0.1f + 5;
        transform.position = transform.position + moveSpeed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }

}
