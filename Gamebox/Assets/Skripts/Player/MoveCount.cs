using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCount : MonoBehaviour
{
    public float _speed = 6.0f;
    public float _speedRun;
    public float _speedCurrent;
    public float _jump;
    public float _gravity = -9.8f;
    float x_Move;
    float z_Move;

    private CharacterController player;
    Vector3 move_Direction;

    private void Start()
    {
        player = GetComponent<CharacterController>();
       // if (_characterController == null)
       //   Debug.Log("CharacterController is NULL");
    }
    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (player.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if (Input.GetKey(KeyCode.Space))
            {
                move_Direction.y += 10;
            }
        }
        move_Direction.y -= 1;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speedCurrent = _speedRun;
        }
        else
        {
            _speedCurrent = _speed;
        }
        player.Move(move_Direction * _speedCurrent * Time.deltaTime);





        /*
        float deltaX = Input.GetAxis("Horizontal") * _speed;
        float deltaZ = Input.GetAxis("Vertical") * _speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, _speed);
        movement.y = _gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _characterController.Move(movement);
        */
    }

    private void Update()
    {
        Move();
    }


}
