using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


/**
 * 人物移动
 */
public class move : MonoBehaviour
{
    public Animator shooter; //射手对象
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //R为奔跑
        if (Input.GetKeyDown(KeyCode.R))
        {
            shooter.SetTrigger("ismove");
        }
        
        //I为闲置
        if (Input.GetKeyDown(KeyCode.I))
        {
           shooter.ResetTrigger("ismove");
           shooter.ResetTrigger("isAttack");
           shooter.SetTrigger("isidle");
        }
    }
}
