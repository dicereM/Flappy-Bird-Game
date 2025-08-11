using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float SpawnRate;
    private float timer = 0;
    public float HeightOffset;
    public float pipeDistance = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate - GameObject.Find("Logic Manager").GetComponent<LogicScript>().playerScore*0.016f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    public void spawnPipe()
    {
        float lowestPoint = transform.position.y - HeightOffset;
        float highestPoint = transform.position.y + HeightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Debug.Log("Pipe Spawned");
    }

}
