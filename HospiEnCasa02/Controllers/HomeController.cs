using HospEnCasa02Login.Login;
using HospiEnCasa02.Models;
using HospiEnCasa02Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PersonaLogin personaLogin = new PersonaLogin();
        private PacienteLogin pacienteLogin = new PacienteLogin();
        private CasaPacienteLogin casaPacienteLogin = new CasaPacienteLogin();
        private CiudadLogin ciudadLogin = new CiudadLogin();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ///esto es una prueba leroleor
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

            //CiudadLogin ciudadLogin = new CiudadLogin();
           // return View(ciudadLogin.ciudad());

            // SignosVitaleLogin signoVitalesLogin = new SignosVitaleLogin();
            //return View(signoVitalesLogin.SignosVitales());

            //SugerenciasCuidadoLogin sugerenciasCuidado = new SugerenciasCuidadoLogin();
            //return View(sugerenciasCuidado.sugerenciasCuidado());

        }

   

        public IActionResult CreatePersona() {

            return View();
        }
        [HttpPost]
        public IActionResult CreatePersona(PersonaEntity personaEntity) {
            personaLogin.addPerson(personaEntity);
            return View(personaEntity);
        }

        public IActionResult CreatePaciente()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreatePaciente(PacienteEntity pacienteEntity)
        {
            pacienteLogin.addPaciente(pacienteEntity);
            return View(pacienteEntity);
        }


        public IActionResult CreateCasaPaciente()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateCasaPaciente(CasaPacienteEntity casaPacienteEntity)
        {
            casaPacienteLogin.addCasaPaciente(casaPacienteEntity);
            return View(casaPacienteEntity);
        }



        public IActionResult CreateCiudad()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateCiudad(CiudadEntity ciudadEntity)
        {
            ciudadLogin.addCiudad(ciudadEntity);
            return View(ciudadEntity);
        }


    }
}
