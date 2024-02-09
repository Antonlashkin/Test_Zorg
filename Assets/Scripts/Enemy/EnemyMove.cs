using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private GameObject player;
    Rigidbody2D rigidBody;

    private void Start()
    {
        player = GameManager.GetPlayer();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float hypotenuse = Mathf.Sqrt(Mathf.Pow(player.transform.position.x - transform.position.x, 2) + Mathf.Pow(player.transform.position.y - transform.position.y, 2));
        float deltaX = (player.transform.position.x - transform.position.x) / hypotenuse * speed;
        float deltaY = (player.transform.position.y - transform.position.y) / hypotenuse * speed;

        Vector3 movement = new Vector3(deltaX, deltaY, 0);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement *= Time.deltaTime;
        rigidBody.velocity = movement;
        //rigidBody.MovePosition(transform.position + movement);
    }
}
