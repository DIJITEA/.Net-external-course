namespace Characters
{
    public class Player
    {
        private static int[] _playerPosition = { 1, 1 };
        protected static int[] _position;
        public static int[] playerPosition { get { return _playerPosition; } set { _playerPosition = value; } }
        protected static int[] _fieldBorder = new int[2];
        
        public static bool isHiden() 
        {
            if ( Tree.forest[playerPosition[0], Tree.playerPosition[1]] == 1 )
                return true;
            else 
                return false;
        }

        // for if?
        public static void setborder(int[] setArray)
        {
            _fieldBorder = setArray;
        }
        public static int[] pMove(int directionSwitch)
        {
            _position = _playerPosition;
            return Move(directionSwitch);
        }
        public static int[] Move(int directionSwitch)
        {
            switch (directionSwitch)
            {
                case 1:
                    if (_position[0] + 1 < _fieldBorder[0] - 1)
                    {
                        _position[0] = _position[0] + 1;
                        break;
                    }   else
                        break;
                case 2:
                    if (_position[0] - 1 > 0)
                    {
                        _position[0] = _position[0] - 1;
                        break;
                    }   else 
                        break;
                case 3:
                    if (_position[1] + 1 < _fieldBorder[1] - 1)
                    {
                        _position[1] = _position[1] + 1;
                        break;
                    }   else
                        break;
                case 4:
                    if (_position[1] - 1 > 0 )
                    {
                        _position[1] = _position[1] - 1;
                        break;
                    }   else
                        break;
            }   
                return _position;
        }
    }
    public class Cyborg : Player
    {
        private static int[] _cyborgPosition = { new Random().Next(_fieldBorder[0] / 2, _fieldBorder[0] - 2), new Random().Next(_fieldBorder[1] / 2, _fieldBorder[1] - 2) };
        public static int[] cyborgPosition { get { return _cyborgPosition; }}
        public static int[] cMove()
        {
            _position = _cyborgPosition;
            int directionSwitch;
            if (isHiden())
            { 
                directionSwitch = new Random().Next(1, 5);
            }
            else if (playerPosition[0] < _position[0])
            {
                 directionSwitch = 2;
                
            }
            else if (playerPosition[0] > _position[0])
            {
                directionSwitch = 1;
            }
            else if( playerPosition[1] < _position[1])
            {
                directionSwitch= 4;
            }
            else 
            { 
                directionSwitch = 3; 
            }

            _position = _cyborgPosition;
            return Move(directionSwitch);
        }

    }
    public class Tree : Cyborg
    {
        public static int[] treePosition { get { return _fieldBorder; } set { _fieldBorder = value; } }
        private static int[,] _forest = new int[treePosition[0], treePosition[1]];
        public static int[,] forest { get { return _forest; } }
        public static void forestGeneration()
        {
            for (int i = 1; i < forest.GetLength(0)-1; i++)
            {
          
                for (int j = 1; j < forest.GetLength(1)-1; j++)
                {
                    if ((i == playerPosition[0] && j == playerPosition[1]) 
                        || 
                        (i == cyborgPosition[0] && j == cyborgPosition[1]))
                    {
                        forest[i, j] = 0;
                    }
                    else
                    forest[i, j] = new Random().Next(0, 2);
                    
                }
            }
        }
    }
    public class Gem : Cyborg
    {
        private static int[] _gemPosition ={ new Random().Next(_fieldBorder[0] / 2, _fieldBorder[0] - 2), new Random().Next(_fieldBorder[1] / 2, _fieldBorder[1] - 2) };
        public static int[] gemPosition { get { return _gemPosition; } }
        public static int[] gMove()
        {
            _position = _gemPosition;
            int directionSwitch = new Random().Next(1,5);
            return Move(directionSwitch);
        }
    }
}