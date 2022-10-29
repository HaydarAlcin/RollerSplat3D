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
            //Material componenti Mesh Renderer�n i�inden eri�ilebiliyorr
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Constraits();
            
        }
    }


    
    //Rigidbody de bulunan Constraints b�l�m�ne kod ile ula��yoruz
    private void Constraits()
    {

        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
    }
}
