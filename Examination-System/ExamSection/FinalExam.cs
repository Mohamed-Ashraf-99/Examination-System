using Examination_System.ExamType;
using Examination_System.QuestionSection;
using Examination_System.QuestionType;

namespace Examination_System.ExamSection;

public class FinalExam : Exam
{
    public AnswerList StudentAnswers { get; private set; }
    
    public FinalExam(TimeSpan time, int numberOfQuestions, SubjectType subject) : base(time, numberOfQuestions, subject)
    {
        StudentAnswers = new AnswerList();
    }
    
    public override void ShowExam(QuestionListTxtFile questionsList)
    {
        DisplayHeader();
        ProcessQuestions(questionsList);
        ShowStudentGrade();
    }

    protected override void DisplayHeader()
    {
        Console.Clear();
        Console.WriteLine("======================================= FINAL EXAM =======================================");
        Console.WriteLine($"\nExam Time: {Time} Hours\nNumber of Questions: {NumberOfQuestions}\nSubject: {Subject.SubjectName}\n");
        Console.WriteLine("Identify the choice that best completes the statement or answers the question.");
    }

    protected override void ProcessQuestions(QuestionListTxtFile questionsList)
    {
        foreach (var question in questionsList)
        {
            question.DisplayQuestion();
            Console.WriteLine();
            Console.Write("  >> Answer: ");
            string? studentAnswer = Console.ReadLine();
            Console.WriteLine(new string('\u2500', 150));
            StudentGrade = CheckIfAnswerIsCorrect(studentAnswer, question.CorrectAnswer.Title, StudentGrade);
        }
    }
    
}