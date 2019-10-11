using Laboratorio_6_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_6_OOP_201902
{
    interface IAttackPoints
    {
        public int[] GetAttackPoints(EnumType line = EnumType.None) { }
    }
}
