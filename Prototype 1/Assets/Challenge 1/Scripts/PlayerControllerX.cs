using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 1f;
    public float rotationSpeed = 1f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
		// get the user's vertical input
		verticalInput = Input.GetAxis("Vertical");

		// move the plane forward or backward based on input
		transform.Translate(Vector3.forward * speed * Time.deltaTime );

		// tilt the plane up/down based on up/down arrow keys
		if (verticalInput != 0f) // Check if the user is pressing the up/down arrow keys
		{
			transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);
		}
	}
}
