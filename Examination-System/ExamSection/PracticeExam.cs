using Examination_System.AnswerType;
using Examination_System.QuestionType;

namespace Examination_System.ExamType;

public class PracticeExam : Exam
{
    public AnswerList StudentAnswers { get; private set; }
    // public Answer AnswerInstance { get; private set; }
    // public QuestionList Questions { get; private set; }
    private int _studentGrade;
    
    public PracticeExam(TimeSpan time, int numberOfQuestions, SubjectType subject) : base(time, numberOfQuestions, subject)
    {
        StudentAnswers = new AnswerList();
        // Questions = new QuestionList();
        _studentGrade = 0;
    }
    
    public override void ShowExam(QuestionList questionsList)
    {
        DisplayHeader();
        ProcessQuestions(questionsList);
        ShowStudentGrade();
    }
    
    private void DisplayHeader()
    {
        Console.Clear();
        Console.WriteLine("====================================== PRACTICE EXAM ======================================");
        Console.WriteLine($"\n- Exam Time: {Time} Hours.\n- Number of Questions: {NumberOfQuestions}.\n- Subject: {Subject.SubjectName}.\n");
        Console.WriteLine("Identify the choice that best completes the statement or answers the question.");
        Console.WriteLine(new string('\u2500', 150));
    }
    
    private void ProcessQuestions(QuestionList questionsList)
    {
        foreach (var question in questionsList.QuestionsList)
        {
            question.DisplayQuestion();
            Console.WriteLine();
            Console.Write("  >> Answer: ");
            string studentAnswer = Console.ReadLine();
            Console.WriteLine($"Correct Answer is: {question.CorrectAnswer.Title}");
            Console.WriteLine(new string('\u2500', 150));
            _studentGrade = CheckIfAnswerIsCorrect(studentAnswer, question.CorrectAnswer.Title, _studentGrade);
        }
    }
    
    private int CheckIfAnswerIsCorrect(string studentAnswer, string correctAnswer, int grade)
    {
        if (studentAnswer == correctAnswer)
        {
            grade += 10; 
        }
        return grade;
    }

    private void ShowStudentGrade()
    {
        Console.Clear();
        Console.WriteLine(new string('\u2500', 150));
        Console.WriteLine(_studentGrade >= 50 ? "- Congratulations, you passed this exam." : "- Unfortunately, you failed in this exam. Stay tuned for the next year :)\n- For any complaints, call: 175999.");
        Console.WriteLine($"- Student Final Grade = {_studentGrade}%");
        Console.WriteLine(new string('\u2500', 150));
    }
    
}