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
    class Menu
    {
        private string category;
        public Menu(){}

        public string Category
        {
            get{return category;}
            set{ category = value; }
        }
    }
}
