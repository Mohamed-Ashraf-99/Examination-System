using Examination_System.AnswerType;

namespace Examination_System.QuestionSection;

public  abstract class Question
{
    public string Body { get; set; }
    public int Marks { get; set; }
    public string Header { get; set; }
    public AnswerList ChoiceList { get; set; }
    public Answer CorrectAnswer { get; set; }
    
    public Question(string body, int marks, string header, AnswerList choiceList, Answer correctAnswer)
    {
        Body = body;
        Marks = marks;
        Header = header;
        ChoiceList = choiceList;
        CorrectAnswer = correctAnswer;
    }
    

    public virtual void DisplayQuestion()
    {
        Console.WriteLine($"\n{Body} Marks: ({Marks})\n");
        foreach (var choice in ChoiceList)
        {
            Console.WriteLine(choice.Title);
        }
    }
    
}