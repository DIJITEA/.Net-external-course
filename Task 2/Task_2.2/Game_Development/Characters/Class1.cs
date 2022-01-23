namespace Characters
{
    public class Player
    {
        private static int[] _playerPosition = { 1, 1 };
        protected static int[] _position;
        public static int[] playerPosition { get { return _playerPosition; } set { _playerPosition = value; } }
        protected static int[] _fieldBorder = new int[2];
        
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
                    _position[0] = _position[0] + 1;
                    break;
                case 2:
                    _position[0] = _position[0] - 1;
                    break;
                case 3:
                    _position[1] = _position[1] + 1;
                    break;
                case 4:
                    _position[1] = _position[1] - 1;
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
            if (playerPosition[0] < _position[0])
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
    public class Tree 
    {
        private int[] _treePosition = { new Random().Next(10, 15), new Random().Next(10, 15) };
        public Tree()
        {
          
            string i = "ssss";
        }

    }
}