using HospEnCasa02Login.Login;
using HospiEnCasa02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa02.Controllers
{
    //Prueba
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

           PersonaLogin personaLogin = new PersonaLogin();
            return View(personaLogin.persona());

           // PacienteLogin pacienteLogin = new PacienteLogin();
            //return View(pacienteLogin.paciente());

            //EnfermeraLogin enfermeraLogin = new EnfermeraLogin();
            //return View(enfermeraLogin.enfermera());

            //MedicoLogin medicoLogin = new MedicoLogin();
            //return View(medicoLogin.medico());

           // FamiliarDesignadoLogin medicoLogin = new FamiliarDesignadoLogin();
            //return View(medicoLogin.familiarDesignado());

           // CasaPacienteLogin casaPacienteLogin = new CasaPacienteLogin();
            //return View(casaPacienteLogin.casaPaciente());


        }

        public IActionResult Index1()
        {



            PacienteLogin pacienteLogin = new PacienteLogin();
            return View(pacienteLogin.paciente());

            //EnfermeraLogin enfermeraLogin = new EnfermeraLogin();
            //return View(enfermeraLogin.enfermera());

            //MedicoLogin medicoLogin = new MedicoLogin();
            //return View(medicoLogin.medico());

            // FamiliarDesignadoLogin medicoLogin = new FamiliarDesignadoLogin();
            //return View(medicoLogin.familiarDesignado());

            // CasaPacienteLogin casaPacienteLogin = new CasaPacienteLogin();
            //return View(casaPacienteLogin.casaPaciente());


        }


    }
}
