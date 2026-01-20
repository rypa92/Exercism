public static class ScrabbleScore
{
    private static char[] tens = { 'q', 'z'};
    private static char[] eights = { 'j', 'x' };
    private static char[] fives = { 'k' };
    private static char[] fours = { 'f', 'h', 'v', 'w', 'y' };
    private static char[] threes = { 'b', 'c', 'm', 'p' };
    private static char[] twos = { 'd', 'g' };
    private static char[] ones = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
    public static int Score(string input)
    {
        int score = 0;
        input = input.ToLower();
        for(int x = 0; x < input.Length; x++)
        {
            foreach(char letter in tens) {
                if(input[x].Equals(letter)) {
                    score += 10;
                }
            }
            foreach(char letter in eights) {
                if(input[x].Equals(letter)) {
                    score += 8;
                }
            }
            foreach(char letter in fives) {
                if(input[x].Equals(letter)) {
                    score += 5;
                }
            }
            foreach(char letter in fours) {
                if(input[x].Equals(letter)) {
                    score += 4;
                }
            }
            foreach(char letter in threes) {
                if(input[x].Equals(letter)) {
                    score += 3;
                }
            }
            foreach(char letter in twos) {
                if(input[x].Equals(letter)) {
                    score += 2;
                }
            }
            foreach(char letter in ones) {
                if(input[x].Equals(letter)) {
                    score += 1;
                }
            }
        }
        return score;
    }
}