using System.Collections.Generic;
using TableConfig;


namespace script.Parse.Tools.ParseCsv
{
    /// <summary> MyMethod is a method in the MyClass class.
    /// csv中的字段实体类
    /// </summary>
    public class ArmyModel : BaseModel
    {
        public int Atk;
        public int Def;
        public int id;
        public int MaxHp;
        public string Name;
        public string note;
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