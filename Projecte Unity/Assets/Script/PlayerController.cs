using UnityEngine;
using System.Collections;



public enum MOVEMENTDIRECTION { UP, DOWN, LEFT, RIGHT, NONE };

public class PlayerController : MonoBehaviour {
    MOVEMENTDIRECTION lookingTo;
    public float speed = 0.05f;
    

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0);
            lookingTo = MOVEMENTDIRECTION.UP;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, speed, 0);
            lookingTo = MOVEMENTDIRECTION.DOWN;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0);
            lookingTo = MOVEMENTDIRECTION.RIGHT;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed, 0, 0);
            lookingTo = MOVEMENTDIRECTION.LEFT;
            
        }

        /* if (Input.GetKeyDown(KeyCode.W))
         {
             //GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1); //Moviment continuu
             /*Vector3 position = this.transform.position;               //Moviment a una casella per click
             position.y++;
             this.transform.position = position;/
             transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
             movementDirection = MOVEMENTDIRECTION.UP;
         }
         else if (Input.GetKeyDown(KeyCode.S))
         {
             //GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);  
             /*Vector3 position = this.transform.position;
             position.y--;
             this.transform.position = position;/
             transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
             movementDirection = MOVEMENTDIRECTION.DOWN;
         }
         else if (Input.GetKeyDown(KeyCode.A))
         {
             //GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
             /*Vector3 position = this.transform.position;
             position.x--;
             this.transform.position = position;/
             transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f); 
             movementDirection = MOVEMENTDIRECTION.LEFT;
         }
         else if (Input.GetKeyDown(KeyCode.D))
         {
             //GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
             /*Vector3 position = this.transform.position;
             position.x++;
             this.transform.position = position;/
             transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
             movementDirection = MOVEMENTDIRECTION.RIGHT;
         }
         /*else
         {
             GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
             movementDirection = MOVEMENTDIRECTION.NONE;
         }*/


        //if (movementDirection != MOVEMENTDIRECTION.NONE) lookingTo = movementDirection;
    }
}
