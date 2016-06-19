using System;

namespace PlayerProject
{
    public abstract class GameObject
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS) +++++++++++++++++++++++++++++++++++
        private int _attack;

        private int _defense;

        private int _lives;

        private string _name;

        private int _speed;
        private double _direction; // angle in degrees
        private Vector2 _position; // postion in 2d space
        private Vector2 _facing; // where the game object is looking at in 2d space

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int Lives
        {
            get
            {
                return this._lives;
            }

            set
            {
                this._lives = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public int Speed
        {
            get
            {
                return this._speed;
            }

            set
            {
                this._speed = value;
            }
        }

        public int Attack
        {
            get
            {
                return this._attack;
            }

            set
            {
                this._attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return this._defense;
            }

            set
            {
                this._defense = value;
            }
        }

        public Vector2 Facing
        {
            get
            {
                return this._facing;
            }

            set
            {
                this._facing = value;
            }
        }

        public double Direction
        {
            get
            {
                return this._direction;
            }

            set
            {
                this._direction = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return this._position;
            }

            set
            {
                this._position = value;
            }
        }

        //  CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GameObject(string name)
        {
            this.Name = name;
            this._initialize();
        }

        // PRIVATE MEHTODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _initialize()
        {
            this.Attack = 0;
            this.Defense = 0;
            this.Lives = 0;
            this.Speed = 0;
            this.Position = new Vector2();
            this.Facing = new Vector2();
            this.Direction = this._calculateTargetAngle();
        }

        /**
         * <summary>
         * This utility method calculates the direction between two vectors
         * </summary>
         */
        private double _calculateTargetAngle()
        {
            float dx = this.Position.X - this.Facing.X;
            float dy = this.Position.Y - this.Facing.Y;
            dy = -dy;

            double radians = Math.Atan2(dy, dx);
            double targetAngle = radians * 180 / Math.PI; // angle in degrees
            targetAngle += 180;

            return targetAngle;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            return string.Format("Attack: {0}\nDefense: {1}\nName: {2}\nLives: {3}\nSpeed: {4}\nPosition.x: {5}\nPosition.y: {6}\nFacing.x: {7}\nFacing.y: {8}\nDirection: {9}",
                this.Attack, this.Defense, this.Name, this.Lives, this.Speed, this.Position.X, this.Position.Y, this.Facing.X, this.Facing.Y, this.Direction);
        }

        public void MoveRight()
        {
            Console.WriteLine("{0} is moving right.", this.Name);
        }

        public void MoveLeft()
        {
            Console.WriteLine("{0} is moving left.", this.Name);
        }

        public void MoveBack()
        {
            Console.WriteLine("{0} is moving back.", this.Name);
        }

        public void MoveForward()
        {
            Console.WriteLine("{0} is moving forward.", this.Name);
        }

        public void TurnLeft()
        {
            Console.WriteLine("{0} is turning left.", this.Name);
        }

        public void TurnRight()
        {
            Console.WriteLine("{0} is turning right.", this.Name);
        }
    }
}