using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;
    // public string firstName;
    // public string lastName;
    // public int id;
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstname, string lastname, int id, int[] scores)
    {
        this.firstName = firstname;
        this.lastName = lastname;
        this.id = id;
        this.testScores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        int temp = 0;
        for (int i = 0; i < this.testScores.Length; i++)
        {
            temp += this.testScores[i];
        }
        double percentageMark = temp / this.testScores.Length;
        if (percentageMark >= 90 && percentageMark <= 100)
            return 'O';
        else if (percentageMark >= 80 && percentageMark < 90)
            return 'E';
        else if (percentageMark >= 70 && percentageMark < 80)
            return 'A';
        else if (percentageMark >= 55 && percentageMark < 70)
            return 'P';
        else if (percentageMark >= 40 && percentageMark < 55)
            return 'D';
        else
            return 'T';
    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}