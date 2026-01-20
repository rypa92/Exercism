public class Player
{
    public int RollDie()
    {
        System.Random rand = new System.Random();
        return rand.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        System.Random rand = new System.Random();
        return rand.NextDouble()*100;
    }
}
