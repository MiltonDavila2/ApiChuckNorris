using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ApiChuckNorris.Models
{
    public class ChuckNorrisChiste
    {
        [PrimaryKey]
        public string id { get; set; }

        public string url { get; set; }

        public string value { get; set; }


    }
}
