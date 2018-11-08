using System;


namespace jualapi.Models
{
  public class Answers
  {
    public int Id { get; set; }
    public string Content { get; set; }
    public int QuestionsId { get; set; }
    public float AvgAnsVotes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public Questions Questions { get; set; }
  }
}