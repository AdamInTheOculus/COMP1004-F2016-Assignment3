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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_F2016_Assignment3
{
    class MovieList
    {
        // PRIVATE INSTANCE VARIABLES ---------------------------------------------------
        private List<Movie> _movies;
        private Movie _currentMovie;

        // PUBLIC PROPERTIES ------------------------------------------------------------
        public List<Movie> Movies
        {
            get { return _movies; }
        }

        public Movie CurrentMovie
        {
            get { return this._currentMovie; }
            set { this._currentMovie = value; }
        }

        // CONSTRUCTOR ------------------------------------------------------------------
        public MovieList()
        {
            // Initialize empty list
            _movies = new List<Movie>();
        }

        // PUBLIC UTILITY METHODS -------------------------------------------------------
        /// <summary>
        /// Read movie list from .txt file.
        /// Create new movie object for each line, add to movie list.
        /// </summary>
        public void GenerateMovieList()
        {
            // Open file containing movies
            String filepath = "..\\..\\Resources\\movies.txt";

            // Attempt to read file by each line and create movie object.
            try
            {
                // 'using' implements IDisposable interface ...
                // ... automatically cleans up IO after we're done.
                using (StreamReader sr = File.OpenText(filepath))
                {
                    String line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Generate movie object
                        Movie currentMovie = GenerateMovieObject(line);

                        // Add movie to movie list
                        if (currentMovie != null)
                        {
                            Movies.Add(currentMovie);
                        }
                        else
                        {
                            Console.WriteLine("-- CRITICAL ERROR -- Created movie is null.");
                        }
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(" -- Unable to locate file -- " + filepath);
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(" -- CRITICAL ERROR -- " + e.Message);
            }
        }

        /// <summary>
        /// Returns movie object if title is matched with movie in list.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public Movie GetMovieByTitle(String title)
        {
            // Iterate through each Movie until a match is found.
            foreach(Movie movie in Movies)
            {
                // Match found. Return actual movie.
                if(movie.Title.Equals(title))
                {
                    return movie;
                }
            }

            // Return null when no movies are found.
            return null;
        }

        // PRIVATE UTILITY METHODS ------------------------------------------------------
        /// <summary>
        /// Parses line from text file and converts to Movie object.
        /// Creates new Image object from image file path.
        /// Returns new Movie object.
        /// </summary>
        /// <param name="line"></param>

        private Movie GenerateMovieObject(String line)
        {
            Movie movie = null;

            // Line format: [MOVIE TITLE], [CATEGORY], [COST], [IMG FILENAME]
            try
            {
                // Parse line by comma delimiter
                String[] movieDetails = line.Split(',');

                // Get path of image for specific movie
                String imagePath = "..\\..\\Resources\\imgs\\" + movieDetails[3].Trim();

                // Create new movie object with sliced data
                movie = new Movie(movieDetails[0].Trim(), movieDetails[1].Trim(), Convert.ToDouble(movieDetails[2].Trim()), 
                    Image.FromFile(imagePath));

                // Return successfully created movie
                return movie;
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("-- Unable to locate file -- " + e.Message);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(" -- Unable to convert to double -- " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(" -- Critical Error -- " + e.Message);
            }

            // Return null movie if unsuccessful.
            return movie;
        }

    }
}
