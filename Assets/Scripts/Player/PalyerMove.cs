using System.Drawing;
using UnityEngine;

public class PalyerMove : MonoBehaviour
{
    [SerializeField] private GameObject background;

    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] float speed = 5f;
    CharacterController _characterCantroller;
    private float halfBackgroundWidth;
    private float halfBackgroundHeight;


    void Start()
    {
        _characterCantroller = GetComponent<CharacterController>();

        halfBackgroundWidth = background.transform.localScale.x / 2 - 1;
        halfBackgroundHeight = background.transform.localScale.y / 2 - 1 ;
    }

    void Update()
    {
        float deltaX = _joystick.Horizontal * speed;
        float deltaY = _joystick.Vertical * speed;
        Vector3 movement = new Vector3(deltaX, deltaY, 0);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);

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
        _characterCantroller.Move(movement);
    }
}