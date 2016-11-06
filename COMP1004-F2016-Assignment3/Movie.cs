﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COMP1004_F2016_Assignment3
{
    class Movie
    {
        // PRIVATE INSTANCE VARIABLES ---------------------------------------------------
        private String _title;
        private String _category;
        private double _cost;
        private Image _image;

        // PUBLIC PROPERTIES ------------------------------------------------------------
        public String Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public String Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        public double Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // PUBLIC UTILITY METHODS -------------------------------------------------------
        /// <summary>
        /// Returns cost as a formatted string using '$'.
        /// </summary>
        public String getCostAsFormattedString()
        {
            return this._cost.ToString("C2");
        }
    }
}