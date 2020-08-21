using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3f;
    private float jumpForce = 7f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("Horizontal")*speed, GetComponent<Rigidbody2D>().velocity.y); 
        
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && (Physics2D.Raycast(transform.position + new Vector3(-0.5f,0,0), Vector2.down, 0.5f).collider != null
        || Physics2D.Raycast(transform.position + new Vector3(0.5f,0,0), Vector2.down, 0.5f).collider != null))
        { 
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce); 
        } 
    }
}
