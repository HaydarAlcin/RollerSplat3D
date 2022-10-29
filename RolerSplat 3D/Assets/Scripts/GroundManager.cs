using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
   
    public Rigidbody rb;

    
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Girmedi");
        if (collision.gameObject.tag=="Ground")
        {
            //Material componenti Mesh Rendererýn içinden eriþilebiliyorr
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Constraits();
            
        }
    }


    
    //Rigidbody de bulunan Constraints bölümüne kod ile ulaþýyoruz
    private void Constraits()
    {

        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
    }
}
