﻿using Assets.Scripts.Enums;
using System.Collections.Generic;

namespace Assets.Scripts.Dictionaries
{
    public class EnemyKindLevel
    {
        static Dictionary<int, int> _standardLevel;
        static Dictionary<int, int> _lightLevel;
        static Dictionary<int, int> _chargerLevel;
        static Dictionary<int, int> _heavyLevel;


        public static Dictionary<int, int> GetStandardKindsLevel()
        {
            if (_standardLevel == null)
            {
                _standardLevel = new Dictionary<int, int>();
                int baseVal = EnemyTypeLevel.GetAllEnemiesLevels()[EnemyTypeEnum.Standard];
                int nextVal = baseVal + 3;
                _standardLevel.Add(0, baseVal);
                _standardLevel.Add(1, nextVal);
                _standardLevel.Add(2, nextVal * 2);
                _standardLevel.Add(3, nextVal * 2 + 3);
            }

            return _standardLevel;
        }

        public static Dictionary<int, int> GetLightKindsLevel()
        {
            if (_lightLevel == null)
            {
                _lightLevel = new Dictionary<int, int>();
                int baseVal = EnemyTypeLevel.GetAllEnemiesLevels()[EnemyTypeEnum.Light];
                _lightLevel.Add(0, baseVal);
                _lightLevel.Add(1, baseVal * 2);
            }

            return _lightLevel;
        }

        public static Dictionary<int, int> GetChargerKindsLevel()
        {
            if (_chargerLevel == null)
            {
                _chargerLevel = new Dictionary<int, int>();
                int baseVal = EnemyTypeLevel.GetAllEnemiesLevels()[EnemyTypeEnum.Charger];
                _chargerLevel.Add(0, baseVal);
                _chargerLevel.Add(1, baseVal + 3);

            }

            return _chargerLevel;
        }

        public static Dictionary<int, int> GetHeavyKindsLevel()
        {
            if (_heavyLevel == null)
            {
                _heavyLevel = new Dictionary<int, int>();
                int baseVal = EnemyTypeLevel.GetAllEnemiesLevels()[EnemyTypeEnum.Heavy];
                _heavyLevel.Add(0, baseVal);
                _heavyLevel.Add(1, baseVal + 5);
            }

            return _heavyLevel;
        }
    }
}
