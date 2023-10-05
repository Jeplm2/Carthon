using UnityEngine;

public class controls : MonoBehaviour
{
    public bool moveLeft = false;
    public bool moveRight = false;
    public void OnLeftButtonPressed()
    {
        moveLeft = true;
        Debug.Log("Left Pressed!");
    }

    public void OnRightButtonPressed()
    {
        moveRight = true;
        Debug.Log("Right Pressed!");
    }

    public void onLeftButtonReleased()
    {
        moveLeft = false;
        Debug.Log("Left Released");
    }

    public void OnRightButtonReleased()
    {
        moveRight = false;
        Debug.Log("Right Released");
    }

}
