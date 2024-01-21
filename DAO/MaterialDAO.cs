using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Model;

namespace InMemory.DAO
{
    public class MaterialDAO
    {
        private List<Material> materials = new List<Material>();

        private static MaterialDAO unica;

        public static MaterialDAO GetMaterialDAO()
        {
            if (unica == null)
            {
                unica = new MaterialDAO();
            }
            return unica;
        }

        public void CreateMaterial(Material material)
        {
            materials.Add(material);
        }


        public void DeleteMaterial(int id)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials[i].MaterialID == id)
                {
                    materials.Remove(materials[i]);
                }
            }
        }

        public void UpdateMaterial(Material material)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials[i].MaterialID == material.MaterialID)
                {
                    materials[i] = material;
                }
            }
        }




        public List<Material> ListarMaterials()
        {
            return materials;
        }

        ////////////////////////////////////////////////metodos para a calculadora :
        public Material GetMaterial(int id)
        {
            System.Console.WriteLine("entrou no metodo da DAO");
            System.Console.WriteLine("count: " + materials.Count);

            for (int i = 0; i < materials.Count; i++)
            {
                if (materials[i].MaterialID == id)
                {

                    return materials[i];

                }
            }
            return null;
        }
        ////////////////////////////////////////////////////////////////





    }
}