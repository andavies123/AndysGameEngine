namespace AndysGameEngine;

public interface IGameComponent
{
	Guid Id { get; }
	GameObject GameObject { get; }
	bool IsEnabled { get; set; }
	
	/// <summary>
	/// Called when a game component is added to a game object
	/// This method should only handle internal initialization as other
	/// components might not be created/added yet
	/// </summary>
	void Init();
	
	/// <summary>
	/// Called after all components on a game object have been initialized.
	/// Use this function to access other components
	/// </summary>
	void Start();
	
	/// <summary>
	/// Called once per frame in the order the game components were added
	/// to the game object
	/// </summary>
	void Update();
	
	/// <summary>
	/// Called when a game component is removed from a game object
	/// </summary>
	void OnDestroyed();
}