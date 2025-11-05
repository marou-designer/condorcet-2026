namespace Poo;

public abstract class Person
{
    // CTRL+K+D : reindent code
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public required string NationalNumber { get; set; }

    public void PrintMyself()
    {
        Console.WriteLine($"Je m'appelle {FirstName} {LastName} et mon numéro de " +
                          $"registre national est {NationalNumber}");
    }
    
    // CTRL+R+R : rename
    public string GetDescription()
    {
        return $"Je m'appelle {FirstName} {LastName} et mon numéro de " +
                          $"registre national est {NationalNumber}";
    }
}