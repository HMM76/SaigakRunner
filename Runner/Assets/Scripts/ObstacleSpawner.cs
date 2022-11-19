using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public float curtime = 0;
    public float maxtime;
    public float posX;
    public float posY;
    void Start()
    {
        GameObject obsclone = Instantiate(obstacle);
        obsclone.transform.position = new Vector2(posX, posY);
        Destroy(obsclone, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(curtime > maxtime)
        {
            GameObject obsclone = Instantiate(obstacle);
            obsclone.transform.position = new Vector2(posX, posY);
            Destroy(obsclone, 5);
            curtime = 0;
        }
        curtime += Time.deltaTime;
    }
}
