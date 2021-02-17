using UnityEngine;

public class CellDoor : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // TODO: Detect when player is nearby (collision detection)
            Open();
        }
    }

    private void Open()
    {
        Debug.Log("Open cell door");
        _anim.Play("CellDoorOpen");
        // TODO: Run animation (parameters: move direction (left or right), and distance (3 units maybe), and speed (how fast to open)
        // All of these can be done within an animation or they can be done programatically

    }
}
