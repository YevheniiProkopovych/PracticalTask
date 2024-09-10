using LHHP_COAC_Practical_Task.Enums;
using LHHP_COAC_Practical_Task.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHHP_COAC_Practical_Task.CaffeCompanyFolder
{
    public class DessertsModel
    {
        public Desserts DessertType { get; set; }

        public int DessertsQuantity { get; set; }

        public int Day { get; set; }

        public DessertsModel(Desserts dessert, int desserQuantity, int day)
        {
            DessertType = dessert;
            DessertsQuantity = desserQuantity;
            Day = day;
        }

        public override string ToString()
        {
            return $"\nName: {DessertType.ToString()}," +
                   $" Quantity: {DessertsQuantity}," +
                   $" Pice: {EnumFieldAttributeHelpers.GetValueFromAttribute(DessertType)}, Day: {Day}";
        }
    }
}
