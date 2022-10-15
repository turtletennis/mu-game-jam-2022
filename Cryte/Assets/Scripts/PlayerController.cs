using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    Vector2 moveDirection;
    [SerializeField] float moveSpeed = 2;
    [SerializeField] float rotateSpeed = 45;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveAmount = new Vector3(0,0,moveDirection.y) * Time.deltaTime * moveSpeed;
        float turnAmount = moveDirection.x * Time.deltaTime * rotateSpeed;
        transform.RotateAround(transform.position,transform.up,turnAmount);
        transform.Translate(moveAmount);
    }

    void OnMove(InputValue input)
    {
        Debug.Log(transform.forward * moveDirection.y * moveSpeed);
        moveDirection = input.Get<Vector2>();
        Debug.Log(moveDirection);
    }
}
