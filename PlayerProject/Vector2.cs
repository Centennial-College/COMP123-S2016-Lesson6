using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Author: Kevin Ma
 * Date: June 18, 2016
 * StudentID: 300867968
 * Description: This class is used to describe the x and y coordinates for an object
 * Version: 0.01 - Initial Class creation with Getters and Setters for x and y
 */
namespace PlayerProject
{
    /**
     * <summary>
     * This class contains two properties X and Y which are related to geospatial information
     * for game objects
     * </summary>
     * 
     * @class Vector2
     * @property {float} x - defines the x coordinate
     * @property {float} y - defines the y coordinate
     */
    public class Vector2
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS) +++++++++++++++++++++++++++++++++++++++++++++
        private float _x;
        private float _y;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public float X
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public float Y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**
         * <summary>
         * This constructor takes two parameters: x and y which represent the x and y
         * coordinates of an object
         * </summary>
         * 
         * @constructor Vector2
         * @param {float} x - the x coordinate
         * @param {float} y - the y coordinate
         */
        public Vector2(float x = 0, float y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Zero()
        {
            this.X = 0f;
            this.Y = 0f;
        }
    }
}