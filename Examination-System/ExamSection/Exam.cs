using Examination_System.QuestionType;

namespace Examination_System.ExamType;

public abstract class Exam
{
    protected TimeSpan Time { get; private set; }
    protected int NumberOfQuestions { get; private set; }
    protected SubjectType Subject { get; private set; }
    // public ExamMode Mode { get; private set; }
    // public QuestionList QuestionsList { get; private set; }

    public Exam(TimeSpan time, int numberOfQuestions, SubjectType subject)
    {
        Time = time;
        NumberOfQuestions = numberOfQuestions;
        Subject = subject;
    }
    
    public abstract void ShowExam(QuestionList questionsList);
    
}