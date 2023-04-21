using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_out : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);

        if (playerPos.x < -9f)
        {
            transform.position = new Vector3(
                -9f, transform.position.y, transform.position.z);
        }

        if (playerPos.x > 9f)
        {
            transform.position = new Vector3(
                9f, transform.position.y, transform.position.z);
        }

        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
        if (playerPos.y < -4f)
        {
            transform.position = new Vector3(
                transform.position.x, -4f, transform.position.z);
        }

        if (playerPos.y > 4f)
        {
            transform.position = new Vector3(
                transform.position.x, 4f, transform.position.z);
        }
    }
}
