﻿using InstitutoServices.Interfaces;

namespace InstitutoServices.Models.Commons
{
    public class InscriptoCarrera : IEntityWithId
    {
        public int Id { get; set; }
        public int? AlumnoId { get; set; }
        public Alumno? Alumno { get; set; } = null;
        public int? CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Alumno?.ApellidoNombre} {Carrera?.Nombre}" ?? string.Empty;
        }
    }
}
