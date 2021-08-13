# GameAni

**整体大纲**
1.设计我方弓箭手与敌方弓箭手
2.设计弓箭飞行特效
3.设计人物移动脚本，伤害计算脚本

**目录结构**
├── Health.  //血量设置
│   ├── InitBlood.cs  //初始化血量
│   └── InitBlood.cs.meta
├── Health.meta
├── Parse //解析工具类
│   ├── ArmyModel.cs  //json文档实体类
│   ├── ArmyModel.cs.meta
│   ├── Tools
│   │   ├── ParseCsv
│   │   │   ├── TableRead
│   │   │   │   ├── TableManager.cs
│   │   │   │   ├── TableManager.cs.meta
│   │   │   │   ├── TableParser.cs
│   │   │   │   ├── TableParser.cs.meta
│   │   │   │   ├── TableRead.asmdef
│   │   │   │   └── TableRead.asmdef.meta
│   │   │   ├── TableRead.meta
│   │   │   ├── example
│   │   │   │   ├── BuffModel.cs
│   │   │   │   ├── BuffModel.cs.meta
│   │   │   │   ├── GameModelManager.cs
│   │   │   │   └── GameModelManager.cs.meta
│   │   │   └── example.meta
│   │   └── ParseCsv.meta
│   └── Tools.meta
├── Parse.meta
├── ShooterState //弓箭手状态
│   ├── Attack.cs //攻击
│   ├── Attack.cs.meta
│   ├── move.cs //移动与闲置
│   └── move.cs.meta
└── ShooterState.meta


**界面结构**
 Hierarchy：
    1.Enemy  //敌人
    2.Shooter //弓箭手
    3.Canvas //展示血量的画布
      1）ShooterBlood //射手血量
      2）EnemyBlood //敌人血量

   
**流程图**
![image](https://github.com/89trillion-songzhiheng/GameAni/blob/master/picture/GameAni.png)
