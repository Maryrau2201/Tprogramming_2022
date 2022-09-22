namespace CourseApp;

using System;

public class Town
{
    private int population;

    private int dateOfBuilding;

    public Town(string name)
    {
        this.Name = name;
        DateOfBuilding = 789;
        Population = 7960;
    }

    public Town(string name, int population)
    {
        this.Name = name;
        this.Population = population;
        DateOfBuilding = 1800;
    }

    public Town(string name, int population, int dob)
    {
        this.Name = name;
        this.Population = population;
        this.DateOfBuilding = dob;
    }

    public string Name { get; set; }

    public int Population
    {
        get
        {
            return population;
        }

        set
        {
            population = value;
        }
    }

    public int DateOfBuilding
    {
        get
        {
            return dateOfBuilding;
        }

        set
        {
            dateOfBuilding = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Название:  {Name} Население : {population} Дата основания:{DateOfBuilding}");
    }

    public void Hello()
    {
        Console.WriteLine("Здравствуйте,Добро пожаловать");
    }

    public void Privetstvie()
    {
        Console.WriteLine($"Вы из города {Name}? Я тоже! \n");
    }
}
