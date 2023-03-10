using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    private Rigidbody rigidBody;
   [SerializeField] private int currentHealth; 

    [SerializeField] private int maxHealth = 100; 


    void Awake ()
    {
        //get the rigid body component 
        rigidBody =  GetComponent<Rigidbody>(); 
    }

    void  Update() 
    {
        Move();
        Jump();

    }
    
    void Move()
    {
        //get inputs
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(xInput, 0, zInput) * moveSpeed;
        dir.y = rigidBody.velocity.y;
        rigidBody.velocity = dir;

        Vector3 facingDir = new Vector3(xInput, 0, zInput);
        if (facingDir.magnitude > 0 )
        {
        transform.forward = facingDir; 
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            checkJumpForce();
        }
    }

    void checkJumpForce()
    {
        rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    
//For access to other scripts idk how else to do it without making my variables public which I dont want
    public int CurrentHealth 
    {
        get {return currentHealth;}
        set {currentHealth = value;}
    }

    public int MaxHealth 
    {
        get {return maxHealth;}
        set {maxHealth = value;}
    }
}
