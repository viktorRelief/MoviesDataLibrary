using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MovieFilter.Data
{
    public class MoviesData
    {
        private Movies movies;

        public MoviesData()
        {
            movies = new Movies();
        }

        public Movies GetAllMovies()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Movies), new XmlRootAttribute("movies"));

            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Data\\movies.xml", FileMode.Open))
            {
                movies = serializer.Deserialize(fs) as Movies;
            }

            return movies;
        }
    }

    [XmlRoot(ElementName = "movies")]
    public class Movies
    {
        [XmlElement(ElementName = "movie")]
        public List<Movie> Movie { get; set; }
    }

    [XmlRoot(ElementName = "movie")]
    public class Movie
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "year")]
        public string Year { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "summary")]
        public string Summary { get; set; }
        [XmlElement(ElementName = "director")]
        public List<Director> Director { get; set; }
        [XmlElement(ElementName = "actor")]
        public List<Actor> Actor { get; set; }
    }

    [XmlRoot(ElementName = "director")]
    public class Director
    {
        [XmlElement(ElementName = "last_name")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "first_name")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "birth_date")]
        public string BirthDate { get; set; }
    }

    [XmlRoot(ElementName = "actor")]
    public class Actor
    {
        [XmlElement(ElementName = "first_name")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "last_name")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "birth_date")]
        public string BirthDate { get; set; }
        [XmlElement(ElementName = "role")]
        public string Role { get; set; }
    }
}