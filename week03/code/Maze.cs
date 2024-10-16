/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    public void MoveLeft()
    {
        var directions = GetDirections();
        if (!directions[0]) // left
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        _currX -= 1; // Move left
    }

    public void MoveRight()
    {
        var directions = GetDirections();
        if (!directions[1]) // right
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        _currX += 1; // Move right
    }

    public void MoveUp()
    {
        var directions = GetDirections();
        if (!directions[2]) // up
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        _currY -= 1; // Move up
    }

    public void MoveDown()
    {
        var directions = GetDirections();
        if (!directions[3]) // down
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        _currY += 1; // Move down
    }

    private bool[] GetDirections()
    {
        // Get the valid directions for the current position
        if (_mazeMap.TryGetValue(( _currX, _currY), out var directions))
        {
            return directions;
        }
        throw new InvalidOperationException("Invalid current position!");
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}