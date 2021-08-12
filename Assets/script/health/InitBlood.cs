using System.Collections;
using System.Collections.Generic;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using UnityEngine.UI;


/**
  初始化射手与敌人血量
 */
public class InitBlood : MonoBehaviour
{
    public Text enemyBlood; //敌人血量条
    
    public Text shootBlood; //射手血量条
    
    // Start is called before the first frame update
    void Start()
    {
        TableManager<ArmyModel> tableManager = new TableManager<ArmyModel>();
        List<ArmyModel> list = tableManager.GetAllModel();
        
        enemyBlood.text = "1000";
        shootBlood.text = list[0].MaxHp.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
