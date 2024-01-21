using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemory.Model
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string? NameMaterial { get; set; }
        public double PriceMaterial { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Length { get; set; }
        public double? Thickness { get; set; }



        static int cont = 0;

        public Material(int materialId, string nameMaterial, double priceMaterial)
        {
            MaterialID = materialId;
            NameMaterial = nameMaterial;
            PriceMaterial = priceMaterial;
        }

        public Material(int materialId, string nameMaterial, double priceMaterial, double width, double height, double length, double thickness)
        {
            MaterialID = materialId;
            NameMaterial = nameMaterial;
            PriceMaterial = priceMaterial;
            Width = width;
            Height = height;
            Length = length;
            Thickness = thickness;
        }


    }
}