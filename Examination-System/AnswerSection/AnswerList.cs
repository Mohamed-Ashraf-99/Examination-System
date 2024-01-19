using System.Collections;
using Examination_System.AnswerType;
using Examination_System.QuestionType;

namespace Examination_System;

public class AnswerList : List<Answer>
{
    private List<Answer> Answers { get; set; }
    
    public AnswerList()
    {
        Answers = new List<Answer>();
    }

    public void AddAnswer(Answer answer) => Answers.Add(answer);
    
    public void AddMultipleAnswer(List<Answer> answer) => Answers.AddRange(answer);
    
}