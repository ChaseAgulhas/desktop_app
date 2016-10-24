/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Menu.cs
    Subject: Technical Programming 2
*/
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
        public Menu(){}

        public string Category
        {
            get{return category;}
            set{ category = value; }
        }

        private class Builder
        {
            private String category;

            public Builder() { }

            public Builder Category(String category)
            {
                this.category = category;
                return this;
            }

            public Builder copy(Menu menu)
            {
                this.category = menu.category;
                return this;
            }

            public Menu build()
            {
                return new Menu();
            }
        }
    }
}
