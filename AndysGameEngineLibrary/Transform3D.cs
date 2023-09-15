namespace AndysGameEngineLibrary;

public class Transform3D : GameComponent
{
	public Transform3D(GameObject parentGameObject) : base(parentGameObject) {}

	public Transform3D(GameObject parentGameObject, Vector3 position) : base(parentGameObject) => 
		Position = position;

	public Vector3 Position { get; set; } = Vector3.Zero;
	public Vector3 Scale { get; set; } = Vector3.One;
	public Vector3 Rotation { get; set; } = Vector3.Zero;

	public override void Init() { }
	public override void Start() { }
	public override void Update() { }
	public override void OnDestroyed() { }
}