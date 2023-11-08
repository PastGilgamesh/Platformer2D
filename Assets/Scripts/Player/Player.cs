using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    
    public Vector2 friction = new Vector2(.1f, 0);

    public float speed;

    public float forceJump = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleJump();
        HandleMoviment();
    }

    private void HandleMoviment() 
    {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        myRigidbody.velocity = new Vector2(-speed, myRigidbody.velocity.y);
        
        //myRigidbody.MovePosition(myRigidbody.position - velocity * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
    myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
            
            
    //myRigidbody.MovePosition(myRigidbody.position + velocity * Time.deltaTime);

    }

    if (myRigidbody.velocity.x > 0) 
    {
        myRigidbody.velocity -= friction;
    }
    else if (myRigidbody.velocity.x < 0)
    {
        myRigidbody.velocity += friction;
    }

    }

private void HandleJump() 
{

 if (Input.GetKeyDown(KeyCode.Space))
    {
        myRigidbody.velocity = Vector2.up * forceJump;
        
    }


}



}
