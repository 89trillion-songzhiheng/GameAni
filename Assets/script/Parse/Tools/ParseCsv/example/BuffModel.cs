using System;
using System.Collections.Generic;
using TableConfig;

namespace Model
{
    [Serializable]
    public class BuffModel : BaseModel
    {
        public int id;
        public int skillId;
        public int BuffTarget;
        public int Race;
        public int[] AttackType;
        public int[] BuffTargetArmy;
        public int BuffEffectType;
        public float BuffEffectValueUp;
        public float BuffEffectValueDe;
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