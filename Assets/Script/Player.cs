using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float speed = 3f;
    private float jumpForce = 7f;
    private int score = 0;
    private int layer;
    private bool alive = true;
    private SpriteRenderer spriteRenderer;

    public GameObject maincamera;
    public Sprite[] red;
    public Sprite[] yellow;
    public Sprite[] blue;
    public Sprite[] green;
    public Text text;


    float camheight;
    float camwidth;
    // Start is called before the first frame update
    void Start()
    {
        layer = gameObject.layer;
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("Horizontal")*speed, GetComponent<Rigidbody2D>().velocity.y); 
        
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && 
        (Physics2D.Raycast(transform.position + new Vector3(-0.5f,0,0), Vector2.down, 0.5f).collider != null
        || Physics2D.Raycast(transform.position + new Vector3(0.5f,0,0), Vector2.down, 0.5f).collider != null))
        { 
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
            score += 1; 
            gameObject.layer += 1;
            Sprite img = spriteRenderer.sprite;
            print(img);
            print(red[0]);
            if(img == red[0]) 
            {
                spriteRenderer.sprite = yellow[0];
            }
            else if(img == yellow[0]) 
            {
                spriteRenderer.sprite = blue[0];
            }
            else if(img == blue[0]) 
            {
                spriteRenderer.sprite = green[0];
            }
            else if(img == green[0]) 
            {
                spriteRenderer.sprite = red[0];
            }

            print(gameObject.layer);
            if (gameObject.layer > 12)
            {
                gameObject.layer = layer;
            }
        }
        text.text = "Score: "+score.ToString();

    }
}
