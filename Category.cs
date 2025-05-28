using System.Collections.Generic;

namespace NotApplication2
{
    internal class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
      static  public List<Category> Categorys = new List<Category>()
        {


new Category {id=1, Name = "Personal" },
new Category {id=2, Name = "Work" },
new Category {id=3, Name = "Study" },
new Category {id=4, Name = "Ideas" }
        };


        public override string ToString()
        {
            return $"{id} , {Name}";
        }
    }
}
