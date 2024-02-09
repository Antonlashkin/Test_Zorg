using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject shellPrefab;
    private GameObject _shell;
    private bool anyEnemy = true;

    void Start()
    {
        StartCoroutine(Shooting());
    }

    private IEnumerator Shooting()
    {
        yield return new WaitForSeconds(1f);
        if (anyEnemy)
        {
            _shell = Instantiate(shellPrefab);
            _shell.transform.position = transform.TransformPoint(Vector3.up * 0.15f);
            _shell.transform.rotation = transform.rotation;
        }
        StartCoroutine(Shooting());
        yield return null;
    }
}
