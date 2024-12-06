using System;
using System.Drawing;

Point testcords = new(-4f, 0f);
Console.WriteLine($"X: {testcords.Xcoordinate}, Y: {testcords.Ycoordinate}");


public class Point
{

	private float xcoordinate;
	private float ycoordinate;

	

	//Constructor
	public Point(float x, float y)
	{
		this.xcoordinate = x;
		this.ycoordinate = y;

	}


    public Point() : this(0, 0) { }


    public float Xcoordinate
    {

        get { return xcoordinate; }
        set { xcoordinate = value; }

    }

    public float Ycoordinate

    {
        get { return ycoordinate; }
        set { ycoordinate = value; }
    }


}
