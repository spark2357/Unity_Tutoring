using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody2d;

    [Header("플레이어 이동 속도")]
    public float player_speed = 5.0f;

    private void FixedUpdate()
    {
        Move_Check();
    }

    private void Move_Check()
    {
        Vector2 temp = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
            temp += Vector2.up;
        if (Input.GetKey(KeyCode.A))
            temp += Vector2.left;
        if (Input.GetKey(KeyCode.S))
            temp += Vector2.down;
        if (Input.GetKey(KeyCode.D))
            temp += Vector2.right;

        _rigidbody2d.MovePosition(_rigidbody2d.position + temp.normalized * player_speed * Time.deltaTime);
    }
}
