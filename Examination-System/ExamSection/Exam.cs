using Examination_System.ExamType;
using Examination_System.QuestionSection;
using Examination_System.QuestionType;

namespace Examination_System.ExamSection;

public abstract class Exam
{
    protected TimeSpan Time { get; private set; }
    protected int NumberOfQuestions { get; private set; }
    protected SubjectType Subject { get; private set; }
    protected int StudentGrade;
    // public ExamMode Mode { get; private set; }
    
    public Exam(TimeSpan time, int numberOfQuestions, SubjectType subject)
    {
        Time = time;
        NumberOfQuestions = numberOfQuestions;
        Subject = subject;
        StudentGrade = 0;
    }
    
    public abstract void ShowExam(QuestionListTxtFile questionsList);

    protected abstract void DisplayHeader();

    protected abstract void ProcessQuestions(QuestionListTxtFile questionsList);
    
    protected  int CheckIfAnswerIsCorrect(string? studentAnswer, string correctAnswer, int grade)
    {
        if (studentAnswer == correctAnswer)
        {
            grade += 10; 
        }
        return grade;
    }
    
    protected  void ShowStudentGrade()
    {
        Console.Clear();
        Console.WriteLine(new string('\u2500', 150));
        Console.WriteLine(StudentGrade >= 50 ? "Congratulations, you passed this exam." : "Unfortunately, you failed in this exam. Stay tuned for the next year :)\nFor complaints, call: 175999.");
        Console.WriteLine($"Student Final Grade = {StudentGrade}%");
        Console.WriteLine(new string('\u2500', 150));
    }
}