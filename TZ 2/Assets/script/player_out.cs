using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_out : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("hero2");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);

        if (playerPos.x < -17.5f)
        {
            transform.position = new Vector3(
                -17.5f, transform.position.y, transform.position.z);
        }

        if (playerPos.x > 17.5f)
        {
            transform.position = new Vector3(
                17.5f, transform.position.y, transform.position.z);
        }

        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
        if (playerPos.y < -8.5f)
        {
            transform.position = new Vector3(
                transform.position.x, -8.5f, transform.position.z);
        }

        if (playerPos.y > 8.5f)
        {
            transform.position = new Vector3(
                transform.position.x, 8.5f, transform.position.z);
        }
    }
}

