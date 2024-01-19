using Examination_System.AnswerType;

namespace Examination_System.QuestionType;

public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string body, int marks, string header, AnswerList choiceList, Answer correctAnswer) : base(body, marks, header, choiceList, correctAnswer)
    {
        ChoiceList = choiceList;
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"\n{Body} Marks: ({Marks})\n");
        foreach (var choice in ChoiceList)
        {
            Console.WriteLine(choice.Title);
        }
    }
    
}