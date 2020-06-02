using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{

	public float moveSpeed;
	public Rigidbody theRB;
    public float jumpforce;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if(Input.GetButtonDown("Jump")){
            theRB.velocity = new Vector3(theRB.velocity.x, jumpforce, theRB.velocity.z);
        }
    }
}
