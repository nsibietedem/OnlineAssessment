


    Console.Write("Enter the String Value: ");
    string input = (Console.ReadLine());
    CharacterCalculator(input);


static void CharacterCalculator(string str)
{
    int numberCounter=0;
    int stringCounter=0;
    char[] numericRefArray = {'0','1','2','3','4','5','6','7','8','9'};
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    char[] stringRefArray = alphabet.ToCharArray();
    char[] inputArray = str.ToCharArray();
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < stringRefArray.Length; j++)
        {
            if (inputArray[i]==stringRefArray[j])
            {
                stringCounter++;
            }
        }
    }
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < numericRefArray.Length; j++)
        {
            if (inputArray[i] == numericRefArray[j])
            {
                numberCounter++;
            }
        }
    }
    Console.WriteLine("The number of strings Characters are {0} and the numerical Chacteracters are {1}",stringCounter,numberCounter);

}

