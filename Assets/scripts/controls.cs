using UnityEngine;

public class controls : MonoBehaviour
{
    public bool moveLeft = false;
    public bool moveRight = false;
    public void OnLeftButtonPressed()
    {
        moveLeft = true;
    }

    public void OnRightButtonPressed()
    {
        moveRight = true;
    }

    public void onLeftButtonReleased()
    {
        moveLeft = false;
    }

    public void OnRightButtonReleased()
    {
        moveRight = false;
    }

}
