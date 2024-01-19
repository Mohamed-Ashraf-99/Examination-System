using Examination_System.AnswerType;
using Examination_System.ExamType;
using Examination_System.QuestionType;

namespace Examination_System;

abstract class Program
{
    private static void Main()
    {
        // ========================================Choice List Section====================================

        #region Choice List Section

        var choiceListTrueOrFalse = new AnswerList()
        {
            new Answer("  A. True."),
            new Answer("  B. False.")
        };

        //Choice List For One Choice Questions
        var choiceListQuestionOne = new AnswerList()
        {
            new Answer("  A. var."),
            new Answer("  B. final."),
            new Answer("  C. const."),
            new Answer("  D. static."),
        };
        var choiceListQuestionTwo = new AnswerList()
        {
            new Answer("  A. private."),
            new Answer("  B. internal."),
            new Answer("  C. protected."),
            new Answer("  D. public."),
        };
        var choiceListQuestionThree = new AnswerList()
        {
            new Answer("  A. public."),
            new Answer("  B. protected."),
            new Answer("  C. internal."),
            new Answer("  D. private."),
        };
        var choiceListQuestionFour = new AnswerList()
        {
            new Answer("  A. private."),
            new Answer("  B. internal."),
            new Answer("  C. protected."),
            new Answer("  D. static."),
        };
        //Choice List For All Choice Questions
        var choiceListAllQuestionOne = new AnswerList()
        {
            new Answer("  A. finally."),
            new Answer("  B. catch."),
            new Answer("  C. ensure."),
            new Answer("  D. recover."),
        }; 
        var choiceListAllQuestionTwo = new AnswerList()
        {
            new Answer("  A. public."),
            new Answer("  B. static."),
            new Answer("  C. final."),
            new Answer("  D. internal."),
        }; 
        var choiceListAllQuestionThree = new AnswerList()
        {
            new Answer("  A. instantiate."),
            new Answer("  B. object."),
            new Answer("  C. new."),
            new Answer("  D. create."),
        };

        #endregion
        
        // ========================================Correct Answers Section================================

        #region Correct Answers Section

        //1- Correct Answer For True False
        var correctAnswerTrue = new Answer("True");
       
        var correctAnswerFalse = new Answer("False");
        
        //2- Correct Answer For One Choice Questions
        var correctAnswerChoiceOneOne = new Answer("const");
    
        var correctAnswerChoiceOneTwo = new Answer("internal");
      
        var correctAnswerChoiceOneThree = new Answer("private");
      
        var correctAnswerChoiceOneFour = new Answer("public");
    
        //2- Correct Answer For All Choice Questions
        var correctAnswerChoiceAllOne = new Answer("finally");
     
        var correctAnswerChoiceAllTwo = new Answer("public");

        var correctAnswerChoiceAllThree = new Answer("new");

        #endregion
        
        // ========================================Create Questions Section====================================

        #region Create Questions Section

        //1- True Or False Questions
        var trueFalseQuestionOne = new TrueFalseQuestion
        (
            "1- C# is a statically typed language, which means that variable types must be explicitly?", 
            10,
            "True or False", 
            choiceListTrueOrFalse, 
            correctAnswerTrue);
        
        var trueFalseQuestionTwo = new TrueFalseQuestion
        (
            "2- In C#, the string and System.String are interchangeable and can be used interchangeably?", 
            10,
            "True or False", 
            choiceListTrueOrFalse, 
            correctAnswerTrue);
        
        var trueFalseQuestionThree = new TrueFalseQuestion
        (
            "3- C# supports multiple inheritance, allowing a class to inherit from more than one base class.?", 
            10,
            "True or False", 
            choiceListTrueOrFalse, 
            correctAnswerFalse);
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ChooseOne Questions
        var chooseOneQuestionOne = new ChooseOneQuestion
        (
            "4- Which keyword is used to define a constant in C#?", 
            10, 
            "Choose only one from the following: ",
            choiceListQuestionOne, 
            correctAnswerChoiceOneOne);
        
        var chooseOneQuestionTwo = new ChooseOneQuestion(
            "5- Which access modifier restricts the visibility of a class member to within the same assembly?", 
            10,
            "Choose only one from the following: ", 
            choiceListQuestionTwo, 
            correctAnswerChoiceOneTwo);
        
        var chooseOneQuestionThree = new ChooseOneQuestion
        (
            "6- In C#, which access modifier is the most restrictive, allowing access only within the same class?", 
            10,
            "Choose only one from the following: ", 
            choiceListQuestionThree, 
            correctAnswerChoiceOneThree);
        
        var chooseOneQuestionFour = new ChooseOneQuestion
        (
            "7- What is the default access modifier for the members of an interface in C#?", 
            10,
            "Choose only one from the following: ", 
            choiceListQuestionFour, 
            correctAnswerChoiceOneFour);
        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ChooseAll Questions
        var chooseAllQuestionOne = new ChooseAllQuestion
        (
            "8- What is the C# keyword for defining a block of code that will be executed, regardless of whether an exception is thrown?", 
            10,
            "Choose one or more from the following: ",
            choiceListAllQuestionOne, 
            correctAnswerChoiceAllOne);
        
        var chooseAllQuestionTwo = new ChooseAllQuestion
        (
            "9- Which of the following are valid access modifiers in C#?", 
            10, 
            "Choose one or more from the following: ",
            choiceListAllQuestionTwo, 
            correctAnswerChoiceAllTwo);
        
        var chooseAllQuestionThree = new ChooseAllQuestion
        (
            "10- Which keyword is used to create an instance of a class in C#?", 
            10,
            "Choose one or more from the following: ",
            choiceListAllQuestionThree, 
            correctAnswerChoiceAllThree);
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Add the questions to the questions list

        var questionsList = new QuestionList();
        questionsList.Add(trueFalseQuestionOne);
        questionsList.Add(trueFalseQuestionTwo);
        questionsList.Add(trueFalseQuestionThree);
        questionsList.Add(chooseOneQuestionOne);
        questionsList.Add(chooseOneQuestionTwo);
        questionsList.Add(chooseOneQuestionThree);
        questionsList.Add(chooseOneQuestionFour);
        questionsList.Add(chooseAllQuestionOne);
        questionsList.Add(chooseAllQuestionTwo);
        questionsList.Add(chooseAllQuestionThree);

        #endregion
        
        //============================================ Create Exam Sections ==========================================

        #region Create Exam Sections

        // Create Subjects
        var subjectName = new SubjectType("C#");
        var timeSpan = new TimeSpan( 2, 0,0);
        Exam practiceExam = new PracticeExam(timeSpan, 10, subjectName);
        Exam finalExam = new FinalExam(timeSpan, 20, subjectName);

        int choice;
        do
        {
            Console.Write("Select Exam Type (1 for Practice, 2 for Final): ");
        } while (!int.TryParse(Console.ReadLine(), out choice));

        switch (choice)
        {
            case 1:
                practiceExam.ShowExam(questionsList);
                break;
            case 2:
                finalExam.ShowExam(questionsList);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        #endregion

    }
}