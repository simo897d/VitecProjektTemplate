﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecWithTemplateAPI.Models;

namespace VitecWithTemplateAPI.Data
{
    public class SeedDatabase
    {
        public static void Initialize(VitecWithTemplateAPIContext Context) {
            Context.Database.EnsureCreated();

            if (Context.Product.Any()) {
                return;
            } else {
                Product product = new Product {
                    Title = "CDOrd",
                    Description = "Læse- og skriveværktøjet CD-ORD er kendt for at forløse ordblinde børn og voksnes potentiale for at læse, skrive og lære.",
                    Price = 200,
                    Picture = "Not found"
                };
                Context.Add(product);
                Context.SaveChanges();
            }
        }
    }
}
