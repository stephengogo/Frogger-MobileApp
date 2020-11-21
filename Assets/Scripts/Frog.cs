using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    private Rigidbody2D myBody;
    
    private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            myBody.MovePosition(myBody.position + Vector2.right);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            myBody.MovePosition(myBody.position + Vector2.left);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            myBody.MovePosition(myBody.position + Vector2.up);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            myBody.MovePosition(myBody.position + Vector2.down);

        if(Input.GetMouseButtonDown(0))
        {
            myBody.MovePosition(myBody.position + Vector2.up);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
