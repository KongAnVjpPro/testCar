using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb2d;

    public Vector2 velocity = new Vector2(0, 1f);
    public float pressHorizontal = 0f;
    public float PressVertical = 0f;
    private void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }

    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.PressVertical = Input.GetAxis("Vertical");
    }

    protected virtual void UpdateSpeed()
    {
        this.velocity.x = this.pressHorizontal;
        this.velocity.y = this.PressVertical;
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }
}
