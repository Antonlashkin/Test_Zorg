using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject shellPrefab;
    private float timeBetwenShots;
    private GameObject _shell;
    private bool anyEnemy = true;
    private float damage;

    void Start()
    {
        StartCoroutine(Shooting());
    }

    private IEnumerator Shooting()
    {
        yield return new WaitForSeconds(timeBetwenShots);
        if (anyEnemy)
        {
            _shell = Instantiate(shellPrefab);
            _shell.transform.position = transform.TransformPoint(Vector3.up * 0.15f);
            _shell.transform.rotation = transform.rotation;
            _shell.GetComponent<PlayerShell>().SetDamage(damage);
        }
        StartCoroutine(Shooting());
        yield return null;
    }

    public void SetDamage(float _damage)
    {
        damage = _damage;
    }

    public void SetTimeBetwenShoots(float _timeBetwenShots)
    {
        timeBetwenShots = _timeBetwenShots;
    }
}
