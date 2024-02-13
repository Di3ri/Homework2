using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public enum GameMode
    {
        First,
        Second,
    }

    public GameMode gameMode;

    public float timer = 0;
    
    public float delay = 0;

    public float maxtime = 10;

    public float speed = 4f;
    public bool move;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move = true;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameMode)
        {
            
            case GameMode.First:
                //checks if player can move
                if (move == true)
                {
                    //sets the a,s,w,d values as 1 or -1
                    float xMove = Input.GetAxisRaw("Horizontal");
                    float zMove = Input.GetAxisRaw("Vertical");
                    //allows access to x,z;
                    rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed;
                
                }
                //checks player usage of movement
                Exhaustion();
                //switches states
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gameMode = GameMode.Second;
                }
                break;


            case GameMode.Second:

                //sets the a,s,w,d values as 1 or -1
                float yMove = Input.GetAxisRaw("Vertical");
                //allows access to the y
                rb.velocity = new Vector3(rb.velocity.x,yMove, rb.velocity.z) * speed;

                break;
        }

    }

    public void Exhaustion()
    {
        //makes the player tired if walks to much
        if (Input.anyKey)
        {
            timer++;
            
           
            if (timer > maxtime)
            {
                move = false;
            }
        }
        else
        {
            //player recovers energy
            if (!Input.anyKeyDown)
            {
                delay++;
                
                if (delay > maxtime)
                {
                    move = true;

                }
            }
        }

        

    }

}
