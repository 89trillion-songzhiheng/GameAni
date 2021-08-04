using System;
using System.Collections;
using System.Collections.Generic;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using UnityEngine.UI;

/**
 * 攻击
 */
public class attack : MonoBehaviour
{
    //动画控制器
    private Animator animator;
    
    //敌人
    public GameObject go;
    //弓箭
    public GameObject go2;
    //射手
    public GameObject go3;
    
    //获取弓箭的预制件实例
    private GameObject jian;
    
    //敌人血量文本框
    public Text txt;
    //存放敌人血量
    private string s;
    //将敌人血量变为整形
    private int a;
    //获取射手攻击力
    private int ata;
    //设置攻击一次的事件
    private float mintime ;
    //上次攻击到现在的时间间隔
    private float curtime;
    // Start is called before the first frame update
    void Start()
    {
        float sd = 3;
        TableManager<ArmyModel> tableManager = new TableManager<ArmyModel>();
        List<ArmyModel> list  = tableManager.GetAllModel();
        s = txt.transform.GetComponent<Text>().text;
        a = int.Parse(s);
        mintime = 1 / list[0].ShootSpeed;
        curtime = mintime;
       ata= list[0].Atk;
      animator = go3.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        s = txt.transform.GetComponent<Text>().text;
        a = int.Parse(s);
        //A为攻击
         if (Input.GetKey(KeyCode.A) && curtime> mintime)
         {
             animator.SetBool("isattack", true);
             curtime = 0;
         }
         else
         {
             animator.SetBool("isattack", false);
             curtime += Time.deltaTime;
         }
         
        
    }
    //触发器出发集中事件
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag=="jian")
        {
            //减少敌人血量
            txt.transform.GetComponent<Text>().text = (a - ata).ToString();
            //销毁弓箭
            Destroy(collider.gameObject);
                if (a -ata <0)
                {
                    Destroy(go);
                    txt.transform.GetComponent<Text>().text = "0";
                }
        }
    }

    //动画回调函数
    public void creat()
    {
        jian = Instantiate(go2);
    }
   
}
