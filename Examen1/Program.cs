using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
    public int Age = DateTime.Now.Year;

    public void PrintName()
    {
        Console.WriteLine($"Numele meu este {FirstName}{LastName}, m-am nascut in {YearOfBirth} si am varsta de {Age} ani");
    }
    static Person CitestePersoana()
    {
        Person person = new Person();

        Console.Write("First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Year of birth: ");
        person.YearOfBirth = Convert.ToInt32(Console.ReadLine());

        return person;
    }
