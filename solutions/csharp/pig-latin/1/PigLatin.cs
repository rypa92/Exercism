public static class PigLatin
{   
    public static string Translate(string input)
    {
        string[] phrase = input.Split(' ');
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        string output = "";
        int passes = phrase.Length;
        int indexOfVowel = 0;
        int indexOfQU = 0;
        
        foreach(string word in phrase) {
            if(passes != phrase.Length) {
                output += " ";
            }
            
            passes -= 1;
            
            //Rule 1
            if(word[0] == 'x' && word[1] == 'r') {
                output += word + "ay";
                continue;
            } else if(word[0] == 'y' && word[1] == 't') {
                output += word + "ay";
                continue;
            } else if(vowels.Contains(word[0])) {
                output += word + "ay";
                continue;
            }

            /*Rule 3
            if(word.Contains("qu")) {
                indexOfQU = word.IndexOf("qu");
                foreach(char letter in vowels) {
                    if(indexOfVowel < word.IndexOf(letter)) {
                        indexOfVowel = word.IndexOf(letter);
                    }
                }
                if (indexOfQU < indexOfVowel) {
                    output += word.Substring(indexOfVowel) + word.Substring(0, indexOfVowel) + "ay";
                    continue;
                } else {
                    output += word.Substring(indexOfQU + 2) + word.Substring(0, indexOfQU + 2) + "ay";
                    continue;
                }
            }*/

            indexOfVowel = word.IndexOfAny(vowels);
            
            //Rule 3
            if(word.Contains("qu")) {
                if(word.IndexOf("qu") > indexOfVowel) {
                    output += word.Substring(indexOfVowel) + word.Substring(0, indexOfVowel) + "ay";
                    continue;
                } else if(word.IndexOf("qu") < indexOfVowel) {
                    output += word.Substring(word.IndexOf("qu") + 2) +
                              word.Substring(0, word.IndexOf("qu") + 2) + "ay";
                    continue;
                }
            }
            
            //Rule 2
            if (indexOfVowel != -1) {
                output += word.Substring(indexOfVowel) + word.Substring(0, indexOfVowel) + "ay";
                continue;
            }
            
            //Rule 4
            if(word.Contains('y') && word.IndexOf('y') > 0) {
                output += word.Substring(word.IndexOf('y')) + word.Substring(0, word.IndexOf('y')) + "ay";
                continue;
            }
        }

        return output;
    }
}