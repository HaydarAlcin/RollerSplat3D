using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody rb;

    private Vector2 firstPos;
    private Vector2 secondPos;
    public Vector2 currentPos;

    public float moveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        Swipe();
    }

    private void Swipe()
    {
        //Mouse basýlý durumdayken olacak þey
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        }

        //Mouse dan elimizi çektiðimizde olacak þey
        if (Input.GetMouseButtonUp(0))
        {
            secondPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);

            currentPos = new Vector2(secondPos.x-firstPos.x, secondPos.y - firstPos.y);
        }
        currentPos.Normalize();


        CoordinateDetection();
        
    }

    private void CoordinateDetection()
    {
        //Hareketi algýlayýp velocity ye deðer girme
        if (currentPos.y < 0 && currentPos.x >-0.5f && currentPos.x<0.5f)
        {
            //Back
            rb.velocity = Vector3.back * moveSpeed;
        }
        else if (currentPos.y > 0 && currentPos.x > -0.5f && currentPos.x < 0.5f)
        {
            //Forward
            rb.velocity = Vector3.forward * moveSpeed;

        }
        else if (currentPos.x < 0 && currentPos.y > -0.5f && currentPos.y < 0.5f)
        {
            //Left
            rb.velocity = Vector3.left * moveSpeed;

        }
        else if (currentPos.x > 0 && currentPos.y > -0.5f && currentPos.y < 0.5f)
        {
            //Right
            rb.velocity = Vector3.right * moveSpeed;

        }
    }

    
}
