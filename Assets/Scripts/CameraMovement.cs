using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject player;

    private float halfBackgroundWidth;
    private float halfBackgroundHeight;

    private float cameraHalfWidthSize;
    private float cameraHalfHeightSize;


    void Start()
    {
        halfBackgroundWidth = background.transform.localScale.x / 2 - 1;
        halfBackgroundHeight = background.transform.localScale.y / 2 - 1;

        cameraHalfWidthSize = Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.pixelWidth, 0)).x;
        cameraHalfHeightSize = Camera.main.ScreenToWorldPoint(new Vector2(0, Camera.main.pixelHeight)).y;
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);   
        if (player.transform.position.x + cameraHalfWidthSize > halfBackgroundWidth)
        {
            transform.position = new Vector3(halfBackgroundWidth - cameraHalfWidthSize, transform.position.y, transform.position.z);
        }
        else if (player.transform.position.x - cameraHalfWidthSize < -halfBackgroundWidth)
        {
            transform.position = new Vector3(-halfBackgroundWidth + cameraHalfWidthSize, transform.position.y, transform.position.z);
        }

        if (player.transform.position.y + cameraHalfHeightSize > halfBackgroundHeight)
        {
            transform.position = new Vector3(transform.position.x, halfBackgroundHeight - cameraHalfHeightSize, transform.position.z);
        }
        else if (player.transform.position.y - cameraHalfHeightSize < -halfBackgroundHeight)
        {
            transform.position = new Vector3(transform.position.x, -halfBackgroundHeight + cameraHalfHeightSize, transform.position.z);
        }
    }
}
