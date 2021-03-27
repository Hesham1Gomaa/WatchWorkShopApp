using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchWorkShopApp.Models;

namespace WatchWorkShopApp.Services
{
    public class ProductService
    {

        List<Product> productList = new List<Product> {
             new Product
            {
                Id=1,
                Name="Casio EFR-539SG-7A5VUDF",
                ImageUrl="https://cf5.s3.souqcdn.com/item/2015/03/19/79/82/37/8/item_L_7982378_7258594.jpg",
                Price=250,
                Description=" Casio EFR-539SG-7A5VUDF Description Factory Hot Sale Luxury Custom Logo 3ATM Waterproof Stainless Steel Automatic Mechanical Man Watch for Watch Relogio"
            },
             new Product
            {
                Id=2,
                Name="Casio MTP-VDO1L",
                ImageUrl="https://cf1.s3.souqcdn.com/item/2020/06/22/13/12/16/32/4/item_L_131216324_52fdef468d099.jpg",
                Price=200,
                Description=" Casio MTP-VDO1L Description Factory Hot Sale Luxury Custom Logo 3ATM Waterproof Stainless Steel Automatic Mechanical Man Watch for Watch Relogio"

            },
            new Product
            {
                Id=3,
                Name="Casio MTP 1374L",
                ImageUrl="https://cf2.s3.souqcdn.com/item/2016/05/17/79/82/36/5/item_L_7982365_14381122.jpg",
                Price=250,
                Description=" Casio MTP 1374L Description Factory Hot Sale Luxury Custom Logo 3ATM Waterproof Stainless Steel Automatic Mechanical Man Watch for Watch Relogio"

            }
        };
        public List<Product> GetAllProducts() =>  productList;

        public Product GetProdcutByID(int Id) => productList.FirstOrDefault(c => c.Id == Id);

    }
}
