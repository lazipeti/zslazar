﻿using System.Collections.Generic;
using System.Linq;
using WareHouse.Models;
using WareHouse.Repositories;
using WareHouse.ViewModels;

namespace WareHouse.Services
{
    public class ClothesService
    {
        private ClothesRepository clothesRepository;

        public ClothesService(ClothesRepository clothesRepository)
        {
            this.clothesRepository = clothesRepository;
        }

        public List<Clothes> GetClothes()
        {
            return clothesRepository.GetAllClothes();
        }

        public List<string> Sizes()
        {
            return clothesRepository.GetAllClothes().Select(s => s.Size).Distinct().OrderBy(s => s).ToList();
        }

        public List<string> ItemNames()
        {
            return clothesRepository.GetAllClothes().Select(n => n.ItemName).Distinct().OrderBy(n => n).ToList();
        }

        public ClothesViewModel GenerateVM()
        {
            ClothesViewModel clothesViewModel = new ClothesViewModel
            {
                Sizes = Sizes(),
                ItemNames = ItemNames(),
                Clothes = GetClothes()
            };

            return clothesViewModel;
        }

        public Summary GetSummary(string name, string size, int quantity)
        {
            var currentClothes = clothesRepository.GetNameAndSize(name, size);
            Summary summary = new Summary
            {
                ItemName = currentClothes.ItemName,
                Category = currentClothes.Category,
                Manufacturer = currentClothes.Manufacturer,
                Size = currentClothes.Size,
                Quantity = quantity,
                TotalPrice = currentClothes.UnitPrice * quantity
            };

            return summary;
        }

        public List<Clothes> GetFilteredListByPrice(double price, string type)
        {
            return clothesRepository.GetTypeDependOnPrice(price, type);
        }
    }
}
