using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _rb2d;

    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb2d.AddForce(Vector2.right * Speed, ForceMode2D.Force);
        } else
        if (Input.GetKey(KeyCode.A))
        {
            _rb2d.AddForce(Vector2.left * Speed, ForceMode2D.Force);
        }
    }
}
