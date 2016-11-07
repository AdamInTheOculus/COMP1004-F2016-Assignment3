/*
 * App Name: Movie Bonanza Selector
 * App Description: This app allows users to select from a list of movies, and stream them.
 *                  There is also an option to purchase a DVD for an extra $9.99.
 *                  
 * Creation Date: October 29th 2016
 * Author's Name: Adam Sinclair
 * Student ID #: 200321984
 * */
using System;
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

        // CONSTRUCTOR ------------------------------------------------------------------
        public Movie(String title, String category, double cost, Image image)
        {
            this.Title = title;
            this.Category = category;
            this.Cost = cost;
            this.Image = image;
        }

        // Override ToString() ----------------------------------------------------------
        override
        public String ToString()
        {
            String str = "";

            str += "\tTitle: " + this.Title + "\n";
            str += "\tCategory: " + this.Category + "\n";
            str += "\tCost: " + GetCostAsFormattedString() + "\n";

            return str;
        }

        // PUBLIC UTILITY METHODS -------------------------------------------------------
        /// <summary>
        /// Returns cost as a formatted string using '$'.
        /// </summary>
        public String GetCostAsFormattedString()
        {
            return this._cost.ToString("C2");
        }
    }
}
