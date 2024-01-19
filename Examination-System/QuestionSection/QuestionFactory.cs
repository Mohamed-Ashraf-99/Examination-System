namespace Examination_System.QuestionType;

public static class QuestionFactory
{
    public static List<Question> CreateDummyQuestions()
    {
        var questions = new List<Question>
        {
        //     new TrueFalseQuestion("1- C# is a statically typed language, which means that variable types must be explicitly?", 10, "True or False", choiceListTrueOrFalse,),
        //     new TrueFalseQuestion("2- In C#, the string and System.String are interchangeable and can be used interchangeably?", 10, "True or False"),
        //     new TrueFalseQuestion("3- C# supports multiple inheritance, allowing a class to inherit from more than one base class.?", 10, "True or False"),
        //     new ChooseOneQuestion("4- Which keyword is used to define a constant in C#?", 10, "Choose only one from the following: ", new List<string> { "var", "final", "const", "static" }),
        //     new ChooseOneQuestion("5- Which access modifier restricts the visibility of a class member to within the same assembly?", 10, "Choose only one from the following: ", new List<string> { "It defines the block of code to be executed if an exception occurs", "It defines the block of code to be executed regardless of whether an exception occurs or not.", "It specifies the type of exception to catch.", "It indicates the starting point of the try-catch-finally statement." }),
        //     new ChooseOneQuestion("6- In C#, which access modifier is the most restrictive, allowing access only within the same class?", 10, "Choose only one from the following: ", new List<string> { "public", "protected", "internal", "private" }),
        //     new ChooseOneQuestion("7- What is the default access modifier for the members of an interface in C#?", 10, "Choose only one from the following: ", new List<string> { "var", "final", "const", "static" }),
        //     new ChooseAllQuestion("8- What is the C# keyword for defining a block of code that will be executed, regardless of whether an exception is thrown?", 10, "Choose one or more from the following: ", new List<string> { "It specifies that the method is a constructor.", "It allows the method to accept a variable number of parameters.", "It indicates that the method should be private.", "It denotes a method that returns multiple values.", "6" }),
        //     new ChooseAllQuestion("9- Which of the following are valid access modifiers in C#?", 10, "Choose one or more from the following: ", new List<string> { "public", "static", "final", "internal" }),
        //     new ChooseAllQuestion("10- Which keyword is used to create an instance of a class in C#?", 10, "Choose one or more from the following: ", new List<string> { "It imports a namespace.", "It declares a constant", "It creates an instance of a class.", "It defines a loop."})
        //
        };
        return questions;
    }
}