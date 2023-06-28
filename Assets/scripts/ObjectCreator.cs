using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject objectPrefab; 

    private float xPosition = -4.89f; 
    private float yPosition = -1.12f;
    private float xPosition1 = -0.8f;
    private float yPosition1 = 0.3f; 
    private float xPosition2 = 5.11f;
    private float yPosition2 = -1.69f;
    private float xPosition3 = 4.48f;
    private float yPosition3 = 2.18f;

    public  void tower1()
    {
        
        GameObject createdObject = Instantiate(objectPrefab, new Vector2(xPosition, yPosition), Quaternion.identity);
    }
    public void tower2()
    {

        GameObject createdObject = Instantiate(objectPrefab, new Vector2(xPosition1, yPosition1), Quaternion.identity);
    }
    public void tower3()
    {

        GameObject createdObject = Instantiate(objectPrefab, new Vector2(xPosition2, yPosition2), Quaternion.identity);
    }
    public void tower4()
    {

        GameObject createdObject = Instantiate(objectPrefab, new Vector2(xPosition3, yPosition3), Quaternion.identity);
    }
}
