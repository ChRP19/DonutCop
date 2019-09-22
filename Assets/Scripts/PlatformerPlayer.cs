using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayer : MonoBehaviour
{
    public float forwardForce = 0f;
    public float jumpForce = 12.0f;
    bool doubleJump = false;

    private Rigidbody2D _body;
    private CircleCollider2D _circle;
 
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
        _circle = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
  
        Vector3 max = _circle.bounds.max;
        Vector3 min = _circle.bounds.min;
        Vector2 corner1 = new Vector2(max.x, min.y - .1f);
        Vector2 corner2 = new Vector2(min.x, min.y - .2f);
        Collider2D hit = Physics2D.OverlapArea(corner1, corner2);

        bool grounded = false;
        if (hit != null)
        {
            grounded = true;
        }

        if (grounded)
            doubleJump = false;

        if (transform.position.x < -4)
        {
            forwardForce = 1f;
            _body.velocity = new Vector2(forwardForce, 0);
        }
        

        if ((grounded || !doubleJump) && (Input.GetKeyDown(KeyCode.Space)))
        {
            _body.velocity = new Vector2(_body.velocity.x, 0);

            _body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            if (!grounded)
                doubleJump = true;

            
        }
    }
}
