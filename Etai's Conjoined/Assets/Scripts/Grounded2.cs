using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded2 : MonoBehaviour
{
    
    GameObject player2; 
    // Start is called before the first frame update
    void Start()
    {
       player2 = gameObject.transform.parent.gameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.collider.tag == "Ground") {
            player2.GetComponent<Move2D_P2>().isGrounded2 = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.collider.tag == "Ground") {
            player2.GetComponent<Move2D_P2>().isGrounded2 = false;
        }
    }
}
