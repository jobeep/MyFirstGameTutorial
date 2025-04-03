using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public Asteroid asteroid;

    public float timeDelay = 1f;
    private float timeBefore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeBefore = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeBefore > timeDelay)
        {
            Instantiate(asteroid);
            timeBefore = Time.time;
        }

    }
}
