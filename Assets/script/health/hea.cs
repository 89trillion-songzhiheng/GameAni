using System.Collections;
using System.Collections.Generic;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using UnityEngine.UI;


/**
 * 初始化射手与敌人血量
 */
public class hea : MonoBehaviour
{

    
    //敌人血量条
    public Text emyhp;
    
    //射手血量条
    public Text myhp;
    // Start is called before the first frame update
    void Start()
    {
        
        TableManager<ArmyModel> tableManager = new TableManager<ArmyModel>();
        List<ArmyModel> list = tableManager.GetAllModel();
        emyhp.transform.GetComponent<Text>().text = "1000";
        string s = list[0].MaxHp.ToString();
        myhp.transform.GetComponent<Text>().text = s;
        

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
