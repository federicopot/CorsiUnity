using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isJumping = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && !isJumping){
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up*8f, ForceMode2D.Impulse);
        }
        this.GetComponent<Animator>().SetBool("jump", isJumping);
    }

    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.name != "Ground"){
            Destroy(this.gameObject);
        }else{
            isJumping = false;
        }
    }
    void OnCollisionExit2D(Collision2D coll){
        isJumping = true;
    }
}
