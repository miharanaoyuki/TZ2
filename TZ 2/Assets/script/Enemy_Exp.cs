using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            soundManager.Play("Enemy_dame");
            Exp_bar.exp_min += 10;
            Destroy(gameObject);  

                
                
            
        }
      
    }
}