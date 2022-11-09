public class Support
{
   static public void Shuffle(List<Card> deck)//Should this method go into Game class?
   {
      Random r = new Random();
      for(int n = deck.Count-1; n > 0; n--)
      {
         int k = r.Next(n+1);
         Card temp = deck[n];//declare with Card.ID
         deck[n] = deck[k];
         deck[k] = temp;
      }
   }

}
