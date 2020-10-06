using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Biz
{
    public class Collections
    {
        public Collections()
        {
            //var colorOptions = new string[4];
            //colorOptions[0] = "Red";
            //colorOptions[1] = "Espresso";
            //colorOptions[2] = "White";
            //colorOptions[3] = "Navy";

            string[] colorOptions = { "Red", "Espresso", "White", "Navy" };
            foreach (var color in colorOptions)
            {
                Console.WriteLine($"The color is {color}");
            }
            Console.WriteLine(colorOptions);
        }

        public Collections(int collectionsId,
                        string collectionsName,
                        string description) : this()
        {
            this.CollectionsId = collectionsId;
            this.CollectionsName = collectionsName;
            this.Description = description;
        }
        public string Description { get; set; }

        public int CollectionsId { get; set; }

        private string collectionsName;
        public string CollectionsName
        {
            get
            {
                var formattedValue = collectionsName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";

                }
                else
                {
                    collectionsName = value;

                }
            }
        }
        
        public string ValidationMessage { get; private set; }

        public override string ToString()
        {
            return this.CollectionsName + " (" + this.CollectionsId + ")";
        }
    }
}
