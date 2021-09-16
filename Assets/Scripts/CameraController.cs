using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    private Vector3 _offset;


    // Start is called before the first frame update
    private void Start()
    {
        _offset = transform.position - player.transform.position;
        
    }

    private void LateUpdate()
    {
        // var lookOnObject = player.position - transform.position;
        // lookOnObject = player.position - transform.position;
        // transform.forward = lookOnObject.normalized;
        // var playerLastPosition = player.position - lookOnObject.normalized * distanceFromObject;;
        // playerLastPosition.y = player.position.y + distanceFromObject / 2;
        // transform.position = playerLastPosition;
        transform.position = player.transform.position + _offset;
    }
}
