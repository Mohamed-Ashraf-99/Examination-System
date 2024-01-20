using Examination_System.AnswerType;
using Examination_System.ExamSection;
using Examination_System.ExamType;
using Examination_System.QuestionSection;
using Examination_System.QuestionType;

namespace Examination_System;

abstract class Program
{
    private static void Main()
    {
        var questions = QuestionFactory.CreateDummyQuestions();
        var questionList = new QuestionListTxtFile("QuestionsList.txt");
        foreach (var question in questions)
        {
            questionList.Add(question);
        }
        
        // ========================================Create Exam Sections====================================
        #region Create Exam Sections

        // Create Subjects
        var subjectName = new SubjectType("C#");
        var timeSpan = new TimeSpan( 2, 0,0);
        Exam practiceExam = new PracticeExam(timeSpan, 10, subjectName);
        Exam finalExam = new FinalExam(timeSpan, 10, subjectName);

        int choice;
        do
        {
            Console.Write("Select Exam Type (1 for Practice, 2 for Final): ");
        } while (!int.TryParse(Console.ReadLine(), out choice));

        switch (choice)
        {
            case 1:
                practiceExam.ShowExam(questionList);
                break;
            case 2:
                finalExam.ShowExam(questionList);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        #endregion

    }
}