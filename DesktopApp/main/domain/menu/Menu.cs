/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: Menu.cs
    Subject: Technical Programming 2
*/
using System;

namespace DesktopApp.main.domain
{
    [Serializable]
    public class Menu
    {
        private string category;
        public Menu(){}

        public Menu(string category)
        {
            this.category = category;
        }

        public string Category
        {
            get{return category;}
            set{ category = value; }
        }
    }
}
