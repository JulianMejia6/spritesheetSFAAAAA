using JetBrains.Annotations;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 1f;
    }
}
