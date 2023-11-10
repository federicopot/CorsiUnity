using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)){
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up*7.5f, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    void OnColliderExit2D(Collider2D coll){
        isJumping = false;
    }
}
