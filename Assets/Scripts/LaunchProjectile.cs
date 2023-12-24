using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public float launchVelocity = 10f;
    public float delay = 1.0f;
    public bool throwBall;

    private void Start()
    {
        StartCoroutine(BallThrow());
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || throwBall)
        {
            var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
            _projectile.GetComponent<Rigidbody>().velocity = launchPoint.up * launchVelocity;
            throwBall = false;
            StartCoroutine(BallThrow());
        }
    }

    IEnumerator BallThrow()
    {
        yield return new WaitForSeconds(delay);
        throwBall = true;
    }
}