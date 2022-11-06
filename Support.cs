public class Support
{
   static public void Shuffle(List<Card> deck)
   {
      Random r = new Random();
      for(int n = deck.Count-1; n > 0; n--)
      {
         int k = r.Next(n+1);
         Card temp = deck[n];
         deck[n] = deck[k];
         deck[k] = temp;
      }
   }

}
