using UnityEngine; // Import the UnityEngine's library

public class Resource : MonoBehaviour {

    // Resource's type
    public ResourceType type;

    // Resource's Life
    public int life; 
    
    // Value of resources that will be added to inventory
    public int quantityValue;
   
    // ResourcesManager's script
    public ResourcesManager resourcesManagerScript;
    
    // CharacterManager's script (or the player's script, if there is only on character controlled by the player)
    public CharactersManager charactersManagerScript;
    void Start() {

        // Find the ResourcesManager's script in a BuildingSystem's GameObject and assign it in the resourcesManager
        resourcesManagerScript = GameObject.Find("BuildingSystem").GetComponent<ResourcesManager>();
        
        // Find the CharactersManager's script in a Manager's GameObject and assign it in the charactersManager
        charactersManagerScript = GameObject.Find("Manager").GetComponent<CharactersManager>();
    }

    void Update() {

        // Call the VerifyLife's function
        VerifyLife();
    }

    /// <summary>
    /// Add a resource to the player's inventory
    /// </summary>
    /// <param name="type"> The resource's type </param>
    /// <param name="value"> The resource's quantity </param>
    void AddResourceToPlayerInv(ResourceType type, int value) {

        // Call the "AddResources" function in the ResourcesManager's script to add the resource to the player's inventory
        resourcesManagerScript.AddResources(type, value);

        // Call the "RemoveActualResource" function in the CharactersManager's script to remove the target on this resource
        charactersManagerScript.RemoveActualResource();

        // Destroy this GameObject (the resource)
        Destroy(this.gameObject);
    }

    /// <summary>
    /// Resource life's condition
    /// </summary>
    void VerifyLife() {

        if (life <= 0) {

            // Call the "AddResourceToPlayerInv" function to add that resource to the player's inventory
            AddResourceToPlayerInv(type, quantityValue);
        }
    }
    
    /// <summary>
    ///  Decreases that resource's health
    /// </summary>
    /// <param name="damage"> The value that will be discounted from life </param>
    public void TakeDamage(int damage) {

        life -= damage;

        print(life);
    }
}

/// <summary>
/// The resource's type
/// </summary>
public enum ResourceType {

    Wood,
    Stone,
    Iron
}
