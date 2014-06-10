﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.WebUI.Models
{
    public class Event
    {
        public int id { get; set; } //this will be the pNight id from the db
        public string title { get; set; } //bvStoreNum
        public int someImportantKey { get; set; } //to hold charity id
        public string charityName { get; set; } //charity name
        public string storeNum { get; set; } //store number
        public string start { get; set; }  //start date/time
        public string end { get; set; }  //end date/time
        public bool allDay { get; set; }
    }
}