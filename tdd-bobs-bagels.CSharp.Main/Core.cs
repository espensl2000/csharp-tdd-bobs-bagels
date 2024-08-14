using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        private List<string> _bagels;
        private int _capacity;

        public Basket()
        {
            this._bagels = new List<string>();
            this._capacity = 3;
        }

        public List<string> Bagels { get => this._bagels; set => this._bagels = value; }
        public int Capacity { get => this._capacity; set => this._capacity = value; }

        public bool AddBagel(string bagel)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBagel(string bagel)
        {
            throw new NotImplementedException();
        }

        public bool ExtendBasket(int capacity)
        {
            throw new NotImplementedException();
        }

    }
}
