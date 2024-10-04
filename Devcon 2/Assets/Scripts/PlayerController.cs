using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public float moveSpeed = 10f;
    public bool interact;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        }
        if (Input.GetKey(left))
        {
            transform.Translate(new Vector2(-1, 0) * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            interact = true;
            Debug.Log("Player interact");
        }
    }
}
