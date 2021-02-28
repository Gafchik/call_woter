using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_woter.Model
{
    public class Proprety_Model
    {
        public string weight { get; set; }
        public string type_live { get; set; }
        public string gender { get; set; }
        public Proprety_Model(string weight, string type_live, string gender)
        {
            this.gender = gender;
            this.type_live = type_live;
            this.weight = weight;
        }
    }
}
