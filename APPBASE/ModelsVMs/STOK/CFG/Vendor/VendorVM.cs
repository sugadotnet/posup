﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class VendorVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public string VENDOR_CODE { get; set; }
        public string VENDOR_NAME { get; set; }
    } //End public partial class VendorVM
} //End namespace APPBASE.Models
