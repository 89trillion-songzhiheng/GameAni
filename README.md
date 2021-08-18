# GameAni

**整体大纲**
1.设计我方弓箭手与敌方弓箭手  
2.设计弓箭飞行特效  
3.设计人物移动脚本，伤害计算脚本  

**目录结构**  
```
├── Config
│   ├── GetData.cs //获取解析数据
│   └── GetData.cs.meta
├── Config.meta
├── Controller
│   ├── InitBlood.cs //初始化血量
│   ├── InitBlood.cs.meta
│   ├── MoveAndAttack.cs //人物攻击与移动
│   └── MoveAndAttack.cs.meta
├── Controller.meta
├── Data
│   ├── ArmyModel.cs 存放数据
│   └── ArmyModel.cs.meta
└── Data.meta
```

**界面结构**  
 Hierarchy  
    1.Enemy  //敌人  
    2.Shooter //弓箭手  
    3.Canvas //展示血量的画布  
      1）ShooterBlood //射手血量  
      2）EnemyBlood //敌人血量  

   
**流程图**  
![image](https://github.com/89trillion-songzhiheng/GameAni/blob/master/Picture/AniPicture.png)
