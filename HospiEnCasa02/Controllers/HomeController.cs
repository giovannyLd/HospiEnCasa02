using HospEnCasa02Login.Login;
using HospiEnCasa02.Models;
using HospiEnCasa02Entity.Entity;
using Microsoft.AspNetCore.Http;
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
        private SugerenciasCuidadoLogin sugerenciasCuidadoLogin = new SugerenciasCuidadoLogin();
        private SignosVitaleLogin signosVitaleLogin = new SignosVitaleLogin();
        private EnfermeraLogin enfermeraLogin = new EnfermeraLogin();
        private MedicoLogin medicoLogin = new MedicoLogin();
        private FamiliarDesignadoLogin familiarDesignadoLogin = new FamiliarDesignadoLogin();
        private LoginLogin loginLogin = new LoginLogin();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

     

            public IActionResult index()
            {

                return View();
            }

        public IActionResult datosPersona(string nombre="" ) {

            List<PersonaEntity> listPersonaEntities = new List<PersonaEntity>();
            if (string.IsNullOrEmpty(nombre))  {
                listPersonaEntities = personaLogin.persona();
            }
            else     {
            listPersonaEntities = personaLogin.persona().Where(x => x.Nombre.ToUpper().Contains(nombre.ToUpper())).ToList();
            }
            return View(listPersonaEntities);  }

        public IActionResult CreatePersona() {

            return View();
        }

        [HttpPost]
        public IActionResult CreatePersona(PersonaEntity personaEntity) {
           
            var person = personaLogin.addPerson(personaEntity);

            ViewBag.Message = person.Mensaje;
            ViewBag.Type = person.tipo;
            return View(personaEntity);
        }

        public IActionResult CreateLogin(){

            return View();
        }

        [HttpPost]
        public IActionResult CreateLogin(LoginEntity loginEntity)
        {
            //  var token = loginLogin.logueo(loginEntity);

            //  return View(loginLogin.logueo(loginEntity));


            return View(loginEntity);
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
        public IActionResult CreateSugernciaCuidado()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateSugernciaCuidado(SugerenciasCuidadoEntity sugerenciaCuidadoEntity)

        {
            sugerenciasCuidadoLogin.addSugerenciasCuidad(sugerenciaCuidadoEntity);
            return View(sugerenciaCuidadoEntity);
        }
        public IActionResult CreateSignosVitales() {

            return View();

        }

        [HttpPost]
        public IActionResult CreateSignosVitales(SignosVitaleEntity signosVitalesEntity) {

            signosVitaleLogin.addSignosVitales(signosVitalesEntity);

            return View(signosVitalesEntity);
        }

        public IActionResult CreateEnfermera()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateEnfermera(EnfermeraEntity enfermeraEntity)
        {
            enfermeraLogin.addEnfermera(enfermeraEntity);

            return View(enfermeraEntity);
        }
        public IActionResult CreateMedico()
        {

            return View();


        }
        [HttpPost]
        public IActionResult CreateMedico(MedicoEntity medicoEntity)

        {
            medicoLogin.addMedico(medicoEntity);

            return View(medicoEntity);
        }

        public IActionResult CreateFamiliarDesignado()
        {

            return View();


        }
        [HttpPost]
        public IActionResult CreateFamiliarDesignado(FamiliarDesignadoEntity familiarDesignadoEntity)

        {
            familiarDesignadoLogin.addfamiliarDesignado(familiarDesignadoEntity);

            return View(familiarDesignadoEntity);
        }


        
        public IActionResult CreatePruebas()
        {

            return View();
        }

        public IActionResult CreatePruebas(LoginEntity loginEntity)
        {

            return View(loginEntity);
        }


    }
}
