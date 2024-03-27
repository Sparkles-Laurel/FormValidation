using System;
using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

public class KitapController : Controller {
    [HttpGet]
    public IActionResult Add() {
        return View();
    }
}