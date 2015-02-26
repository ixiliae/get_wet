     var Damping = 12.0;
    var Player : Transform;
    var Height : float = 13.0;
    var Offset : float = 0.0;
    private var Center : Vector3;
    var ViewDistance : float = 3.0;
    function Update ()
    {
    var mousePos = Input.mousePosition;
    mousePos.z = ViewDistance;
    var CursorPosition : Vector3 = Camera.main.ScreenToWorldPoint(mousePos);
    var PlayerPosition = Player.position;
    Center = Vector3((PlayerPosition.x + CursorPosition.x) / 2, PlayerPosition.y, (PlayerPosition.z + CursorPosition.z) / 2);
    transform.position = Vector3.Lerp(transform.position, Center + Vector3(0,Height,Offset), Time.deltaTime * Damping);
    }