using System.Collections;
using System.Collections.Generic;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using UnityEngine.UI;

/// <summary> MyMethod is a method in the MyClass class.
/// 初始化射手与敌人血量
/// </summary>
public class InitBlood : MonoBehaviour
{
    public Text enemyBlood; //敌人血量条
    public Text shootBlood; //射手血量条
    
    void Start()
    {
        enemyBlood.text = "1000";
        shootBlood.text = GetData.armyModel.MaxHp.ToString();
    }
    
}
