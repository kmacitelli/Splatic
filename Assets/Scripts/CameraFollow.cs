using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //get player pos
    GameObject player;
    GameObject camera;
    Vector2 playerPos;
    //set camera pos to player pos
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        camera.transform.position = new Vector3(playerPos.x, playerPos.y, camera.transform.position.z);
    }
}
