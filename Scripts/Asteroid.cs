using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float yPos = 15F;
    public float ySpeed = 10f;

    private int xPos = 0;
    public float translation = 5f;

    void Awake()
    {
        xPos = Random.Range(-1, 2);
    }

    void Update()
    {
        yPos -= ySpeed * Time.deltaTime;

        if (this.transform.position.y > -15)
        {
            this.transform.position = new Vector2(xPos * this.translation, yPos);
        } else
        {
            Destroy(gameObject);
        }
    }
}
