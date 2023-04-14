using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Experience : MonoBehaviour
{
	// Start is called before the first frame update
	public static int Exp = 0;
	public static int LV = 1;
	public static bool MAX = false;
	float box = 0;
	public GameObject main2;
	public GameObject main3;
	GameObject ExpText;
	GameObject LVText;
	//���x���A�b�v�̃G�t�F�N�g
	public GameObject breakEffect;
	public GameObject player;
	[SerializeField]
	private SoundManager soundManager;

	public void AddScore()
	{
		if(MAX == false)
        {
			Exp_bar.exp_min += 10;
		}
	}

	public void bossScore()
	{
		if (MAX == false)
		{
			Exp_bar.exp_min += 50;
		}
	}
	public void bossScore2()
	{
		if (MAX == false)
		{
			Exp_bar.exp_min += 100;
		}
	}
	public void bossScore3()
	{
		if (MAX == false)
		{
			Exp_bar.exp_min += 200;
		}
	}

	public void bossScore4()
	{
		if (MAX == false)
		{
			Exp_bar.exp_min += 300;
		}
	}


	public void LVUP()
    {
		if (MAX == false)
		{
			if (LV > 6)
			{
				box = Exp_bar.exp_max;
				Exp_bar.exp_max *= 1.10f;
			}
			if (LV > 4 && LV <= 6)
			{
				box = Exp_bar.exp_max;
				Exp_bar.exp_max *= 1.20f;
			}
			else if (LV <= 4)
			{
				box = Exp_bar.exp_max;
				Exp_bar.exp_max *= 1.50f;
			}
			LV += 1;
		}
    }

	void Start()
	{
		this.ExpText = GameObject.Find("Exp");
		this.LVText = GameObject.Find("Lv");
	}

	void Update()
	{
		if (MAX == false)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				Exp_bar.exp_min += 10;
			}
			ExpText.GetComponent<Text>().text = "Exp:" + Exp.ToString("D4");
			LVText.GetComponent<Text>().text = "Lv:" + LV.ToString("D4");
			if (Exp_bar.exp_min >= Exp_bar.exp_max)
			{
				GameObject.Find("Canvas").GetComponent<Experience>().LVUP();
				HP.maxHp += 1;


				HP.MAX += 1;

				//�G�t�F�N�g�𔭐�������
				GenerateEffect();


				HP.life = HP.maxHp;

				//if (main.att_time > 0.2)
				//{
				//	main.att_time -= 0.05f;
				//}

				//if(LV > 7)
    //            {
				//	main2.SetActive(true);
    //            }
				//if (LV > 12)
				//{
				//	main3.SetActive(true);
				//}

				soundManager.Play("Lvup");
				Exp_bar.exp_min -= box;

				if (LV >= 20)
				{
					MAX = true;
				}
			}
		}
        else
        {
			LVText.GetComponent<Text>().text = "Lv:MAX";
		}
	}

	//�G�t�F�N�g�𐶐�����
	void GenerateEffect()
	{
		if (MAX == false)
		{
			//�G�t�F�N�g�𐶐�����
			GameObject effect = Instantiate(breakEffect) as GameObject;
			//�G�t�F�N�g����������ꏊ�����肷��(�G�I�u�W�F�N�g�̏ꏊ)
			effect.transform.position = player.transform.position;
		}
	}
}