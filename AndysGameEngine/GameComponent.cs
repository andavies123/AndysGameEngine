namespace AndysGameEngine;

public abstract class GameComponent : IGameComponent
{
	protected GameComponent(GameObject parentGameObject)
	{
		GameObject = parentGameObject;
	}
	
	public Guid Id { get; } = Guid.NewGuid();
	public GameObject GameObject { get; }
	public bool IsEnabled { get; set; } = true;

	public abstract void Init();
	public abstract void Start();
	public abstract void Update();
	public abstract void OnDestroyed();
}