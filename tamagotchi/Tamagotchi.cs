using System;

namespace tamagotchi;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words;
    private bool isAlive;
    public string Name;
    public void Feed()
    {
        while (hunger < 10 || boredom < 10)
        {
            hunger--;
        }
    }
    public void Hi()
    {
        int i = Random.Shared.Next(7);
        Console.WriteLine(words[i]);

        reduceBoredom();
    }
    public void Teach(string word)
    {
        Console.WriteLine($" [{Name}] learns: {word}");
        words.Add(word);
        reduceBoredom();
    }
    public void Tick()
    {
        //dör om man inte matar eller leker med den
        hunger -= 1;
        boredom -= 1;

        if (isAlive == false)
        {
            Console.Clear();
            Console.WriteLine("dog");
        }
    }
    public void PrintStats()
    {
        if (hunger > 10 && boredom >10 )
        {
            Console.WriteLine($"Din Tamagotchi har {hunger}");
            Console.WriteLine($"Din Tamagotchi är {boredom}");
        }
        // else
        // {
        //     Console.Clear();
        //     Console.WriteLine("Din Tamagotchi har dött");
        // }
    }
    public bool GetAlive()
    {
        return true;
    }
    private void reduceBoredom()
    {
        boredom--;
    }
}
