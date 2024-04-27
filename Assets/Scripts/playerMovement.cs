using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
	public Transform orientation;
	float horizontalInput;
	float verticalInput;

	Vector3 moveDirection;
	public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

	private void FixedUpdate() {
		MovePlayer();
	}
	private void MyInput() {
		horizontalInput = Input.GetAxisRaw("Horizontal");
		verticalInput = Input.GetAxisRaw("Vertical");
	}

	private void MovePlayer() {
		moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

		rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);
	}
}
