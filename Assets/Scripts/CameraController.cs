using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player (3)");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(player.transform.position.x, 0, -10);



    }
}
