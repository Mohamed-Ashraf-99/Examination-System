using Examination_System.AnswerType;
using Examination_System.QuestionType;

namespace Examination_System.QuestionSection;

public static class QuestionFactory
{
    public static List<Question> CreateDummyQuestions()
    {
        AnswerList choiceListTrueOrFalse;
        var questions = new List<Question>
        {
            new TrueFalseQuestion(
                "1- C# is a statically typed language, which means that variable types must be explicitly?", 10,
                "True or False", new AnswerList() { new Answer("  A. True."), new Answer("  B. False.") },
                new Answer("True")),
            new TrueFalseQuestion(
                "2- In C#, the string and System.String are interchangeable and can be used interchangeably?", 10,
                "True or False", new AnswerList() { new Answer("  A. True."), new Answer("  B. False.") },
                new Answer("True")),
            new TrueFalseQuestion(
                "3- C# supports multiple inheritance, allowing a class to inherit from more than one base class.?", 10,
                "True or False", new AnswerList() { new Answer("  A. True."), new Answer("  B. False.") },
                new Answer("False")),
            new ChooseOneQuestion("4- Which keyword is used to define a constant in C#?", 10,
                "Choose only one from the following: ",
                new AnswerList()
                {
                    new Answer("  A. var."), new Answer("  B. final."), new Answer("  C. const."),
                    new Answer("  D. static."),
                }, new Answer("const")),
            new ChooseOneQuestion(
                "5- Which access modifier restricts the visibility of a class member to within the same assembly?", 10,
                "Choose only one from the following: ",
                new AnswerList()
                {
                    new Answer("  A. private."), new Answer("  B. internal."), new Answer("  C. protected."),
                    new Answer("  D. public."),
                }, new Answer("internal")),
            new ChooseOneQuestion(
                "6- In C#, which access modifier is the most restrictive, allowing access only within the same class?",
                10, "Choose only one from the following: ", new AnswerList()
                {
                    new Answer("  A. public."),
                    new Answer("  B. protected."),
                    new Answer("  C. internal."),
                    new Answer("  D. private."),
                }, new Answer("private")),
            new ChooseOneQuestion("7- What is the default access modifier for the members of an interface in C#?", 10,
                "Choose only one from the following: ", new AnswerList()
                {
                    new Answer("  A. private."),
                    new Answer("  B. internal."),
                    new Answer("  C. protected."),
                    new Answer("  D. static."),
                }, new Answer("public")),
            new ChooseAllQuestion(
                "8- What is the C# keyword for defining a block of code that will be executed, regardless of whether an exception is thrown?",
                10, "Choose one or more from the following: ", new AnswerList()
                {
                    new Answer("  A. finally."),
                    new Answer("  B. catch."),
                    new Answer("  C. ensure."),
                    new Answer("  D. recover."),
                }, new Answer("finally")),
            new ChooseAllQuestion("9- Which of the following are valid access modifiers in C#?", 10,
                "Choose one or more from the following: ", new AnswerList()
                {
                    new Answer("  A. public."),
                    new Answer("  B. static."),
                    new Answer("  C. final."),
                    new Answer("  D. internal."),
                }, new Answer("public")),
            new ChooseAllQuestion("10- Which keyword is used to create an instance of a class in C#?", 10,
                "Choose one or more from the following: ", new AnswerList()
                {
                    new Answer("  A. instantiate."),
                    new Answer("  B. object."),
                    new Answer("  C. new."),
                    new Answer("  D. create."),
                }, new Answer("new"))
        };
        return questions;
    }
}