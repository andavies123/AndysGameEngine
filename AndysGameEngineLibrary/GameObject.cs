namespace AndysGameEngineLibrary;

public class GameObject
{
	private readonly List<IGameComponent> _gameComponents = new();
	private readonly List<GameObject> _children = new();
	
	public GameObject(GameObject parent, string name)
	{
		Parent = parent;
		Name = name;
		AddComponent(new Transform3D(this));
	}
	
	public GameObject Parent { get; private set; }
	public Guid Id { get; } = Guid.NewGuid();
	public string Name { get; set; }
	public bool IsEnabled { get; set; } = true;
	public int ChildCount => _children.Count;
	
	public void Start()
	{
		foreach (IGameComponent component in _gameComponents)
			component.Start();

		foreach (GameObject child in _children)
			child.Start();
	}

	public void Update()
	{
		foreach (IGameComponent component in _gameComponents)
		{
			if (component.IsEnabled)
				component.Update();
		}

		foreach (GameObject child in _children)
		{
			if (child.IsEnabled)
				child.Update();
		}
	}

	public void SetParent(GameObject newParent)
	{
		Parent?.RemoveChild(this);
		Parent = newParent;
		Parent?.AddChild(this);
	}

	/// <summary>
	/// Looks for the given component type in the internal collection
	/// </summary>
	public bool TryGetGameComponent<T>(out T gameComponent) where T : IGameComponent
	{
		gameComponent = default;
		
		foreach (IGameComponent component in _gameComponents)
		{
			if (component is T castedGameComponent)
			{
				gameComponent = castedGameComponent;
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Add a new component to the end of the internal components collection
	/// </summary>
	public void AddComponent(IGameComponent gameComponent)
	{
		if (gameComponent == null)
			return;
		
		_gameComponents.Add(gameComponent);
		gameComponent.Init();
	}

	/// <summary>
	/// Removes a component from the internal components collection that matches
	/// the given component id
	/// </summary>
	public void RemoveComponent(Guid componentId) =>
		RemoveComponent(_gameComponents.FirstOrDefault(component => component.Id == componentId));

	/// <summary>
	/// Removes an existing component from the internal components collection
	/// </summary>
	public void RemoveComponent(IGameComponent componentToRemove)
	{
		if (componentToRemove != null && _gameComponents.Remove(componentToRemove))
			componentToRemove.OnDestroyed();
	}

	private void RemoveChild(GameObject gameObject) =>
		_children.Remove(gameObject);

	private void AddChild(GameObject gameObject) =>
		_children.Add(gameObject);
}