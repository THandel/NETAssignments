using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;

namespace Assignment8.Models
{
    [Table(Name = "Players")]
    public class Player
    {
        private int _PlayerID;
        private string _PlayerName;
        private int _PlayerHeight;
        private int _PlayerAge;
        private int _RunningDistance;
        private double _RunningSpeed;

        public Player(int ID, string name, int height, int age, int dist, double speed)
        {
            this._PlayerID = ID;
            this._PlayerName = name;
            this._PlayerHeight = height;
            this._PlayerAge = age;
            this._RunningDistance = dist;
            this._RunningSpeed = speed;
        }

        public Player() { }

        [Column(IsPrimaryKey = true, Storage = "_PlayerID")]
        public int ID
        {
            get
            {
                return this._PlayerID;
            }
            set
            {
                this._PlayerID = value;
            }
        }

        [Column(Storage = "_PlayerName")]
        public string name
        {
            get
            {
                return this._PlayerName;
            }
            set
            {
                this._PlayerName = value;
            }
        }

        [Column(Storage = "_PlayerHeight")]
        public int height
        {
            get
            {
                return this._PlayerHeight;
            }

            set
            {
                this._PlayerHeight = value;
            }
        }

        [Column(Storage = "_PlayerAge")]
        public int age
        {
            get
            {
                return this._PlayerAge;
            }

            set
            {
                this._PlayerAge = value;
            }
        }

        [Column(Storage = "_RunningDistance")]
        public int dist
        {
            get
            {
                return this._RunningDistance;
            }
            set
            {
                this._RunningDistance = value;
            }
        }

        [Column(Storage = "_RunningSpeed")]
        public double speed
        {
            get
            {
                return this._RunningSpeed;
            }
            set
            {
                this._RunningSpeed = value;
            }
        }
    }
}
