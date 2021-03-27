using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchWorkShopApp.Models;

namespace WatchWorkShopApp.Services
{
    public class ProductService
    {
        public List<Product> GetAllProducts() => new List<Product>
        {
            new Product
            {
                Id=1,
                Name="Casio EFR-539SG-7A5VUDF",
                ImageUrl="https://cf5.s3.souqcdn.com/item/2015/03/19/79/82/37/8/item_L_7982378_7258594.jpg",
                Price=250
            },
             new Product
            {
                Id=2,
                Name="Casio MTP-VDO1L",
                ImageUrl="https://cf1.s3.souqcdn.com/item/2020/06/22/13/12/16/32/4/item_L_131216324_52fdef468d099.jpg",
                Price=200
            }, new Product
            {
                Id=3,
                Name="Casio MTP 1374L",
                ImageUrl="https://cf2.s3.souqcdn.com/item/2016/05/17/79/82/36/5/item_L_7982365_14381122.jpg",
                Price=250
            }
        };
           
    }
}
