public static class Yield{
    public static void ShowResult(){
        foreach (int evenNumber in GenerateEvenNumbers()){
            if (evenNumber > 50) {
                break;
            }

            Console.WriteLine(evenNumber);
        }
    }

    public static IEnumerable<int> GenerateEvenNumbers(){
        int number = 0;
        while (true){
            yield return number;
            number += 2;
        }
    }
}