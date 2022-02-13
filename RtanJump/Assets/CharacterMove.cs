using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D rigid;
    public SpriteRenderer renderer;

    public float moveSpeed;

    void Update()
    {
        Vector2 direction = Vector2.zero;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector2.left * moveSpeed;
            renderer.flipX = true;
        } 
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right * moveSpeed;
            renderer.flipX = false;
        }

        direction.y = rigid.velocity.y;
        rigid.velocity = direction;
    }
}



