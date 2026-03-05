using System;

public delegate bool Validator(string text);

class ValidatorExample
{
    public static Validator GetValidator(int minLength)
    {
        return s => s.Length >= minLength;
    }

    public static void Run()
    {
        Validator passwordValidator = GetValidator(8);
        Validator loginValidator = GetValidator(3);

        string testLogin = "User";
        string testPass = "login123";

        Console.WriteLine($"Login '{testLogin}' validate: {loginValidator(testLogin)}");
        Console.WriteLine($"Password '{testPass}' validate: {passwordValidator(testPass)}");
    }
}