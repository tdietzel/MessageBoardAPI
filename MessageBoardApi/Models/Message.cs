namespace MessageBoardApi.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public string MessageAuthor { get; set; }
    public string MessageTitle { get; set; }
    public string MessageBody { get; set; }
  }
}