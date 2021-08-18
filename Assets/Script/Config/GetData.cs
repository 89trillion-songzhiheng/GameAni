using System.Collections;
using System.Collections.Generic;
using script.Parse.Tools.ParseCsv;
using TableConfig;
using UnityEngine;

namespace DefaultNamespace
{
        /// <summary> MyMethod is a method in the MyClass class.
        /// 存放csv数据
        /// </summary>
       public class GetData 
        {
            public static ArmyModel armyModel; //csv字段类
            
            public static  void ReadCsv()
            {
                TableManager<ArmyModel> tableManager = new TableManager<ArmyModel>();
                List<ArmyModel> list  = tableManager.GetAllModel();
                
                //将数据存入army对象
                ArmyModel army = new ArmyModel();
                army.id = list[0].id;
                army.note = list[0].note;
                army.Name = list[0].Name;
                army.MaxHp = list[0].MaxHp;
                army.Atk = list[0].Atk;
                army.Def = list[0].Def;
                army.ShootSpeed = list[0].ShootSpeed;
                
                armyModel = army;
            }
        
        }

}
