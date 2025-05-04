using System;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * (speed * Time.deltaTime));
    }
}
