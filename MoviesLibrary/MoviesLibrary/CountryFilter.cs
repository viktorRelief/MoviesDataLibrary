using MovieFilter.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieFilter.Filters
{
    public sealed class CountryFilter : DefaultFilter
    {
        private CheckBox checkBox;

        public CountryFilter(CheckBox checkBox)
        {
            this.checkBox = checkBox;
        }

        public override List<Movie> FilterDataMovies()
        {
            return base.FilterDataMovies().Where(x => x.Country == checkBox.Text).ToList();
        }

        public List<string> FilterValuesMovies()
        {
            return base.FilterDataMovies().Select(x => x.Country).Distinct().ToList();
        }
    }
}
