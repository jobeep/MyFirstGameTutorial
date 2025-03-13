using UnityEngine;

public class Spaceship : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x != -10)
        {
            this.transform.position = new Vector2(this.transform.position.x - 10, -8);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x != 10)
        {
            this.transform.position = new Vector2(this.transform.position.x + 10, -8);
        }
    }
}
