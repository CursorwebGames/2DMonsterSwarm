using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Vector3 offset;

    private void Update()
    {

        if (playerMovement.back)
        {
            transform.localPosition = offset + new Vector3(0, 0, 0.5f);
        }
        else
        {
            transform.localPosition = offset + new Vector3(0, 0, -0.5f);
        }
    }
}
