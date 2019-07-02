using MovieFilter.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieFilter.Filters
{
    public sealed class GenreFilter : DefaultFilter
    {
        private CheckBox checkBox;

        public GenreFilter(CheckBox checkBox)
        {
            this.checkBox = checkBox;
        }

        public override List<Movie> FilterDataMovies()
        {
            return base.FilterDataMovies().Where(x => x.Genre == checkBox.Text).ToList();
        }

        public List<string> FilterValuesMovies()
        {
            return base.FilterDataMovies().Select(x => x.Genre).Distinct().ToList();
        }
    }
}
