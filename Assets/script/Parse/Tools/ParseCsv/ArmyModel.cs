using System.Collections.Generic;
using TableConfig;

namespace script.Parse.Tools.ParseCsv
{
    public class ArmyModel : BaseModel
    {
            public int id;
            public string Name;
            public string note;
            public int MaxHp;
            public int Atk;
            public int Def;
            public int ShootSpeed;
            private Dictionary<string, string> parsePerValue = new Dictionary<string, string>();

            public override object Key()
            {
                return  id;
            }
        
        

            public Dictionary<string, string> ParsePerValue
            {
                get { return parsePerValue; }
                set { parsePerValue = value; }
            }
        
    }
}