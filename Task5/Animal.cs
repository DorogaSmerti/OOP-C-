using System.Text.Json.Serialization;

[JsonDerivedType(typeof(Dog), typeDiscriminator: "dog")]
[JsonDerivedType(typeof(Cat), typeDiscriminator: "cat")]
public abstract class Animal
{
    public string Name{get;set;}
}

public class Dog : Animal
{
    public int BarkVolume{get;set;}
}

public class Cat : Animal
{
    public int Lives{get;set;}
}