using System.Collections;
using System.Collections.Generic;
using Model;
using NUnit.Framework;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;
using Object = System.Object;

/**
 * 测试解析csv文件
 */
public class ParseCsv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        TableManager<ArmyModel> tableManager =  new TableManager<ArmyModel>();
        List<ArmyModel> list  = tableManager.GetAllModel();

        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].id);
            Debug.Log(list[i].Name);
            Debug.Log(list[i].note);
            Debug.Log(list[i].MaxHp);
            Debug.Log(list[i].Atk);
            Debug.Log(list[i].Def);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
