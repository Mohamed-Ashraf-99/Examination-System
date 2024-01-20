using Examination_System.AnswerType;
using Examination_System.QuestionSection;

namespace Examination_System.QuestionType;

public class ChooseAllQuestion : Question
{
    public ChooseAllQuestion(string body, int marks, string header,AnswerList choiceList, Answer correctAnswer) : base(body, marks, header,choiceList,correctAnswer)
    {
        ChoiceList = choiceList;
    }
    
}