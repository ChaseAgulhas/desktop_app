/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: MenuFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.main.factories.menu
{
    class MenuFactory
    {
        public static Menu getMenu(String category)
        {
            Menu menuObject = new Menu();
            menuObject.Category = category;
            return menuObject;
        }
    }
}
