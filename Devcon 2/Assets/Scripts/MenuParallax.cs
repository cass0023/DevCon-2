using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuParallax : MonoBehaviour
{
    //REFERENCE: https://youtu.be/B40xBPXK97A?si=d5ELDX0YeJDdOMVd

    //Smooth time and multiplier
    public float offsetMultiplier = 1f;
    public float smoothTime = .3f;

    //Start position and velocity
    private Vector2 startPosition;
    private Vector3 velocity;



    // Start is called before the first frame update
    // When the player moves their mouse the menu will move
    // along with the cursor
    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 offset = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = Vector3.SmoothDamp(transform.position, startPosition + (offset * offsetMultiplier), ref velocity, smoothTime);
    }
}
