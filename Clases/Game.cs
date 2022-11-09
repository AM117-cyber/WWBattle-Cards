using System.Collections.Generic;

namespace GameItems;
public class Game //Asumir que la informacion me va a entrar po alguna via, tu solo vas a trabajar con ella.Olvidate de por donde entre.
{

    public static List<Player> Players;
    public static void SetGamePlayers(List<Player> Players,string name1, string name2)
    {
        
        /*switch (name)
        {
            case "Seamus-Virtual":
            VirtualPlayerSeamus P2 = new VirtualPlayerSeamus(name);
            break;

            case "Dean-Virtual":
             VirtualPlayerDean P2 = new VirtualPlayerDean(name);
            break;

            default:
            Player P1 = new Player(name);
            break;
        }*/
    }

    

    /*
    public int AmountOfPlayers;//= Int32.Parse(Console.ReadLine());  You need amount of players to initialize a game.
    public List<string> PlayersNames;
    
    public Game(int amountOfPlayers)
    {
        if (amountOfPlayers < 1)
        {
            throw new ArgumentException("Amount of players for dueling must be of at least 1.");//change message
        }
        
        this.AmountOfPlayers = amountOfPlayers;
        this.PlayersNames = GetNames(PlayersNames);
    }

    public static IEnumerable<Player> players = ;
    

    public static IEnumerable<Document> ProcessFolder(string[] path)
    {
        foreach (var indivpath in path)
        {
            string text = File.ReadAllText(indivpath);
            string pattern = @"\w+";
            var Docs = new Document(indivpath, ProcessText(text, pattern));
            yield return Docs;
        }
    }

    public static List<string> GetNames(List<string> names)
    {
        string name = Console.ReadLine();
        while (name != "")// mientras que no se le de al boton done;
        {
            names.Add(name);
            name = Console.ReadLine();
        }

        return names;
    }


    static void GenerateDiceResults(int[] diceResults)
    {
        int[] answer = new int[diceResults.Length];
        for (int i = 0; i < diceResults.Length; i++)
        {

            /*string player = "Player " + (i + 1);
            System.Console.WriteLine(player + ", Please press enter to throw the dice.");
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;
            System.Console.WriteLine(sum);
            (bool boolean, int pos) unique = IsUnique(sum, diceResults,i);
            if (!unique.boolean)
            {   
                System.Console.WriteLine("Another player already threw that number. All players will proceed to throw the dice again.");
                i = -1;
                continue;
            }

            diceResults[i] = sum;
            answer[unique.pos] = i+1;
        }

        System.Console.WriteLine("All players have thrown the dice.Turns are:");
        for (int i = 0; i < diceResults.Length; i++)
        {
            System.Console.WriteLine($"Player {i + 1}: {GetTurn(i, diceResults)} turno");
        }

    }

    static (bool boolean, int pos) IsUnique(int sum, int[] diceResults, int player)
    {
        int pos = 1;
        int a = player - 1;
        for (int i = a; i >= 0; i--)
        {
            if (diceResults[i] == sum)
            {
                return (false, pos);
            }
        }
        return (true, pos);
    }

    static int GetTurn(int player, int[] diceResults)
    {
        int count = diceResults.Length - player;
        for (int i = player + 1; i < diceResults.Length; i++)
        {
            if (diceResults[player] < diceResults[i])
            {
                count--;
            }
        }
        return count;
    }
    
   static void OrdenarPorMezcla(int[] a)
   {
     Ordenar(a,0,a.Length-1);
   }
   static void Ordenar(int[] a, int firstPos, int lastPos)
   {
       if (firstPos < lastPos)
       {
           int middle = (lastPos + firstPos)/2;
           Ordenar(a, firstPos, middle);
           Ordenar(a, middle+1, lastPos);
           Mezclar(a,firstPos, middle, lastPos);
       }
   }
   static void Mezclar(int[] a, int firstPos, int middle, int lastPos)
   {
       int startOf1 = firstPos;
       int startOf2 = middle + 1;
       int currentPos = 0;
       int[] arr = new int[lastPos-firstPos+1];
       while (startOf1 <= middle && startOf2 <= lastPos)
       {
           if(a[startOf1] < a[startOf2])
           { 
               arr[currentPos++] = a[startOf1++];
           } else{ 
               arr[currentPos++] = a[startOf2++];
               }
       }
   if (startOf1 <= middle)
   {
        Array.Copy(a,startOf1,arr,currentPos,middle-startOf1+1);
   }
   if (startOf2 <= lastPos)
   {
       Array.Copy(a,startOf2,arr,currentPos,lastPos-startOf2+1);
   }
   Array.Copy(arr, 0, a,firstPos,arr.Length);

   }*/

}
