using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraman : MonoBehaviour
{
    Vector3 startPosition;

    [SerializeField]
    GameObject player;

    private void Start()
    {

        startPosition = gameObject.transform.position;

    }

    private void FixedUpdate()
    {

        gameObject.transform.position = player.transform.position + startPosition;

    }
}
