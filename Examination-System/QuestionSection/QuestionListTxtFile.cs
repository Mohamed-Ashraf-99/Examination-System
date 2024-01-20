using Examination_System.QuestionType;

namespace Examination_System.QuestionSection;

public class QuestionListTxtFile : List<Question>
{
    private string _filePath;
    
    public QuestionListTxtFile(string filePath)
    {
        _filePath = filePath;
    }
    
    public new void Add(Question question)
    {
        base.Add(question);
    
        using (TextWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine($"Question: {question.Body}, Marks: {question.Marks}, Header: {question.Header}");
        }
    
    }
}