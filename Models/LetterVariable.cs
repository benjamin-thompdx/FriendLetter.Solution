namespace FriendLetter.Models
{
  public class LetterVariable
  {
    //Our model is very simple. We can get and set a Recipient and a Sender. That's all we need to explore using Razor to dynamically render our views.
    public string Recipient { get; set; }

    public string Sender { get; set; }
  }
}