using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleOffset : MonoBehaviour
{
    public float offsetscale;
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - offsetscale, gameObject.transform.position.y);
    }
}
