/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: FoodItemFactory.cs
    Subject: Technical Programming 2
*/
using DesktopApp.main.domain;
using System;

namespace DesktopApp.main.factories.foodItem
{
    public class FoodItemFactory
    {
        public static FoodItem getFoodItem(String name, double price,int amountAvailable)
        {
            FoodItem foodObject = new FoodItem();
            foodObject.Name = name;
            foodObject.Price = price;
            foodObject.AmountAvailable = amountAvailable;
            return foodObject;
        }
    }
}
