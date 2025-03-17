using UnityEngine;

public class Spaceship : MonoBehaviour
{

    public float yPos = -8f;

    public int xPos = 0;
    public float translation = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.xPos > -1)
        {
            this.xPos--;
            this.transform.position = new Vector2(xPos * this.translation, yPos);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.xPos < 1)
        {
            this.xPos++;
            this.transform.position = new Vector2(xPos * this.translation, yPos);
        }
    }
}
