using System;


namespace jualapi.Models
{
  public class Answers
  {
    public int Id { get; set; }
    public string Content { get; set; }
    public int QuestionsId { get; set; }
    public int Votes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public Questions Questions { get; set; }
  }
}