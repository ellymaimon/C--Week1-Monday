using System;
using System.Collections.Generic;

class Triangle
{
    private int _sideOne;
    private int _sideTwo;
    private int _sideThree;

    public void SetSideOne(int newSideOne)
    {
        _sideOne = newSideOne;
    }
    public int GetSideOne()
    {
        return _sideOne;
    }

    public void SetSideTwo(int newSideTwo)
    {
        _sideTwo = newSideTwo;
    }
    public int GetSideTwo()
    {
        return _sideTwo;
    }

    public void SetSideThree(int newSideThree)
    {
        _sideThree = newSideThree;
    }
    public int GetSideThree()
    {
        return _sideThree;
    }

    public void TypeOfTriangle(int SideOne, int SideTwo, int SideThree)
    {
        if (SideOne + SideTwo < SideThree || SideTwo + SideThree < SideOne || SideThree + SideOne < SideTwo)
        {
            Console.WriteLine("Your shape is not a triangle.");
        }
        else if (SideOne == SideTwo && SideTwo == SideThree)
        {
            Console.WriteLine("Your triangle is equilateral.");
        }
        else if (SideOne == SideTwo || SideTwo == SideThree || SideThree == SideOne)
        {
            Console.WriteLine("Your triangle is isoscles.");
        }
        else
        {
            Console.WriteLine("Your triangle is scalene.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Triangle ourTriangle = new Triangle();
        Console.WriteLine("Enter the length of side one.");
        string userSide1 = Console.ReadLine();
        int Side1 = int.Parse(userSide1);
        Console.WriteLine("Enter the length of side two.");
        string userSide2 = Console.ReadLine();
        int Side2 = int.Parse(userSide2);
        Console.WriteLine("Enter the length of side three.");
        string userSide3 = Console.ReadLine();
        int Side3 = int.Parse(userSide3);
        ourTriangle.SetSideOne(Side1);
        ourTriangle.SetSideTwo(Side2);
        ourTriangle.SetSideThree(Side3);
        ourTriangle.TypeOfTriangle(ourTriangle.GetSideOne(), ourTriangle.GetSideTwo(), ourTriangle.GetSideThree());
    }
}
