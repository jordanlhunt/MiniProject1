internal class Program
{
    // Seed the random number generator
    static Random randomNumberGenerator = new Random(Guid.NewGuid().GetHashCode());
    static int diceRollSumTotal = 0;
    static List<string> listOfRollValues = new List<string>();
    private static void Main(string[] args)
    {
        #region  Instance Variables
        bool isDiceRollComplete = false;
        #endregion
        #region Menu
        Console.WriteLine("Austin Commmunity College Computer Science Club MiniProject1 - TTRPG Digital Dice Roller");
        int diceSelection = PrintDiceRollMenu();
        RollDice(diceSelection);
        while (isDiceRollComplete != true)
        {
            Console.Write("Would you like to add another dice roll (Y/N)?: ");
            string contiuneRollingDice = Console.ReadLine();
            if (contiuneRollingDice == "N")
            {
                isDiceRollComplete = true;
            }
            else if (contiuneRollingDice == "Y")
            {
                diceSelection = PrintDiceRollMenu();
                RollDice(diceSelection);
            }
            else
            {
                Console.WriteLine("Input Error. Try again");
            }
        }
        #endregion
        PrintDamageTotal(listOfRollValues, diceRollSumTotal);
    }
    private static void RollDice(int dieToRoll)
    {
        switch (dieToRoll)
        {
            case 1:
                int d4Value = RollD4();
                diceRollSumTotal += d4Value;
                listOfRollValues.Add("D4 roll: " + d4Value.ToString());
                break;
            case 2:
                int d6Value = RollD6();
                diceRollSumTotal += d6Value;
                listOfRollValues.Add("D6 roll: " + d6Value.ToString());
                break;
            case 3:
                int d8Value = RollD8();
                diceRollSumTotal += d8Value;
                listOfRollValues.Add("D8 roll: " + d8Value.ToString());
                break;
            case 4:
                int d10Value = RollD10();
                diceRollSumTotal += d10Value;
                listOfRollValues.Add("D10 roll: " + d10Value.ToString());
                break;
            case 5:
                int d12Value = RollD12();
                diceRollSumTotal += d12Value;
                listOfRollValues.Add("D12 roll: " + d12Value.ToString());
                break;
            case 6:
                int d20Value = RollD20();
                diceRollSumTotal += d20Value;
                listOfRollValues.Add("D20 roll: " + d20Value.ToString());
                break;
            case 7:
                int d100Value = RollD100();
                diceRollSumTotal += d100Value;
                listOfRollValues.Add("D100 roll: " + d100Value.ToString());
                break;
        }
    }
    private static int PrintDiceRollMenu()
    {
        Console.WriteLine("What type of dice would you like to roll?");
        Console.WriteLine("\t 1.) D4\n\t 2.) D6\n\t 3.) D8\n\t 4.) D10\n\t 5.) D12\n\t 6.) D20\n\t 7.) D100");
        int diceSelection = int.Parse(Console.ReadLine());
        return diceSelection;
    }
    private static void PrintDamageTotal(List<string> listOfRollValues, int diceRollSumTotal)
    {
        foreach (string roll in listOfRollValues)
        {
            Console.WriteLine(roll);
        }
        Console.WriteLine("Your total damage is " + diceRollSumTotal);
    }
    private static int RollD100()
    {
        return randomNumberGenerator.Next(1, 101);
    }
    private static int RollD20()
    {
        return randomNumberGenerator.Next(1, 21);
    }
    private static int RollD12()
    {
        return randomNumberGenerator.Next(1, 13);
    }
    private static int RollD10()
    {
        return randomNumberGenerator.Next(1, 11);
    }
    private static int RollD8()
    {
        return randomNumberGenerator.Next(1, 9);
    }
    private static int RollD6()
    {
        return randomNumberGenerator.Next(1, 7);
    }
    private static int RollD4()
    {
        return randomNumberGenerator.Next(1, 5);
    }
}