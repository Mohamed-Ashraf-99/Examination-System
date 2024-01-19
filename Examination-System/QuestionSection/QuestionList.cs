namespace Examination_System.QuestionType;

public class QuestionList
{
    public List<Question> QuestionsList;
    
    public QuestionList()
    {
        QuestionsList = new List<Question>();
    }
    public void Add(Question question)
    {
        QuestionsList.Add(question);
    }
    
    public void AddMultipleQuestions(List<Question> question)
    {
        QuestionsList.AddRange(question);
    }
    
    
    // private string _filePath;
    //
    // public QuestionList(string filePath)
    // {
    //     _filePath = filePath;
    // }
    //
    // public new void Add(Question question)
    // {
    //     base.Add(question);
    //
    //     using (TextWriter writer = new StreamWriter(_filePath, true))
    //     {
    //         writer.WriteLine($"Question: {question.Body}, Marks: {question.Marks}, Header: {question.Header}");
    //     }
    //
    // }
}