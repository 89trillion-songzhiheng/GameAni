using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.UIElements;

/// <summary> MyMethod is a method in the MyClass class.
/// 移动与攻击类
/// </summary>
public class MoveAndAttack : MonoBehaviour
{
    public GameObject arrow;  //弓箭
    public GameObject enemy;  //敌人
    public Text enemyBloodText; //敌人血量
    public Animator shooter;  //射手
    
    private int attackPower = 0;   //获取射手攻击力
    private float attackTime = 0 ; //设置攻击一次的时间
    private int bloodNumber = 0;   //将敌人血量存为整型
    private float gapTime = 0;     //上次攻击到现在的时间间隔
    private Vector3 enemyPositon;  //敌人位置

    void Awake()
    {
        GetData.ReadCsv();
    }

    void Start()
    {
        enemyPositon = enemy.transform.position;
        attackTime =  GetData.armyModel.ShootSpeed;
        gapTime = attackTime;
        attackPower = GetData.armyModel.Atk;
    }
    
    void Update()
    {
        //A为攻击
        if (Input.GetKeyDown(KeyCode.A) && gapTime> attackTime)
        {
            bloodNumber =int.Parse(enemyBloodText.text);
            shooter.ResetTrigger("isMove");
            shooter.SetTrigger("isAttack");
            gapTime = 0;
        }
        else
        {
             shooter.ResetTrigger("isAttack");
             shooter.SetTrigger("isIdle");
             gapTime += Time.deltaTime;
        }
        
        //R为奔跑
        if (Input.GetKeyDown(KeyCode.R))
        {
            shooter.SetTrigger("isMove");
        }
        
        //I为闲置
        if (Input.GetKeyDown(KeyCode.I))
        {
            shooter.ResetTrigger("isMove");
            shooter.SetTrigger("isIdle");
        }
    }

    /// <summary> MyMethod is a method in the MyClass class.
    /// 弓箭触碰到敌人时触发，实现触发方法
    /// </summary>
    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("jian"))
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
    
    /// <summary> MyMethod is a method in the MyClass class.
    /// 动画回调函数,创建弓箭实例并使弓箭飞向目标
    /// </summary>
    public void Creat()
    {
        GameObject arrowPerfab = Instantiate(arrow);
        
        //根据敌人是否被消灭，调用不同方法
        if (enemy)
        {
            arrowPerfab.transform.DOMove(new Vector3(enemyPositon.x, 
                arrowPerfab.transform.position.y, enemyPositon.z), 2);
        }
        else
        {
            arrowPerfab.transform.DOMove(new Vector3(enemyPositon.x,
                arrowPerfab.transform.position.y, enemyPositon.z), 2).OnComplete(() =>
            {
                Destroy(arrowPerfab);
            }); 
        }
    }
}
