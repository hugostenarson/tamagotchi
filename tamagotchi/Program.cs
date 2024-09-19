using tamagotchi;

Console.WriteLine("Welcome to Tamagotchi!");

Tamagotchi tama = new Tamagotchi();
Console.WriteLine("Please choose a name for your Tamagotchi!");
tama.Name = Console.ReadLine();

Console.WriteLine($"Great! {tama.Name} is a beautiful name!");

while (tama.GetAlive() == true)
{
  Console.Clear();
  tama.PrintStats();
  Console.WriteLine("Now what do you want to do?");
  Console.WriteLine($"1. Teach {tama.Name} a new word");
  Console.WriteLine($"2. Talk to {tama.Name}");
  Console.WriteLine($"3. Feed {tama.Name}");
  Console.WriteLine($"4. Do nothing");

  string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    tama.Teach(word);
  }
  if (doWhat == "2")
  {
    tama.Hi();
  }
  if (doWhat == "3")
  {
    tama.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  tama.Tick();
  Console.WriteLine("Press Enter to continue");
  Console.ReadLine();
}

Console.WriteLine($"OH NO! {tama.Name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();


tama.Teach("Howdy!");
tama.Teach("What's cooking good-looking?");
tama.Teach("Yo");
tama.Teach("What's the word?");
tama.Teach("Hey there!");
tama.Teach("Shut up.");
tama.Teach("Yalla!");
tama.Hi();




Console.ReadLine();