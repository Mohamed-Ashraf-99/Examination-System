using System.Text;
using Examination_System.AnswerType;

namespace Examination_System.QuestionType;

public class ChooseOneQuestion : Question
{
    
    public ChooseOneQuestion(string body, int marks, string header,AnswerList choiceList, Answer correctAnswer) : base(body, marks, header,choiceList,correctAnswer)
    {
        ChoiceList = choiceList;
    }
    
}