using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public float moveSpeed = 10f;
    public bool interact = false;
    public bool facingRight = true;

    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        anim.SetFloat("Speed", Mathf.Abs(moveSpeed));

    }
    public void ChangeDirection(){
        //changes the players x scale to -1 so the sprite flips when changing direction -cc
        //www.youtube.com/watch?v=Cr-j7EoM8bg
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }

    private void FixedUpdate()
    {
                //Move controls
        if (Input.GetKey(down))
        {
            transform.Translate(new Vector2(0, -1) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(up))
        {
            transform.Translate(new Vector2(0, 1) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(right))
        {
            transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);
            if(!facingRight){
                ChangeDirection();
            }
        }
        if (Input.GetKey(left))
        {
            transform.Translate(new Vector2(-1, 0) * moveSpeed * Time.deltaTime);
            if (facingRight) {
                ChangeDirection();
            }
    
        }
        //checks if player is pressing left mouse button
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            interact = true;
        }
        if(Input.GetKeyUp(KeyCode.Mouse0)){
            interact = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

}
