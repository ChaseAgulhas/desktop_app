using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain
{
    [Serializable]
    class Menu
    {
        private string category;
        public Menu()
        {

        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public string getCategory()
        {
            return category;
        }
    }
}
