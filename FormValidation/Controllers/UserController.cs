using System;
using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

public class UserController : Controller {
    [HttpGet]
    public IActionResult Add() {
        return View();
    }
}