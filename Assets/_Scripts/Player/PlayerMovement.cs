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
    public float speedUp = 0.5f;
    public float speedDown = 0.5f;
    public float speedMax = 20f;
    public float speedHorizontal = 3f;

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
        this.velocity.x = this.pressHorizontal * speedHorizontal;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }

    protected virtual void UpdateSpeedUp()
    {
        if (this.PressVertical <= 0) return;
        this.velocity.y += this.speedUp;
        if (this.velocity.y > this.speedMax)
        {
            this.velocity.y = this.speedMax;
        }
    }
    protected virtual void UpdateSpeedDown()
    {
        if (this.PressVertical == 0)
        {
            this.velocity.y -= this.speedDown;
            if (this.velocity.y < 0) this.velocity.y = 0;
        }
        if (transform.position.x < -7 || transform.position.x > 7)
        {
            this.velocity.y -= 1f;
            if (this.velocity.y < 3f) this.velocity.y = 3f;
        }
    }
}
