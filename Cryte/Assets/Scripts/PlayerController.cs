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
    // Start is called before the first frame update
    bool isRunning;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = isRunning ? runSpeed : moveSpeed;
        Vector3 moveAmount = new Vector3(0,0,moveDirection.y) * Time.deltaTime * speed;
        float turnAmount = moveDirection.x * Time.deltaTime * rotateSpeed;
        transform.RotateAround(transform.position,transform.up,turnAmount);
        transform.Translate(moveAmount);
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
