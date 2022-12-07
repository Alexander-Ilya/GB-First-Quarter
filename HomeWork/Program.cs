string[] array = { "hello", "2", "world", ":-)" };
string[] finalArray = new string[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Array.Resize(ref finalArray, finalArray.Length + 1);
        finalArray[finalArray.Length - 1] = array[i];
        System.Console.WriteLine(finalArray[finalArray.Length - 1]);
    }

}
