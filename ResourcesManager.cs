using UnityEngine; // Import the UnityEngine's library
using TMPro; // Import the TMPro's library

public class ResourcesManager : MonoBehaviour {

    // Shows the name of that group in the Inspector
    [Header("Resources Quantities")] 
    
    // Contains the quantity of wood
    public int woodQuantity;
    
    // Contains the quantity of stone
    public int stoneQuantity; 
    
    // Contains the quantity of iron
    public int ironQuantity; 

    //Shows the name of that group in the Inspector
    [Header("Text GameObjects")]
    
    // A text object that show the quantity of wood
    public TextMeshProUGUI woodTxt;
    
    // A text object that show the quantity of stone
    /*public TextMeshProUGUI stoneTxt;
     
    // A text object that show the quantity of iron
    public TextMeshProUGUI ironTxt;*/

    void Update() {
        
        //Shows the quantity of wood in the UI
        woodTxt.text = "Wood: " + woodQuantity;
        
        //Shows the quantity of stone in the UI
        /*stoneTxt.text = "Stone: " + stoneQuantity;
         
         //Shows the quantity of iron in the UI
        ironTxt.text = "Stone: " + ironQuantity; */
    }
    
    /// <summary>
    /// Adds an quantity of a given resource to the player's inventory
    /// </summary>
    /// <param name="type"> The resource's type </param>
    /// <param name="resourcesQuantity"> The resource's quantity </param>
    public void AddResources(ResourceType type, int resourcesQuantity) {

        switch (type) {

            case ResourceType.Wood:
                
                woodQuantity += resourcesQuantity;
                break;

            case ResourceType.Stone:
                
                stoneQuantity += resourcesQuantity;
                break;

            case ResourceType.Iron:
                
                ironQuantity += resourcesQuantity;
                break;
        }
    }

    /// <summary>
    /// Removes an quantity of a given resource from the player's inventory
    /// </summary>
    /// <param name="type"> The resource's type </param>
    /// <param name="resourcesQuantity"> The resource's quantity </param>
    public void SubtractResources(ResourceType type, int resourcesQuantity) {

        switch (type) {

            case ResourceType.Wood:
                
                woodQuantity -= resourcesQuantity;
                break;

            case ResourceType.Stone:
                
                stoneQuantity -= resourcesQuantity;
                break;

            case ResourceType.Iron:
                
                ironQuantity -= resourcesQuantity;
                break;
        }
    }
}
