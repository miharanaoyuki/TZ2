using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager Instance = null;

	//�C���X�y�N�^�[����v���C���[��R�t�����Ă����B
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
