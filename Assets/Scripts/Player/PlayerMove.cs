using System.Drawing;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject background;

    [SerializeField] private FixedJoystick _joystick;
    private float speed;
    Rigidbody2D rigidBody;
    private float halfBackgroundWidth;
    private float halfBackgroundHeight;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        halfBackgroundWidth = background.transform.localScale.x / 2 - 1;
        halfBackgroundHeight = background.transform.localScale.y / 2 - 1 ;
    }

    void FixedUpdate()
    {
        float deltaX = _joystick.Horizontal * speed;
        float deltaY = _joystick.Vertical * speed;
        Vector3 movement = new Vector3(deltaX, deltaY, 0);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement *= Time.deltaTime;

        if (transform.position.x > halfBackgroundWidth && movement.x > 0)
        {
            movement.x = 0;
        }
        else if (transform.position.x < -halfBackgroundWidth && movement.x < 0)
        {
            movement.x = 0;
        }
        if (transform.position.y > halfBackgroundHeight && movement.y > 0)
        {
            movement.y = 0;
        }
        else if (transform.position.y < -halfBackgroundHeight && movement.y < 0)
        {
            movement.y = 0;
        }
        rigidBody.velocity = movement;
        //rigidBody.MovePosition(transform.position + movement);
    }

    public void SetSpeed(float _speed)
    {
        speed = _speed;
    }
}