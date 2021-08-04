using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * 人物移动
 */
public class move : MonoBehaviour
{
    
    //动画状态机
    private Animator animator;
    //射手对象
    public GameObject go;
    
    // Start is called before the first frame update
    void Start()
    {
        //获取射手的状态机
        animator = go.transform.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //R为奔跑
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("ismove", true);
        }
        
        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool("ismove", false);
        }
        //I为闲置
        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetBool("ididle", true);
        }
        
        if (Input.GetKeyUp(KeyCode.I))
        {
            animator.SetBool("ididle", false);
            
        }
        
    }

   
        
        
        
    

   
}
