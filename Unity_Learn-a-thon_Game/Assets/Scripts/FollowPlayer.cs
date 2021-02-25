using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // this is using the unity Transform component as the data type
    public Vector3 offset;           // this datatpye store 3 floats
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
