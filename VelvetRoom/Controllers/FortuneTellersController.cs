using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VelvetRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VelvetRoom.Models;
using VelvetRoom.Views.Shared;


namespace VelvetRoom.Controllers
{
    public class FortuneTellersController : Controller
    {
        public IActionResult FortuneTelling()
        {
            FortuneTellerModel model = new FortuneTellerModel();
            FortuneTeller fortuneTeller= model.fortuneTellerIgor;
            ViewData["Message"] = "beschreibung";
                
            ViewData["NumTimes"] = "1";
            return View();
 }
        public void DropDownList() { }

        public void Selection_Change(object sender, EventArgs e)
        {
        }

    }
}
