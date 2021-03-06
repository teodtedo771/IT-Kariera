﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Preparation.Vehicle
{
    abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunk;
        private bool isFull;
        private bool isEmpty;

        public Vehicle()
        {
            Trunk = new List<Product>();
        }

        public Vehicle(int capacity)
        {
            trunk = new List<Product>();
            this.Capacity = capacity;
        }

        public bool IsEmpty => this.Trunk.Count == 0;

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;



        public List<Product> Trunk
        {
            get { return trunk; }
            set { trunk = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public void LoadProduct(Product product)
        {
            if (!IsFull)
            {
                trunk.Add(product);
            }
            else
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
        }
        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            else
            {
                Product temp = trunk.Last();
                trunk.Remove(trunk.Last());
                return temp;
            }
        }
    }
}
