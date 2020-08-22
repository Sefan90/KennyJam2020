using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject grid1;
    public GameObject grid2;
    public GameObject grid3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * Time.deltaTime);

        if(transform.position.y-grid1.transform.position.y > 10f)
        {
            grid1.transform.position = new Vector3(0f,grid1.transform.position.y+24f,0f);
        }
        else if(transform.position.y-grid2.transform.position.y > 10f)
        {
            grid2.transform.position = new Vector3(0f,grid2.transform.position.y+24f,0f);
        }
        else if(transform.position.y-grid3.transform.position.y > 10f)
        {
            grid3.transform.position = new Vector3(0f,grid3.transform.position.y+24f,0f);
        }
    }
}
