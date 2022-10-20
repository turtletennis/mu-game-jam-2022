using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    Vector2 moveDirection;
    [SerializeField] float moveSpeed = 2;
    [SerializeField] float rotateSpeed = 45;
    [SerializeField] float runSpeed = 4;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    bool isRunning;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = isRunning ? runSpeed : moveSpeed;
        Vector3 moveAmount = new Vector3(0,0,moveDirection.y) * Time.deltaTime * speed;
        float turnAmount = moveDirection.x *  rotateSpeed;
        if(isRunning) turnAmount *= 2;
        rigidbody.MoveRotation(rigidbody.rotation * Quaternion.AngleAxis(turnAmount*0.005f,rigidbody.transform.up));
        Vector3 newVelocity = new Vector3(rigidbody.velocity.x,rigidbody.velocity.y,speed*moveDirection.y);
        newVelocity = rigidbody.transform.forward * speed * moveDirection.y;
        newVelocity.y = rigidbody.velocity.y;
        //newVelocity = rigidbody.velocity;
        rigidbody.velocity=newVelocity;
    }

    private void OnCollisionEnter(Collision other) {
        
    }

    void OnMove(InputValue input)
    {
        
        moveDirection = input.Get<Vector2>();
        
    }

    void OnRun(InputValue input)
    {
        
        isRunning = input.Get<float>()==1;
    }

}
