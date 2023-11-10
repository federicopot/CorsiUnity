using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up, ForceMode.Inpulse);
        }
    }
}
