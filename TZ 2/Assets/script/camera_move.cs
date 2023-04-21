using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
	GameObject camera;
	GameObject player;
	// Start is called before the first frame update
	void Start()
	{
		this.camera = GameObject.Find("Main Camera");
		this.player = GameObject.Find("hero2");
	}

	// Update is called once per frame
	void Update()
    {
		float x_speed = 0f;
		float xspeed = 0f;
		float y_speed = 0f;
		float yspeed = 0f;
		x_speed = PlayerMove.m_speed;
		xspeed = PlayerMove.m_speed;
		y_speed = PlayerMove.m_speed;
		yspeed = PlayerMove.m_speed;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-x_speed, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(xspeed, 0, 0);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(0, yspeed, 0);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(0, -y_speed, 0);
		}
	
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);

        if (playerPos.x < -7f)
        {
			x_speed = 0f;
        }
		if (playerPos.x > -5f)
		{
			x_speed = PlayerMove.m_speed;
		}

		if (playerPos.x > 7f)
        {
			xspeed = 0f;
		}
		if (playerPos.x < 5f)
		{
			x_speed = PlayerMove.m_speed;
		}

		transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
        if (playerPos.y < -2f)
        {
			yspeed = 0f;
		}

        if (playerPos.y > 2f)
        {
			y_speed = 0f;
		}
    }
}
