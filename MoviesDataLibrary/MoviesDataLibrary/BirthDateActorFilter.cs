using MovieFilter.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieFilter.Filters
{
    public sealed class BirthDateActorFilter : DefaultFilter
    {
        private CheckBox checkBox;

        public BirthDateActorFilter(CheckBox checkBox)
        {
            this.checkBox = checkBox;
        }

        public List<Actor> FilteredDataActors(int index)
        {           
            return FilterDataActors()[index].Where(x => x.BirthDate == checkBox.Text).ToList();
        }

        public List<string> FilterValuesActors(int index)
        {
            return FilterDataActors()[index].Select(x => x.BirthDate).Distinct().ToList();
        }
    }
}
