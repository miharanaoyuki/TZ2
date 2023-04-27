using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager Instance = null;

	//インスペクターからプレイヤーを紐付けしておく。
	[SerializeField]
	public Player player;
	void Start()
	{
		player  = GameObject.Find("hero2").GetComponent<Player>(); //"SoundManager"という名前で検索

	}


	void Awake()
	{
		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy(gameObject);

		


	}


}
