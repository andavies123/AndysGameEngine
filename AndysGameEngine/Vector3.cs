namespace AndysGameEngine;

public readonly struct Vector3
{
	public static readonly Vector3 Zero = new(0, 0, 0);
	public static readonly Vector3 One = new(1, 1, 1);
	public static readonly Vector3 Forward = new(0, 0, 1);
	public static readonly Vector3 Backward = new(0, 0, -1);
	public static readonly Vector3 Right = new(1, 0, 0);
	public static readonly Vector3 Left = new(-1, 0, 0);
	public static readonly Vector3 Up = new(0, 1, 0);
	public static readonly Vector3 Down = new(0, -1, 0);
	
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