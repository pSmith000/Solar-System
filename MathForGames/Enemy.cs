using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGames
{
    class Enemy : Actor
    {
        private float _speed;
        private Vector2 _velocity;
        private Player _player;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Enemy(float x, float y, float speed, Player player, string name = "Actor", string path = "")
            : base( x, y, name, path)
        {
            _player = player;
            _speed = speed;
        }

        public override void Update(float deltaTime)
        {
            Vector2 moveDirection = _player.LocalPosition - LocalPosition;

            Velocity = moveDirection.Normalized * Speed * deltaTime;

            LocalPosition += Velocity;

            base.Update(deltaTime);
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
