using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class SuggestionModel
    {
        //Properties

        [Key] //key keeps track of auto implementing ID in this case (uses line right below)
                // and ONLY line below ID here, topic and comment aren't included)
        public int ID { get; set; }

        public string Topic { get; set; }

        public string Comment { get; set; }

        // { get; set; } is shorthand for 
        //get { return this.whatever; } set { this.whatever = value; }

    }   
}