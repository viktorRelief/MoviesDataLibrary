using MovieFilter.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieFilter.Filters
{
    public sealed class YearFilter : DefaultFilter
    {
        private CheckBox checkBox;

        public YearFilter(CheckBox checkBox)
        {
            this.checkBox = checkBox;
        }

        public override List<Movie> FilterDataMovies()
        {
            return base.FilterDataMovies().Where(x => x.Year == checkBox.Text).ToList();
        }

        public List<string> FilterValuesMovies()
        {
            return base.FilterDataMovies().Select(x => x.Year).Distinct().ToList();
        }
    }
}
