using System;
using System.Collections;
using System.Collections.Generic;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/**
  攻击
 */
public class Attack : MonoBehaviour
{
    public GameObject enemy; //敌人
    public GameObject arrow;  //弓箭
    public Animator shooter; //射手
    public Text enemyBloodText; //敌人血量文本框
    
    private GameObject arrowPerfab; //弓箭的预制件实例
    
    private float attackTime ; //设置攻击一次的时间
    private float gapTime; //上次攻击到现在的时间间隔

    private int bloodNumber; //将敌人血量存为整型
    private int attackPower; //获取射手攻击力
    
    // Start is called before the first frame update
    void Start()
    {
        TableManager<ArmyModel> tableManager = new TableManager<ArmyModel>();
        List<ArmyModel> list  = tableManager.GetAllModel();
        
        
        attackTime = 1f/list[0].ShootSpeed;
        gapTime = attackTime;

        attackPower = list[0].Atk;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && gapTime> attackTime)
        {
             bloodNumber =int.Parse(enemyBloodText.text);
             shooter.ResetTrigger("ismove");
             shooter.SetTrigger("isAttack");
             gapTime = 0;
        }
        else
        {
             shooter.ResetTrigger("isattack");
             shooter.SetTrigger("isidle");
             gapTime += Time.deltaTime;
        }

        if (arrowPerfab != null)
        {
            arrowPerfab.transform.position =Vector3.MoveTowards(arrowPerfab.transform.position,
                 new Vector3(0.4f,0.2f,arrowPerfab.transform.position.z+2),1);
        }
    }

    //触发器出发集中事件
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag=="jian")
        {
            
            //减少敌人血量
            enemyBloodText.text = (bloodNumber - attackPower).ToString();
            
            //销毁弓箭
            Destroy(collider.gameObject);
            
            if (bloodNumber -attackPower <0)
            { 
                Destroy(enemy);
                enemyBloodText.text = "0";
            }
        }
    }
    
    //动画回调函数,创建弓箭实例
    public void creat()
    {
        arrowPerfab = Instantiate(arrow);
    }
   
}
