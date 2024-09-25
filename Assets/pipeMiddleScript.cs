using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    public logicManagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("ontrigger")]
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer==3){
            logic.addScore(1);
            logic.getPoint();
        }

    }
}
