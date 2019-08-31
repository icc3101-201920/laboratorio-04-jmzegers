using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3_OOP_201902.Cards
{
    public class CombatCard : Card
    {
        //Atributos
        private int attackPoints;
        private bool hero;

        //Constructor
        public CombatCard(string name, string type, string effect, int attackPoints, bool hero)
        {
            Name = EnumType.name;
            (Enums)Enum.Parse(typeof(Enums), name)
            Type = EnumType.type;
            (Enums)Enum.Parse(typeof(Enums), type)
            Effect = EnumType.effect;
            (Enums)Enum.Parse(typeof(Enums), effect)
            AttackPoints = EnumType.attackPoints;
            (Enums)Enum.Parse(typeof(Enums), attackPoints)
            Hero = EnumType.hero;
            (Enums)Enum.Parse(typeof(Enums), hero)
        }

        //Propiedades
        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }
        public bool Hero
        { get
            {
                return this.hero;
            }
            set
            {
                this.hero = value;
            }
        }


    }
}
