using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : Player
{

    [SerializeField]float curSpeed, verticalSpeed;

    void Start()
    {
        StartCoroutine(IncreaseVerticalSpeed());
    }

    void Update()
    {
        MoveForeward();
        if((Keyboard.current.upArrowKey.isPressed) || (Keyboard.current.wKey.isPressed))
        {
            MoveUp();
        }
        else
        {
            MoveDown();
        }
    }

    private void MoveForeward()
    {
        rb.velocity = new Vector2(curSpeed, rb.velocity.y);
    }

    private void MoveUp()
    {
        rb.velocity = new Vector2(rb.velocity.x, verticalSpeed);
    }

    private void MoveDown()
    {
        rb.velocity = new Vector2(rb.velocity.x, -verticalSpeed);

    }

    public void SetStartSpeed(float speed)
    {
        curSpeed = speed;
    }

    private IEnumerator IncreaseVerticalSpeed()
    {
        while(true)
        {
            yield return new WaitForSeconds(15);
            verticalSpeed *= 1.1f;
            print("speed is increased");
        }
    }
}
