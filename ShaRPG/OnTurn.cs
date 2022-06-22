using Characters.Magic;
using Characters.Melee;
using ShaRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPG
{
    public static class OnTurn
    {
        public static void AddCharsToList(List<Character> _characters, List<Character> _meleeChars, List<Character> _casterChars)
        {
            foreach (var character in _characters)
            {
                if (character.Faction == Enums.Faction.Melee)
                {
                    _meleeChars.Add(character);
                }
                else if (character.Faction == Enums.Faction.Caster)
                {
                    _casterChars.Add(character);
                }
            }
        }

        public static Character SelectRandomCharacter(List<Character> _charList, Random _rng)
        {
            Character activeChar = _charList[_rng.Next(0, _charList.Count)];
            return activeChar;
        }

        public static void StopTime()
        {
            System.Threading.Thread.Sleep(300);
        }

        public static void Turn(Character _attacker, Character _defender)
        {
            if (_attacker.HealthPoints <= 70 && _attacker.AbilityPoints > 1 && _attacker is not Necromancer)
            {
                    _attacker.SpecialAttack();
            }
            else if(_attacker.HealthPoints <= 70 && _attacker.AbilityPoints > 1 && _attacker is Necromancer)
            {
                ((Necromancer)_attacker).LifeDrain(_defender);
            }
            else if (_attacker.HealthPoints <= 40 && _attacker.AbilityPoints == 1)
            {
                _attacker.Defend();
            }
            else
            {
                _defender.TakeDamage(_attacker.Attack(), _attacker.Name, _attacker);
            }
        }

        public static void IsDeadCheck(Character _attacker, Character _defender, List<Character> _defenderList)
        {
            if (_defender.IsDead)
            {
                _attacker.KillEnemy();
                _defenderList.Remove(_defender);
            }
        }

        public static void GameCheck(List<Character> _teamOne, List<Character> _teamTwo, ref bool _gameOver)
        {
            if (_teamOne.Count == 0)
            {
                Tools.ColorfulWriteLine("\nCaster characters win!\n", ConsoleColor.Red);
                _gameOver = true;
            }
            else if (_teamTwo.Count == 0)
            {
                Tools.ColorfulWriteLine("\nMelee characters win!\n", ConsoleColor.Red);
                _gameOver = true;
            }
        }
    }
}
