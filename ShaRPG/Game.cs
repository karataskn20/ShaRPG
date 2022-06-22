using ShaRPG;
using ShaRPG.Characters;
using Characters.Magic;
using Characters.Melee;

class Game
{
    static void Main()
    {
        bool gameOver = false;

        Random rng = new Random();

        List<Character> characters = new List<Character>()
        {
            new Fighter(),
            new Paladin(),
            new Rogue(),
            new Wizard(),
            new Druid(),
            new Necromancer()
        };

        List<Character> meleeChars = new List<Character>();
        List<Character> casterChars = new List<Character>();

        OnTurn.AddCharsToList(characters, meleeChars, casterChars);

        PlayersInfo.Initialize(characters);

        for (int i = 0; i < 1000 ; i++)
        {
            Character activeMelee = OnTurn.SelectRandomCharacter(meleeChars, rng);
            Character activeCaster = OnTurn.SelectRandomCharacter(casterChars, rng);
            OnTurn.Turn(activeMelee, activeCaster);
            OnTurn.IsDeadCheck(activeMelee, activeCaster, casterChars);
            OnTurn.GameCheck(meleeChars, casterChars, ref gameOver);
            if (gameOver) break;
            OnTurn.StopTime();
            OnTurn.Turn(activeCaster, activeMelee);
            OnTurn.IsDeadCheck(activeCaster, activeMelee, meleeChars);
            OnTurn.GameCheck(meleeChars, casterChars, ref gameOver);
            if (gameOver) break;
            OnTurn.StopTime();
        }

        PlayersInfo.UpdateFullInfo(characters);
        PlayersInfo.Save(characters);
        PlayersInfo.PrintFullInfo();
        PlayersInfo.Reset(characters);
    }
}