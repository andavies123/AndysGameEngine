namespace AndysGameEngine;

public readonly struct Vector3
{
	public readonly float X;
	public readonly float Y;
	public readonly float Z;

	public Vector3(float x, float y, float z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public static Vector3 operator +(Vector3 a, Vector3 b) =>
		new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	
	public static Vector3 operator -(Vector3 a, Vector3 b) =>
		new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	
	public static Vector3 operator *(Vector3 a, Vector3 b) =>
		new(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
}