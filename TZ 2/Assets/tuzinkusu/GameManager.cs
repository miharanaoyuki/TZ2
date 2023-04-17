using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager Instance = null;

	//インスペクターからプレイヤーを紐付けしておく。
	public Player player;



	void Awake()
	{
		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);


	}


}
