using Enums;

namespace ShaRPG
{
    public static class Constants
    {
        public static class Fighter
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 130;
            public const int ABILITY_POINTS = 2;
            public const string NAME = "Fighter"; //"Rossea";
            public const Faction FACTION = Faction.Melee;
        }

        public static class Paladin
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 150;
            public const int ABILITY_POINTS = 2;
            public const string NAME = "Paladin"; //""Gavinus";
            public const Faction FACTION = Faction.Melee;
        }

        public static class Rogue
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 80;
            public const int ABILITY_POINTS = 2;
            public const string NAME = "Rogue"; //"Darkmoon";
            public const Faction FACTION = Faction.Melee;
        }

        public static class Wizard
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 70;
            public const int MANA_POINTS = 2;
            public const string NAME = "Wizard"; //"Ishwan";
            public const Faction FACTION = Faction.Caster;
        }

        public static class Druid
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 90;
            public const int MANA_POINTS = 2;
            public const string NAME = "Druid"; //"Pernelis";
            public const Faction FACTION = Faction.Caster;
        }

        public static class Necromancer
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 80;
            public const int MANA_POINTS = 2;
            public const string NAME = "Necromancer"; //"Shevras";
            public const Faction FACTION = Faction.Caster;
        }
    }
}
