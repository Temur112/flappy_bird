using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public logicManagerScript logic;
    public bool birdIsAlive = true; 
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManagerScript>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidBody.velocity = Vector2.up * flapStrength;
            logic.flapSound();
        }

        if(myRigidBody.transform.position.y >= 5.5f || myRigidBody.position.y <= -5.5f){
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
        logic.dieSound();
    }
}
