using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager Instance = null;

	//�C���X�y�N�^�[����v���C���[��R�t�����Ă����B
	[SerializeField]
	public Player player;
	void Start()
	{
		player  = GameObject.Find("hero2").GetComponent<Player>(); //"SoundManager"�Ƃ������O�Ō���

	}


	void Awake()
	{
		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy(gameObject);

		


	}


}
